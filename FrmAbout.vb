Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Frmmainpage
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Close()
    End Sub

    Private Sub FrmAbout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the MdiParent is Frmmainpage and show the message again
        If TypeOf Me.MdiParent Is Frmmainpage Then
            CType(Me.MdiParent, Frmmainpage).ShowWelcomeMessage()
        End If
    End Sub
End Class