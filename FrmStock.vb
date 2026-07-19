Public Class FrmStock
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlstockheader.Paint

    End Sub

    Private Sub PanelExpiry_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub DateTimePickerExpiry_ValueChanged(sender As Object, e As EventArgs) Handles dtpExpiryDate.ValueChanged
        dtpExpiryDate.MinDate = DateTime.Today

    End Sub

    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Frmmainpage
        dgvStock.AutoGenerateColumns = False
        lowstockcheck()
        updateDatagrid()
    End Sub


    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        Try


            ' Block anything that is NOT a numeric digit and NOT the backspace key
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If


            'this will block 0 at the start
            Dim txt As TextBox = CType(sender, TextBox)
            If e.KeyChar = "0"c AndAlso txt.SelectionStart = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub



    'creating sub for save stock
    Private Sub saveStockRecord()
        Try


            ' Clear any old red exclamation indicators immediately
            epStock.Clear()
            Dim isFormValid As Boolean = True

            'Validate Drug Name Field (Must not be empty)

            If cmbdrugnamestock.SelectedIndex = -1 Then
                epStock.SetError(cmbdrugnamestock, "Please select a report type.")
                isFormValid = False
            End If

            'Validate Quantity Received (Must not be empty, must be a positive number)
            Dim parsedQuantity As Integer = 0
            If String.IsNullOrWhiteSpace(txtquantity.Text.Trim()) Then
                epStock.SetError(txtquantity, "Please enter the quantity received.")
                isFormValid = False
            ElseIf Not Integer.TryParse(txtquantity.Text, parsedQuantity) OrElse parsedQuantity <= 0 Then
                epStock.SetError(txtquantity, "Please enter a valid whole number greater than 0.")
                isFormValid = False
            End If

            'Validate Expiry Date (Must make sure it's a future date, not already expired)
            If dtpExpiryDate.Value.Date <= DateTime.Today Then
                epStock.SetError(dtpExpiryDate, "The expiry date must be a future date.")
                isFormValid = False
            End If

            'Validate Date Received (Ensures they aren't logging a future delivery date)
            If dtpDateReceived.Value.Date > DateTime.Today Then
                epStock.SetError(dtpDateReceived, "The date received cannot be a future date.")
                isFormValid = False
            End If

            'THE ABSOLUTE GUARD: Block processing if any field failed validation
            If isFormValid = False Then
                MsgBox("Please, correct the highlighted fields before saving stock details.", MsgBoxStyle.Exclamation, "Validation Error")
                Exit Sub ' Hard stop! This completely prevents the success code below from showing.
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'updating the drug in modmainlog
            '  Dim selectedDrugName As String = cmbdrugnamestock.SelectedItem.ToString()
            Dim drug As Modmainlog.Drug = Modmainlog.findDrug(cmbdrugnamestock.SelectedItem.ToString)

            If drug Is Nothing Then
                MsgBox("Drug Not Found.", MsgBoxStyle.Critical, "Error")
            End If

            'making the cal 
            Dim qtytoadd As Integer = CInt(txtquantity.Text.Trim())

            'this will add the new quantity to the old stock
            drug.CurrentStock += qtytoadd

            drug.IsStocked = True 'this will add it to stock and make it visible for the other cmb 


            Modmainlog.DashboardNeedsRefer = True
            lowstockcheck()
            updateDatagrid()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            MsgBox("Drug successfully Stocked.", MsgBoxStyle.Information, "Stock Updated")

            ' Optional: Clear the form inputs for the next entry
            cmbdrugnamestock.SelectedIndex = -1
            txtquantity.Clear()
            ' dtpExpiryDate.Value = DateTime.Today
            'dtpDateReceived.Value = DateTime.Today
            cmbdrugnamestock.Focus()


        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    'updating the datagridview '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub updateDatagrid()
        dgvStock.Rows.Clear()
        Dim stockdrugs = Modmainlog.DrugList.Where(
            Function(st) st.IsStocked).ToList

        If stockdrugs.Count = 0 Then Return

        For Each stok As Modmainlog.Drug In stockdrugs
            'we will determine the status here
            Dim status As String
            If stok.CurrentStock = 0 Then
                status = "OUT OF STOCK"

            ElseIf stok.CurrentStock <= stok.Reorderlevel Then
                status = "LOW STOCK"
            Else
                status = "Ok"
            End If
            ''we want tochange the color of the status
            'Dim rowname As DataGridViewRow = dgvStock.Rows(dgvStock.Rows.Count - 8)
            'If status = "OUT OF STOCK" Then
            '    rowname.DefaultCellStyle.BackColor = Color.Red
            'ElseIf status = "LOW STOCK" Then
            '    rowname.DefaultCellStyle.BackColor = Color.Yellow
            'End If


            'addig to grid
            Dim rowna As Integer = dgvStock.Rows.Add(
                stok.Drugname,
                stok.Category,
                stok.CurrentStock,
                stok.Reorderlevel,
                status)
        Next


    End Sub

    'checking for the low stock
    Private Sub lowstockcheck()
        Dim lowdrugs As List(Of Modmainlog.Drug) = Modmainlog.GetLowStockDrugs()
        If lowdrugs.Count > 0 Then
            pnlLowstock.Visible = lowdrugs.Count  'we will have the panel first hidden


            'using the alert 
            If lowdrugs.Count > 0 Then
                Dim alertext As String = ""
                For Each drg As Modmainlog.Drug In lowdrugs
                    alertext &= ". " & drg.Drugname & " - " & drg.CurrentStock & "remaining (min" & drg.Reorderlevel & ")" & vbNewLine
                Next
                lbldrugname.Text = alertext.TrimEnd

            End If

        Else
            pnlLowstock.Visible = False

        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tlsrecordstock.Click
        saveStockRecord()
    End Sub

    Private Sub cmbdrugnamestock_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbdrugnamestock.Validating
        If cmbdrugnamestock.SelectedIndex = -1 Then
            epStock.SetError(cmbdrugnamestock, "Please select the drug name")
            cmbdrugnamestock.Focus()

        Else
            epStock.Clear()

        End If
    End Sub

    Private Sub cmbdrugnamestock_DropDown(sender As Object, e As EventArgs) Handles cmbdrugnamestock.DropDown
        'loadcmbboxes()

        cmbdrugnamestock.Items.Clear()

        If Modmainlog.DrugList.Count = 0 Then
            cmbdrugnamestock.Items.Add("----No Drug yet--. Add Drug first ")
        End If

        'this will have the drug stocked still in the combobox
        'For Each stoc As Modmainlog.Drug In Modmainlog.DrugList
        '    cmbdrugnamestock.Items.Add(stoc.Drugname)
        'Next


        'i try to remove the drug from the combobox after it is stocked
        For Each stoc As Modmainlog.Drug In Modmainlog.DrugList.Where(Function(b) Not b.IsStocked)
            cmbdrugnamestock.Items.Add(stoc.Drugname)
        Next

        If cmbdrugnamestock.Items.Count = 0 Then
            cmbdrugnamestock.Items.Add("----No Drug yet--. Add Drug first ")
        End If
    End Sub

    Private Sub dtpDateReceived_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateReceived.ValueChanged
        'this will prevent user from selecting future date
        dtpDateReceived.MaxDate = DateTime.Today
    End Sub

    Private Sub btnrecordstock_Click(sender As Object, e As EventArgs) Handles btnrecordstock.Click
        saveStockRecord()
    End Sub
End Class