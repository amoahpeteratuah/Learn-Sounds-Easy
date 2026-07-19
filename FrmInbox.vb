Public Class Frminbox

    ' this will hold the currently selected in the inbox
    Private currentPrescription As Modmainlog.Prescription = Nothing

    ' this will hold items before final dispense
    Private orderItems As New List(Of Modmainlog.Orderdrug)

    ' this is for timer — blocks SelectedIndexChanged during auto-refresh
    Private istimerRef As Boolean = False



    Private Sub Frminbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Frmmainpage

        ' FIX: Set AutoGenerateColumns = False FIRST before anything else.
        ' Without this, Rows.Add() adds data to invisible auto-generated columns
        ' and nothing shows in the grid even though no error is thrown.
        dgvpharmacy.AutoGenerateColumns = False
        dgvpharmacy.ReadOnly = True
        dgvpharmacy.AllowUserToAddRows = False
        dgvpharmacy.RowHeadersVisible = False

        ' FIX: Button is always enabled from the start.
        ' Validation happens inside btndispensePrint_Click instead.
        ' Previously, Loadinbox() was disabling it when inbox was empty,
        ' which stopped the pharmacist dispensing even with a full order summary.
        btndispensePrint.Enabled = True

        loadcmbCategory()
        Loadmedicmb("All Categories")
        Loadinbox()
        updateTotal()

        TmrPhar.Start()
    End Sub


    ' Fires every 2 seconds to keep inbox live without needing focus.
    ' Sets istimerRef = True before refresh so SelectedIndexChanged
    ' knows not to clear the order summary during auto-refresh.
    Private Sub TimerPhar_Tick(sender As Object, e As EventArgs) Handles TmrPhar.Tick
        istimerRef = True
        Loadinbox()
        istimerRef = False
    End Sub


    ' Loads all Pending prescriptions into the ListBox.
    ' Numbers (1, 2, 3...) are display labels only — not stored in DB.
    Private Sub Loadinbox()

        ' save current selection before clearing
        Dim prevselection As Integer = Lstinbox.SelectedIndex

        Lstinbox.Items.Clear()

        Dim pending As List(Of Modmainlog.Prescription) =
            Modmainlog.GetPendingPercription()

        If pending.Count = 0 Then
            Lstinbox.Items.Add(" No Pending prescription")
            ' FIX: Removed btndispensePrint.Enabled = False from here.
            ' The button must stay enabled so the pharmacist can still
            ' finalise an order summary that is already built.
            Return
        End If

        ' loop through pending prescriptions and number them
        For p As Integer = 0 To pending.Count - 1
            Lstinbox.Items.Add(
                (p + 1).ToString() & ". " &
                pending(p).PatientName & " - " &
                pending(p).DateSent.ToString("HH:mm"))
        Next

        ' restore previous selection so timer refresh doesn't
        ' lose the pharmacist's place in the inbox
        If prevselection >= 0 AndAlso prevselection < Lstinbox.Items.Count Then
            Lstinbox.SelectedIndex = prevselection
        End If
    End Sub


    ' Auto-fills drug and dosage from the selected prescription.
    ' Blocked during timer refresh via istimerRef flag.
    Private Sub Lstinbox_SelectedIndexChanged(sender As Object,
            e As EventArgs) Handles Lstinbox.SelectedIndexChanged

        ' IMPORTANT: block this during timer refresh.
        ' Without this, timer restoring SelectedIndex was triggering
        ' this event and clearing the order summary every 2 seconds.
        If istimerRef Then Return

        If Lstinbox.SelectedIndex < 0 Then Return

        ' ignore clicks on the placeholder message
        If Lstinbox.Items(Lstinbox.SelectedIndex).ToString().Trim() _
           .StartsWith("No Pending") Then Return

        ' get the matching prescription from SharedData
        Dim pending As List(Of Modmainlog.Prescription) =
            Modmainlog.GetPendingPercription()
        If Lstinbox.SelectedIndex >= pending.Count Then Return

        ' store the selected prescription for use in Dispense button
        currentPrescription = pending(Lstinbox.SelectedIndex)

        ' auto fill dosage from prescription
        txtdosagephar.Text = currentPrescription.Dosage

        'add notes should the doctor writes note
        If Not String.IsNullOrWhiteSpace(currentPrescription.Notes) Then
            lblnote.Text = currentPrescription.Notes
            lblnote.Visible = True

        Else
            lblnote.Text = "No notes from doctor"
            lblnote.Visible = True
        End If

        ' try to match the prescribed drug in medicine ComboBox
        Dim found As Boolean = False
        For t As Integer = 0 To cmbselectmedi.Items.Count - 1
            If cmbselectmedi.Items(t).ToString() =
               currentPrescription.DrugName Then
                cmbselectmedi.SelectedIndex = t
                found = True
                Exit For
            End If
        Next

        ' if drug not found in current category filter,
        ' reset to All Categories and try again
        If Not found Then
            cmbcategorypharmacy.SelectedIndex = 0
            Loadmedicmb("All Categories")
            For i As Integer = 0 To cmbselectmedi.Items.Count - 1
                If cmbselectmedi.Items(i).ToString() =
                   currentPrescription.DrugName Then
                    cmbselectmedi.SelectedIndex = i
                    Exit For
                End If
            Next
        End If


        ' set default quantity to 1
        txtquantityphar.Text = "1"

        ' clear previous order when switching to a new prescription
        orderItems.Clear()
        dgvpharmacy.Rows.Clear()
        updateTotal()
    End Sub


    Private Sub cmbselectmedi_Validating(sender As Object,
            e As System.ComponentModel.CancelEventArgs) _
            Handles cmbselectmedi.Validating
        Try
            If cmbselectmedi.SelectedIndex = -1 Then
                epinbox.SetError(cmbselectmedi, "Please, select a drug.")
                cmbselectmedi.Focus()
            Else
                epinbox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Added drug validation (was commented out) to prevent crash
    '         on SelectedItem.ToString() when nothing is selected.
    '  Added "If Not isFormValid Then Return" so code stops when
    '         any validation fails instead of continuing to the grid add.
    Private Sub Btndispense_Click(sender As Object, e As EventArgs) _
            Handles BtnaddtoReceipt.Click
        Try
            epinbox.Clear()
            Dim isFormValid As Boolean = True

            ' validate category
            If cmbcategorypharmacy.SelectedIndex = -1 Then
                epinbox.SetError(cmbcategorypharmacy,
                    "Please, select the drug category.")
                isFormValid = False
            End If

            ' Drug validation uncommented and moved BEFORE SelectedItem.ToString().
            ' Previously commented out, which caused a crash when no drug was selected
            ' because SelectedItem would be Nothing.
            If cmbselectmedi.SelectedIndex = -1 Then
                epinbox.SetError(cmbselectmedi,
                    "Please, select a drug from the list.")
                isFormValid = False
            End If

            ' validate quantity
            Dim parsedQuantity As Integer = 0
            If String.IsNullOrWhiteSpace(txtquantityphar.Text.Trim()) Then
                epinbox.SetError(txtquantityphar,
                    "Please enter the quantity received.")
                isFormValid = False
            ElseIf Not Integer.TryParse(txtquantityphar.Text, parsedQuantity) OrElse
                   parsedQuantity <= 0 Then
                epinbox.SetError(txtquantityphar,
                    "Please enter a valid whole number greater than 0.")
                isFormValid = False
            End If

            ' Stop here if ANY validation failed.
            ' Previously this was missing — code was continuing to
            ' SelectedItem.ToString() even when isFormValid = False.
            If Not isFormValid Then Return

            Dim drugname As String = cmbselectmedi.SelectedItem.ToString()

            ' get the drug from Modmainlog
            Dim drug As Modmainlog.Drug = Modmainlog.findstockDrug(drugname)
            If drug Is Nothing Then
                MsgBox("Drug not found in stock.", MsgBoxStyle.Exclamation, "Drug Not Found")
                Return
            End If

            ' check available stock before adding
            If parsedQuantity > drug.CurrentStock Then
                MsgBox("Insufficient Stock! Available: " &
                       drug.CurrentStock.ToString() & " units.",
                       MsgBoxStyle.Exclamation, "Stock Warning")
                Return
            End If

            ' calculate line total
            Dim total As Decimal = parsedQuantity * drug.UnitPrice

            ' add to in-memory order list
            orderItems.Add(New Modmainlog.Orderdrug With {
                .DrugName = drugname,
                .Quantity = parsedQuantity,
                .Unitprice = drug.UnitPrice,
                .Totalprice = total
            })

            ' add to DataGridView — column order must match designer:
            ' Medicine Name | Quantity | Unit Price | Total Price
            dgvpharmacy.Rows.Add(
                drugname,
                parsedQuantity,
                "GHS " & drug.UnitPrice.ToString("F2"),
                "GHS " & total.ToString("F2")
            )

            ' update running total label
            updateTotal()

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' clear fields ready for next item
        cmbselectmedi.SelectedIndex = -1
        txtdosagephar.Clear()
        txtquantityphar.Clear()
    End Sub


    ' Blocks anything that is not a digit or backspace.
    ' Also blocks 0 at the start.
    Private Sub txtquantityphar_KeyPress(sender As Object,
            e As KeyPressEventArgs) Handles txtquantityphar.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) AndAlso
               Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If

            ' block 0 at start
            Dim txt As TextBox = CType(sender, TextBox)
            If e.KeyChar = "0"c AndAlso txt.SelectionStart = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtdosagephar_Validating(sender As Object,
            e As System.ComponentModel.CancelEventArgs) _
            Handles txtdosagephar.Validating
        Try
            If String.IsNullOrWhiteSpace(txtdosagephar.Text.Trim()) Then
                epinbox.SetError(txtdosagephar,
                    "Please, enter the dosage instructions.")
            Else
                epinbox.SetError(txtdosagephar, "")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub tsaddtorecipt_Click(sender As Object, e As EventArgs) _
            Handles tlsaddtorecipt.Click
        Try
            epinbox.Clear()
            Dim isFormValid As Boolean = True

            If cmbcategorypharmacy.SelectedIndex = -1 Then
                epinbox.SetError(cmbcategorypharmacy,
                    "Please, select the drug category.")
                isFormValid = False
            End If

            If cmbselectmedi.SelectedIndex = -1 Then
                epinbox.SetError(cmbselectmedi,
                    "Please, select a drug from the list.")
                isFormValid = False
            End If

            Dim parsedQuantity As Integer = 0
            If String.IsNullOrWhiteSpace(txtquantityphar.Text.Trim()) Then
                epinbox.SetError(txtquantityphar,
                    "Please enter the quantity received.")
                isFormValid = False
            ElseIf Not Integer.TryParse(txtquantityphar.Text, parsedQuantity) OrElse
                   parsedQuantity <= 0 Then
                epinbox.SetError(txtquantityphar,
                    "Please enter a valid whole number greater than 0.")
                isFormValid = False
            End If

            If String.IsNullOrWhiteSpace(txtdosagephar.Text.Trim()) Then
                epinbox.SetError(txtdosagephar,
                    "Please, enter the dosage instructions.")
                isFormValid = False
            End If

            If Not isFormValid Then Return

            Dim drugname As String = cmbselectmedi.SelectedItem.ToString()
            Dim drug As Modmainlog.Drug = Modmainlog.findstockDrug(drugname)

            If drug Is Nothing Then
                MsgBox("Drug not found in stock.", MsgBoxStyle.Exclamation, "Drug Not Found")
                Return
            End If

            If parsedQuantity > drug.CurrentStock Then
                MsgBox("Insufficient Stock! Available: " &
                       drug.CurrentStock.ToString() & " units.",
                       MsgBoxStyle.Exclamation, "Stock Warning")
                Return
            End If

            Dim total As Decimal = parsedQuantity * drug.UnitPrice

            orderItems.Add(New Modmainlog.Orderdrug With {
                .DrugName = drugname,
                .Quantity = parsedQuantity,
                .Unitprice = drug.UnitPrice,
                .Totalprice = total
            })

            dgvpharmacy.Rows.Add(
                drugname,
                parsedQuantity,
                "GHS " & drug.UnitPrice.ToString("F2"),
                "GHS " & total.ToString("F2")
            )

            updateTotal()

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmbselectmedi.SelectedIndex = -1
        txtdosagephar.Clear()
        txtquantityphar.Clear()
    End Sub


    Private Sub btndispensePrint_Click(sender As Object, e As EventArgs) _
            Handles btndispensePrint.Click
        Try
            epinbox.Clear()

            ' only two things matter at dispense time:
            ' A prescription must be selected from the inbox
            ' The order summary must have at least one item
            If currentPrescription Is Nothing Then
                MsgBox("Please select a prescription from the inbox first.",
                       MsgBoxStyle.Exclamation, "No Prescription Selected")
                Return
            End If

            If orderItems.Count = 0 Then
                MsgBox("Please add at least one drug to the order summary first.",
                       MsgBoxStyle.Exclamation, "Empty Order")
                Return
            End If

            ' deduct stock for every item in the order
            For Each item As Modmainlog.Orderdrug In orderItems
                Dim drug As Modmainlog.Drug = Modmainlog.findstockDrug(item.DrugName)
                If drug IsNot Nothing Then
                    drug.CurrentStock -= item.Quantity
                    If drug.CurrentStock < 0 Then drug.CurrentStock = 0
                    ' zero stock → drug disappears from Doctor and Pharmacist dropdowns
                    ' and drops out of GetTotalDrugTypes() count on Dashboard
                    If drug.CurrentStock = 0 Then drug.IsStocked = False
                End If
            Next

            ' add dispensed total to running revenue for Dashboard
            Modmainlog.TotalRevenue += orderItems.Sum(Function(a) a.Totalprice)

            ' mark prescription as Dispensed — removes it from inbox
            currentPrescription.status = "Dispensed"
            currentPrescription.DispensedDate = DateTime.Now

            ' print the receipt
            PrintReceipt()

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return  ' do not reset form if an error occurred during dispense
        End Try

        'Reset order summary and all fields after successful dispense
        orderItems.Clear()
        dgvpharmacy.Rows.Clear()
        updateTotal()
        currentPrescription = Nothing
        txtdosagephar.Clear()
        txtquantityphar.Clear()
        cmbselectmedi.SelectedIndex = -1
        lblnote.Text = ""
        lblnote.Visible = False

        ' reload inbox and dropdowns
        Loadinbox()
        loadcmbCategory()
        Loadmedicmb("All Categories")

        Modmainlog.DashboardNeedsRefer = True
    End Sub


    ' Builds and shows the receipt after successful dispense.
    ' Replace MessageBox with RDLC PrintDocument when adding DB.
    Private Sub PrintReceipt()
        Dim r As String = ""
        r &= "        HOSPITAL PHARMACY RECEIPT" & vbNewLine
        r &= "        ─────────────────────────────────" & vbNewLine
        r &= "Patient:  " & currentPrescription.PatientName & vbNewLine
        r &= "Doctor:   " & currentPrescription.DoctorName & vbNewLine ''''''''''
        If Not String.IsNullOrWhiteSpace(currentPrescription.Doctoremail) Then
            r &= "Email: " & currentPrescription.Doctoremail & vbNewLine
        End If
        r &= "Date:     " & DateTime.Now.ToString("dd/MM/yyyy  HH:mm") & vbNewLine
        'this will print the notes as well
        If Not String.IsNullOrWhiteSpace(currentPrescription.Notes) Then
            r &= "Notes: " & currentPrescription.Notes & vbNewLine
        End If
        r &= vbNewLine
        r &= "Drug".PadRight(22) &
             "Qty".PadRight(6) &
             "Unit Price".PadRight(14) &
             "Total" & vbNewLine
        r &= "────────────────────────────────────────────" & vbNewLine

        For Each item As Modmainlog.Orderdrug In orderItems
            r &= item.DrugName.PadRight(22) &
                 item.Quantity.ToString().PadRight(6) &
                 ("GHS " & item.Unitprice.ToString("F2")).PadRight(14) &
                 "GHS " & item.Totalprice.ToString("F2") & vbNewLine
        Next

        r &= "────────────────────────────────────────────" & vbNewLine
        r &= "TOTAL:".PadRight(42) &
             "GHS " & orderItems.Sum(Function(i) i.Totalprice).ToString("F2") & vbNewLine
        r &= vbNewLine
        r &= "   Thank you. Take medications as prescribed."

        MessageBox.Show(r, "Receipt — Dispensed Successfully",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'Added Return after drug Is Nothing check.
    ' Previously it continued to drug.CurrentStock which crashed
    ' immediately with a NullReferenceException.
    Private Sub tsdispenseandprint_Click(sender As Object, e As EventArgs) _
            Handles tlsdispenseandprint.Click
        Try
            epinbox.Clear()
            Dim isFormValid As Boolean = True

            Dim parsedQuantity As Integer = 0
            If String.IsNullOrWhiteSpace(txtquantityphar.Text.Trim()) Then
                epinbox.SetError(txtquantityphar,
                    "Please enter the quantity to be dispensed.")
                isFormValid = False
            ElseIf Not Integer.TryParse(txtquantityphar.Text, parsedQuantity) OrElse
                   parsedQuantity <= 0 Then
                epinbox.SetError(txtquantityphar,
                    "Please enter a valid whole number greater than 0.")
                isFormValid = False
            End If

            If cmbselectmedi.SelectedIndex = -1 Then
                epinbox.SetError(cmbselectmedi,
                    "Please, select a drug from the list.")
                isFormValid = False
            End If

            If String.IsNullOrWhiteSpace(txtdosagephar.Text.Trim()) Then
                epinbox.SetError(txtdosagephar,
                    "Please, enter the dosage instructions.")
                isFormValid = False
            End If

            If Not isFormValid Then Return

            Dim drugname As String = cmbselectmedi.SelectedItem.ToString()
            Dim drug As Modmainlog.Drug = Modmainlog.findstockDrug(drugname)

            If drug Is Nothing Then
                MsgBox("Drug not in stock list.", MsgBoxStyle.Exclamation, "Not Found")
                Return
            End If

            If parsedQuantity > drug.CurrentStock Then
                MsgBox("Insufficient Stock! Available: " &
                       drug.CurrentStock.ToString() & " units.",
                       MsgBoxStyle.Exclamation, "Stock Warning")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." &
                            ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cmbcategorypharmacy_Validating(sender As Object,
            e As System.ComponentModel.CancelEventArgs) _
            Handles cmbcategorypharmacy.Validating
        If cmbcategorypharmacy.SelectedIndex = -1 Then
            epinbox.SetError(cmbcategorypharmacy, "Please select the category.")
            cmbcategorypharmacy.Focus()
        Else
            epinbox.Clear()
        End If
    End Sub


    Private Sub loadcmbCategory()
        Dim prevoiuscat As String = ""
        If cmbcategorypharmacy.SelectedIndex >= 0 Then
            prevoiuscat = cmbcategorypharmacy.SelectedItem.ToString()
        End If

        cmbcategorypharmacy.Items.Clear()
        For Each cat As String In Modmainlog.GetStockedCategory()
            cmbcategorypharmacy.Items.Add(cat)
        Next

        If cmbcategorypharmacy.Items.Count > 0 Then
            Dim idnn As Integer = cmbcategorypharmacy.Items.IndexOf(prevoiuscat)
            cmbcategorypharmacy.SelectedIndex = If(idnn >= 0, idnn, 0)
        End If
    End Sub


    Private Sub cmbcategorypharmacy_SelectedIndexChanged(sender As Object,
            e As EventArgs) Handles cmbcategorypharmacy.SelectedIndexChanged
        If cmbcategorypharmacy.SelectedIndex >= 0 Then
            Loadmedicmb(cmbcategorypharmacy.SelectedItem.ToString())
        End If
    End Sub


    Private Sub cmbcategorypharmacy_Leave(sender As Object, e As EventArgs) _
            Handles cmbcategorypharmacy.Leave
        If cmbcategorypharmacy.SelectedIndex >= 0 Then
            Loadmedicmb(cmbcategorypharmacy.SelectedItem.ToString())
        End If
    End Sub


    Private Sub cmbselectmedi_DropDown(sender As Object, e As EventArgs) _
            Handles cmbselectmedi.DropDown
        Dim cat As String = "All Categories"
        If cmbcategorypharmacy.SelectedIndex >= 0 Then
            cat = cmbcategorypharmacy.SelectedItem.ToString()
        End If
        Loadmedicmb(cat)
    End Sub



    Public Sub Loadmedicmb(category As String)
        cmbselectmedi.Items.Clear()
        Dim drugs As List(Of Modmainlog.Drug) =
            Modmainlog.GetStockedDrugsByCategory(category)
        If drugs.Count = 0 Then
            cmbselectmedi.Items.Add("--- No drug in this Category ---")
            Return
        End If
        For Each s As Modmainlog.Drug In drugs
            cmbselectmedi.Items.Add(s.Drugname)
        Next
    End Sub


    Private Sub updateTotal()
        Dim grantotal As Decimal = orderItems.Sum(Function(i) i.Totalprice)
        lblrealamount.Text = grantotal.ToString("F2")
    End Sub

    Private Sub Frminbox_Activated(sender As Object, e As EventArgs) _
            Handles Me.Activated
        Loadinbox()
        loadcmbCategory()
    End Sub


    Private Sub Frminbox_FormClosing(sender As Object,
            e As FormClosingEventArgs) Handles Me.FormClosing
        TmrPhar.Stop()   ' stop timer cleanly when form closes
    End Sub

End Class