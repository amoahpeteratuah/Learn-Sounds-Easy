Public Class AdminPage
    Private Sub btndashboard_Click(sender As Object, e As EventArgs)
        'Pandashboard.Show()

    End Sub

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showpanel(Pandashboard)
    End Sub
    'creating a subroutine
    Sub showpanel(panelshow As Panel)
        Pandashboard.Visible = False
        PanPolicies.Visible = False
        PanDocument.Visible = False
        PanAgent.Visible = False

        panelshow.Visible = True
        panelshow.BringToFront()

    End Sub

    Private Sub btnpolicies_Click(sender As Object, e As EventArgs) Handles btnpolicies.Click
        showpanel(PanPolicies)
    End Sub

    Private Sub btndocuments_Click(sender As Object, e As EventArgs) Handles btndocuments.Click
        showpanel(PanDocument)
    End Sub

    Private Sub btnclients_Click(sender As Object, e As EventArgs) Handles btnclients.Click
        showpanel(PanClient)
    End Sub

    Private Sub btnagents_Click(sender As Object, e As EventArgs) Handles btnagents.Click
        showpanel(PanAgent)
    End Sub

    Private Sub btndashboard_Click_1(sender As Object, e As EventArgs) Handles btndashboard.Click
        showpanel(Pandashboard)
    End Sub
End Class