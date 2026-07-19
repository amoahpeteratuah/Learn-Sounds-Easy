Public Class Frmsplash
    Private Sub Timesplash_Tick(sender As Object, e As EventArgs) Handles Timesplash.Tick
        If Pbsplash.Value < 100 Then
            Pbsplash.Value += 2

            If Pbsplash.Value = 20 Then
                lblsplashmessage.Text = "Initializing application core...."

            ElseIf Pbsplash.Value = 50 Then
                lblsplashmessage.Text = "Synchronizing database tables...."

            ElseIf Pbsplash.Value = 80 Then
                lblsplashmessage.Text = "Securing data pathways...."
            End If

        Else
            Timesplash.Stop()
            Frmlogin.Show()
            Me.Hide()


        End If
    End Sub


End Class
