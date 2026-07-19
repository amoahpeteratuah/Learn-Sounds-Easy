Imports System.Text.RegularExpressions

Public Class Frmadddrugtab
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Pnldrugtab.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblunitprice.Click

    End Sub

    Private Sub Frmadddrugtab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Frmmainpage
        ReferDrugrid()
        drugsCategory()
        DrugsUnit()
    End Sub

    'having some drugs in the cmb
    Private Sub drugsCategory()
        cmbcategory.Items.Clear()
        cmbcategory.Items.AddRange(New String() {
                                   "Antibiotic", "Diabetic", "Antiviral", "Vitamin", "Cardiovascular"})
    End Sub

    'this is for the unit
    Private Sub DrugsUnit()
        cmbunit.Items.Clear()
        cmbunit.Items.AddRange(New String() {
                               "Tablets", "Capsules", "Sachets", "Bottle", "Syrup", "Injection"})
    End Sub

    Private Sub cmbcategory_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbcategory.Validating
        'checking the combobox 
        Try


            If cmbcategory.SelectedIndex = -1 Then
                epadddrug.SetError(cmbcategory, "Level selection reqiured")
                cmbcategory.Focus()


            Else
                epadddrug.Clear()


            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbunit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbunit.Validating
        Try


            If cmbunit.SelectedIndex = -1 Then
                epadddrug.SetError(cmbunit, "Level selection reqiured")
                cmbunit.Focus()


            Else
                epadddrug.Clear()


            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtdrugname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdrugname.Validating
        Try

            ' Check if the drug name field is left completely empty
            If String.IsNullOrWhiteSpace(txtdrugname.Text.Trim()) Then
                epadddrug.SetError(txtdrugname, "Please enter a valid drug name.")
                txtdrugname.Focus()

            Else
                ' Clear the red icon if they typed a valid name
                epadddrug.SetError(txtdrugname, "")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtreorderlevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreorderlevel.KeyPress
        Try

            ' Allows only whole numbers and backspace control
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

    Private Sub txtunitprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtunitprice.KeyPress
        ' Allows numbers, backspace control, and a single decimal point
        Try


            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
                e.Handled = True
            End If

            'this will block a 0 from start
            Dim txt As TextBox = CType(sender, TextBox)
            If e.KeyChar = "0"c AndAlso txt.SelectionStart = 0 Then
                e.Handled = True
            End If

            ' Block entering a second decimal point if one already exists
            If e.KeyChar = "." AndAlso txtunitprice.Text.Contains(".") Then
                e.Handled = True
            End If


            'we need to also block a third digit after the decimal point
            If Char.IsDigit(e.KeyChar) AndAlso txtunitprice.Text.Contains(".") Then
                Dim thirddecimal As Integer = txtunitprice.Text.IndexOf("."c)
                If (txtunitprice.Text.Length - thirddecimal > 2) AndAlso (txtunitprice.SelectionStart > thirddecimal) Then
                    If txtunitprice.SelectionLength = 0 Then
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnadddrug_Click(sender As Object, e As EventArgs) Handles btnadddrug.Click
        addDrug()
    End Sub

    'a sub for add drug
    Private Sub addDrug()
        Try


            'Clear previous error indicators immediately
            epadddrug.Clear()
            Dim isFormvalid As Boolean = True

            'Check if Drug Name is empty (Accepts any letters, numbers, spaces, or symbols)
            If String.IsNullOrWhiteSpace(txtdrugname.Text.Trim()) Then
                epadddrug.SetError(txtdrugname, "Please, enter the drug name")
                isFormvalid = False
            End If

            ' Validate Category Dropdown Selection
            If cmbcategory.SelectedIndex = -1 Then
                epadddrug.SetError(cmbcategory, "Please select a drug category.")
                isFormvalid = False
            End If

            'Validate Unit Dropdown Selection
            If cmbunit.SelectedIndex = -1 Then
                epadddrug.SetError(cmbunit, "Please select a drug measurement unit.")
                isFormvalid = False
            End If





            'Validate the unit price
            Dim uniprice As Decimal
            If String.IsNullOrWhiteSpace(txtunitprice.Text.Trim()) Then
                epadddrug.SetError(txtunitprice, "Please, enter the unit price")
                isFormvalid = False
            ElseIf Not Decimal.TryParse(txtunitprice.Text, uniprice) OrElse uniprice < 0 Then
                epadddrug.SetError(txtunitprice, "Please, enter a valid numeric price(e.g 20.00, 150.00 ..).")
                isFormvalid = False
            End If

            'Validate reorder level
            Dim validatereorder As Integer
            If String.IsNullOrWhiteSpace(txtreorderlevel.Text.Trim()) Then
                epadddrug.SetError(txtreorderlevel, "Please, enter the reorder level")
                isFormvalid = False
            ElseIf Not Integer.TryParse(txtreorderlevel.Text, validatereorder) OrElse validatereorder < 0 Then
                epadddrug.SetError(txtreorderlevel, "Please, enter a valid whole number(e.g 20, 150,..).")
                isFormvalid = False
            End If

            ' 5. THE ABSOLUTE GUARD: If any errors exist, stop immediately
            If isFormvalid = False Then
                MsgBox("Please, correct the highlighted errors before adding the drugs.", MsgBoxStyle.Exclamation, "Validation Error")
                Exit Sub ' Hard stop! This completely prevents the success message below from showing.
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'checking for a duplicate drug name
            Dim drugexists As Boolean = Modmainlog.DrugList.Any(
                Function(namein) namein.Drugname.ToLower() = txtdrugname.Text.Trim().ToLower)

            If drugexists Then
                MsgBox("A drug with this name already exists.", MsgBoxStyle.Critical, "Duplication")
            End If

            'we are adding the drug to the temporary memory
            Dim newDrug As New Modmainlog.Drug With {   'when using the "with" we use the . to make references. So .DrugName means look for the drugname property and set the current value to it
                .DrugID = Modmainlog.GetNextDrugId,
                .Drugname = txtdrugname.Text.Trim(),
                .Category = cmbcategory.SelectedItem.ToString(),
                .Unit = cmbunit.SelectedItem.ToString(),
                .Reorderlevel = CInt(txtreorderlevel.Text.Trim()),
                .CurrentStock = 0,
                .UnitPrice = CDec(txtunitprice.Text.Trim()),
                .IsStocked = False
            }

            'this will have the drug added to the temp memory
            Modmainlog.DrugList.Add(newDrug)

            Modmainlog.DashboardNeedsRefer = True


            'calling a function
            ReferDrugrid()

            MsgBox("Drug added successfully.Make sure you STOCK it!!", MsgBoxStyle.Information, "Validation Success")


        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                           "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ReferDrugrid()

        'loading the drugs into the datagridview
        dgvInventory.Rows.Clear()
        For Each namein As Modmainlog.Drug In Modmainlog.DrugList
            dgvInventory.Rows.Add(
                namein.DrugID,
                namein.Drugname,
                namein.Category,
                namein.Unit,
                namein.Reorderlevel,
                namein.CurrentStock,
                "GHS" & namein.UnitPrice.ToString("F2"))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Clear the form inputs for the next entry
        txtdrugname.Clear()
        txtunitprice.Clear()
        txtreorderlevel.Clear()
        cmbcategory.SelectedIndex = -1
        cmbunit.SelectedIndex = -1
        txtdrugname.Focus()
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tlsadd.Click
        Try
            addDrug()
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                                       "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tlsclear.Click
        txtdrugname.Clear()
        txtreorderlevel.Clear()
        txtunitprice.Clear()
        cmbcategory.SelectedIndex = -1
        cmbunit.SelectedIndex = -1

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles tlsviewcategory.Click
        'this will display a message of the category
        MsgBox(cmbcategory.SelectedItem, MsgBoxStyle.Information, "View Category")
    End Sub

    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        Try



            'this will ignore it
            If e.RowIndex < 0 Then Return

            'act on the action column only
            If dgvInventory.Columns(e.ColumnIndex).Name <> "colDelete" Then Return

            'get the drug name at index 1
            Dim drugname As String = dgvInventory.Rows(e.RowIndex).Cells(1).Value.ToString

            Dim comfirm As MsgBoxResult = MsgBox("Are you sure you want to delete " & drugname & "?" &
                vbNewLine & "This will remove the drug from all comboboxes", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Comfirm Delete")

            If comfirm <> MsgBoxResult.Yes Then Return

            'finding drug in the drug list in modmainlog
            Dim drugTodelete As Modmainlog.Drug = Modmainlog.FindDrug(drugname)

            If drugTodelete IsNot Nothing Then
                'NOTE: We set the isStock to false first so it disapper,from the doctor and pharmarcy combobox
                drugTodelete.IsStocked = False

                'this will remove it from the druglist completely
                Modmainlog.DrugList.Remove(drugTodelete)
            End If

            ReferDrugrid()

            Modmainlog.DashboardNeedsRefer = True

            MsgBox("" & drugname & " has been deleted successfully", MsgBoxStyle.Information, "Drug Deleted")
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                          "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class