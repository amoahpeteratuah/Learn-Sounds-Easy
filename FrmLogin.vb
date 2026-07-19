Public Class Frmlogin
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try


            If txtpassword.UseSystemPasswordChar = True Then
                txtpassword.UseSystemPasswordChar = False

            Else
                txtpassword.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                                       "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try

            'Clear any old red exclamation indicators immediately
            eplogin.Clear()
        Dim isFormValid As Boolean = True

        'Validate UserName (Must not be empty)
        If String.IsNullOrWhiteSpace(txtusername.Text.Trim()) Then
                eplogin.SetError(txtusername, "Please enter your username.")
                isFormValid = False
        End If

            'Validate Password (Must not be empty)
            If String.IsNullOrWhiteSpace(txtpassword.Text.Trim()) Then
                eplogin.SetError(txtpassword, "Please enter your password.")
                isFormValid = False
            End If


            'Block execution if fields are empty
            If isFormValid = False Then
                MsgBox("Please fill in all required fields before logging in.", MsgBoxStyle.Exclamation, "Validation Error")
                Exit Sub ' Hard stop Prevents authentication execution.
            End If

            'the login logic

            If txtpassword.Text.Length < 4 Then
                txtpassword.ForeColor = Color.Red
                MsgBox("Password must be at least 4 digits", MsgBoxStyle.Critical, "Invalid Password Input")
            Else
                txtpassword.ForeColor = Color.Black
                If txtusername.Text.Trim = Modmainlog.generalusername And txtpassword.Text.Trim = Modmainlog.generalpassword Then
                    Frmmainpage.Show()
                    Me.Hide()
                Else
                    MsgBox("Incorrect Credentials", MsgBoxStyle.Critical, "Wrong User Inputs")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                                       "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblforgotpassword_Click(sender As Object, e As EventArgs) Handles lblforgotpassword.Click
        MsgBox("Check your email account", MsgBoxStyle.Information, "Forgot Password")
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to exit.", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Exit") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class