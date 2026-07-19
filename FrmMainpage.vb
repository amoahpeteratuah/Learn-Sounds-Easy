Public Class Frmmainpage

    'creating an array of strings of the informations to be displayed
    Private textlist() As String = {
    "Welcome to the Hospital Pharmacy Inventory Management System.",
    "Ensuring real-time tracking of of Critical medications.",
    "Please, verify stock levels and expiry dates before processing dispensations",
    "Automated low stock alerts are currently active for emergency department carts",
    "Thank you for helping us maintain accuracy and patient safety today"
    }

    'this will keep track of the counts
    Private currentindex As Integer = 0

    Private Sub Timerlivetime_Tick(sender As Object, e As EventArgs) Handles Tmrlivetime.Tick
        stslivetime.Text = Now

    End Sub
    Public Sub ShowWelcomeMessage()
        ' Make the label visible again
        lblmessage.Show()
        ' Optionally reset text to the first item
        currentindex = 0
        lblmessage.Text = textlist(currentindex)
    End Sub

    Private Sub PrescriptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrescriptionsToolStripMenuItem.Click
        doctorlogi()

    End Sub

    'creating a sub for the doctor
    Private Sub doctorlogi()
        Dim doct As String = InputBox("Enter User Name: ").ToUpper
        If doct = Modmainlog.doctorname.Trim Then
            lblmessage.Hide()
            Frmdoctor.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If
    End Sub

    'creating a sub for the manager
    Private Sub managerLog()
        Dim manager As String = InputBox("Enter User Name: ").ToUpper
        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            Frmadddrugtab.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If
    End Sub



    Private Sub DrugTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrugTabToolStripMenuItem.Click
        managerLog()

    End Sub

    Private Sub StockTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockTabToolStripMenuItem.Click
        Dim manager As String = InputBox("Enter User Name: ").ToUpper
        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            FrmStock.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If

    End Sub

    Private Sub ReportsTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsTabToolStripMenuItem.Click
        Dim manager As String = InputBox("Enter User Name: ").ToUpper

        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            FrmReporttab.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If

    End Sub

    Private Sub InboxTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InboxTabToolStripMenuItem.Click

        pharmacistinbox()

    End Sub

    'creating sub for pharmacist
    Private Sub pharmacistinbox()
        Dim pharmacistnameinput As String = InputBox("Enter User Name: ").ToUpper
        If pharmacistnameinput = Modmainlog.pharmarcistname.Trim Then
            lblmessage.Hide()
            Frminbox.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If
    End Sub

    Private Sub Frmmainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'this will set the lable to a default(index 0) text as it loads
        lblmessage.Text = textlist(currentindex)
    End Sub

    Private Sub Timermessage_Tick(sender As Object, e As EventArgs) Handles Tmrmessage.Tick
        'this will be moving the timer plus one
        currentindex += 1

        'this code will loop to 0 if we reah the end of the array
        If currentindex >= textlist.Length Then
            currentindex = 0
        End If

        'this will update the textarea
        lblmessage.Text = textlist(currentindex)

    End Sub

    Private Sub InboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InboxToolStripMenuItem.Click
        pharmacistinbox()
    End Sub

    Private Sub PrescriptionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrescriptionsToolStripMenuItem1.Click
        doctorlogi()
    End Sub

    Private Sub DrugsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrugsToolStripMenuItem.Click
        managerLog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Dim manager As String = InputBox("Enter User Name: ").ToUpper
        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            FrmStock.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim manager As String = InputBox("Enter User Name: ").ToUpper
        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            FrmReporttab.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If

    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim manager As String = InputBox("Enter User Name: ").ToUpper
        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            FrmDashboard.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If
    End Sub

    Private Sub DashboardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem1.Click
        Dim manager As String = InputBox("Enter User Name: ").ToUpper
        If manager = Modmainlog.pharmarcymanagename.Trim Then
            lblmessage.Hide()
            FrmDashboard.Show()
        Else
            MsgBox("Wrong User Name!!!", MsgBoxStyle.Exclamation, "Invalid User Name")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.Show()
        lblmessage.Hide()

    End Sub

    Private Sub SystemAboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemAboutToolStripMenuItem.Click
        FrmAbout.Show()
        lblmessage.Hide()

    End Sub
End Class