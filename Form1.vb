Public Class frmLogic
    Private Sub txtuserName_TextChanged(sender As Object, e As EventArgs) Handles txtuserName.TextChanged
        'this code will hide the lable text in the text area
        Labusername.Visible = (txtuserName.Text = "")
    End Sub

    Private Sub Labusername_Click(sender As Object, e As EventArgs) Handles Labusername.Click
        'when the lable is clicked the text in there will be focused still
        txtuserName.Focus()

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        'this code will hide the lable text in the text area
        Labpassword.Visible = (txtpassword.Text = "")
    End Sub

    Private Sub Labpassword_Click(sender As Object, e As EventArgs) Handles Labpassword.Click
        'when the lable is clicked the text in there will be focused still
        txtpassword.Focus()
    End Sub

    Private Sub Piceyeview_Click(sender As Object, e As EventArgs) Handles Piceyeview.Click
        'this will handle the eyeview
        If txtpassword.UseSystemPasswordChar = True Then  'when its clicked and the usersystempa is true(on) it will show the text
            txtpassword.UseSystemPasswordChar = False

        Else
            txtpassword.UseSystemPasswordChar = True      'this will hide the password

        End If
    End Sub

    Private Sub Labforget_Click(sender As Object, e As EventArgs) Handles Labforget.Click
        'this will handle the hit for pasword recovery
        MsgBox("Check your email", MsgBoxStyle.Information, "Password Hit")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'declare variables to hold the user inputs
        Dim username As String = txtuserName.Text
        Dim userpassword As Integer = Val(txtpassword.Text)
        'this line of code is checking should the user do not enter any input
        If txtuserName.Text = String.Empty And txtpassword.Text = String.Empty Then
            MsgBox("Please, fill in your cridentials!", MsgBoxStyle.Exclamation, "Invalid Inputs")
        ElseIf userpassword = adminpassword And username = adminusername Then
            AdminPage.Show()
            Me.Hide()

        ElseIf userpassword = employpassword And username = employeusername Then
            EmployeePagevb.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect User cridentials!", MsgBoxStyle.Exclamation, "Wrong User Cridentials")
        End If
    End Sub
End Class
