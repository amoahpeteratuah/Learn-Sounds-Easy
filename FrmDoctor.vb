Imports System.Text.RegularExpressions

Public Class Frmdoctor
    Private Sub Timerdoctor_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frmdoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPrescriptions.AutoGenerateColumns = False
        Me.MdiParent = Frmmainpage
        updatingprescriptions()
        loadcmbboxes()



    End Sub

    'we are setting  the comboboxes  '''''''''''''''''''''''''''''''''''''''''
    Public Sub loadcmbboxes()
        cmbdrug.Items.Clear()
        Dim stockdrugs As List(Of Modmainlog.Drug) = Modmainlog.GetStockedDrugs()

        If stockdrugs.Count = 0 Then
            cmbdrug.Items.Add("----No Drug yet--")
            Return
        End If

        For Each medin As Modmainlog.Drug In stockdrugs
            ' this will show the drug name 
            cmbdrug.Items.Add(medin.Drugname)
        Next

    End Sub

    Private Sub txtpatientname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpatientname.Validating
        ' Instantly checks if patient name was left blank
        Try


            If String.IsNullOrWhiteSpace(txtpatientname.Text.Trim()) Then
                epdoctortab.SetError(txtpatientname, "Please, enter the patient's name.")
            Else
                epdoctortab.SetError(txtpatientname, "") 'Clears error icon when filled and then allow
            End If


        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbdrug_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbdrug.Validating
        Try


            'Instantly checks if a drug was selected from the dropdown
            If cmbdrug.SelectedIndex = -1 Then
                epdoctortab.SetError(cmbdrug, "Please, select a drug from the list.")
            Else
                epdoctortab.SetError(cmbdrug, "") 'Clears error icon when selected
            End If


        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtdosageinstruction_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdosageinstruction.Validating
        ' Instantly checks if dosage instructions were left blank
        Try


            If String.IsNullOrWhiteSpace(txtdosageinstruction.Text.Trim()) Then
                epdoctortab.SetError(txtdosageinstruction, "Please, enter the dosage instructions.")
            Else
                epdoctortab.SetError(txtdosageinstruction, "") ' Clears error icon when filled
            End If

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnsendtoPharmacist_Click(sender As Object, e As EventArgs) Handles btnsendtoPharmacist.Click


        sendToPharmacist()


    End Sub

    'creating sub for send to pharmacist
    Private Sub sendToPharmacist()
        Try

            'Clear any old red exclamation indicators immediately
            epdoctortab.Clear()
            Dim isFormValid As Boolean = True

            'Validate Patient Name (Must not be empty)
            If String.IsNullOrWhiteSpace(txtpatientname.Text.Trim()) Then
                epdoctortab.SetError(txtpatientname, "Please, enter the patient's name.")
                isFormValid = False
            End If

            'Validate Drug Selection ComboBox (Must have an item selected)
            If cmbdrug.SelectedIndex = -1 Then
                epdoctortab.SetError(cmbdrug, "Please, select a drug from the list.")
                isFormValid = False
            End If

            'Validate Dosage Instruction (Must not be empty)
            If String.IsNullOrWhiteSpace(txtdosageinstruction.Text.Trim()) Then
                epdoctortab.SetError(txtdosageinstruction, "Please, enter the dosage instructions.")
                isFormValid = False
            End If

            ' Note: Notes(option) is skipped on purpose because it is marked optional.

            ' 5. THE ABSOLUTE GUARD: Block processing if any field failed validation
            If isFormValid = False Then
                MsgBox("Please, fill out all required fields before sending to the pharmacist.", MsgBoxStyle.Exclamation, "Validation Error")
                Exit Sub ' Hard stop Prevents the code below from running.
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'to get the name of the drug only
            Dim drugnam As String = cmbdrug.SelectedItem.ToString()
            'Dim drugnam As String = fullselectedname.Split(New String() {"[Stock:"}, StringSplitOptions.None)(0).Trim()


            'this will now send the infomation to the pharmacist
            Dim newPresciptions As New Modmainlog.Prescription With {
                .DoctorName = Modmainlog.doctorname,
                .PatientName = txtpatientname.Text.Trim,
                .Doctoremail = txtdoctoremail.Text.Trim,
                .DrugName = drugnam,
                .Dosage = txtdosageinstruction.Text.Trim,
                .Notes = txtnotes.Text.Trim,
                .status = "Pending",
                .DateSent = DateTime.Now}


            Modmainlog.PrescriptionList.Add(newPresciptions)

            updatingprescriptions()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Show confirmation popup
            MsgBox("Prescription sent to the pharmacist grid successfully.", MsgBoxStyle.Information, "Prescription Sent")


        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try


    End Sub

    'adding the data to grid
    Private Sub updatingprescriptions()
        dgvPrescriptions.Rows.Clear()
        For Each pres As Modmainlog.Prescription In Modmainlog.PrescriptionList
            dgvPrescriptions.Rows.Add(pres.PatientName,
              pres.DrugName,
              pres.Dosage,
              pres.status,
              pres.DateSent.ToString("dd/MM/yyyy  HH:mm"))


            'using the same idea with the backcolor we can change these as well
            Dim rowname As DataGridViewRow = dgvPrescriptions.Rows(dgvPrescriptions.Rows.Count - 1)
            If pres.status = "Dispensed" Then
                rowname.DefaultCellStyle.ForeColor = Color.Green

            Else
                rowname.DefaultCellStyle.ForeColor = Color.Blue
            End If
        Next
    End Sub

    'clear the form 
    Private Sub clearform()
        'Clear the form inputs for the next entry
        txtpatientname.Clear()
        cmbdrug.SelectedIndex = -1
        txtdosageinstruction.Clear()
        txtnotes.Clear() ' Clears optional notes text box too
        txtpatientname.Focus()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tlsadd.Click
        clearform()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tlssaveSent.Click
        sendToPharmacist()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        canCel()
    End Sub

    'creating a sub for cancel
    Private Sub canCel()
        If MsgBox("Are you sure you want to exit.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Exit") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles tlscancel.Click
        canCel()
    End Sub

    Private Sub cmbdrug_DropDown(sender As Object, e As EventArgs) Handles cmbdrug.DropDown
        loadcmbboxes()    'this will have the cmb refer
    End Sub

    Private Sub txtdoctoremail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdoctoremail.Validating
        Dim emailpattern As String = "^[A-Za-z0-9.%-+]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        If Not Regex.IsMatch(txtdoctoremail.Text, emailpattern) Then
            epdoctortab.SetError(txtdoctoremail, "Email not Valid")
            e.Cancel = True

        Else
            epdoctortab.SetError(txtdoctoremail, "")
            e.Cancel = False

        End If
    End Sub
End Class