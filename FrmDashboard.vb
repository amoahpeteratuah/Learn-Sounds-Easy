Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrActiveDrug.Start()
        Me.MdiParent = Frmmainpage
        LoadDashboard()
    End Sub
    Public Sub LoadDashboard()
        'we are setting the defaults values of each area

        'for the total drugs
        lbltotaldrugs.Text = Modmainlog.GetTotalDrugTypes.ToString("000")

        'total units
        lbltotalquant.Text = Modmainlog.GetTotalStockUnits.ToString("000")
        'for totalrevenue
        lbltotalrevenue.Text = "00" & Modmainlog.TotalRevenue.ToString("F2")

        'low stock count 
        Dim lowStockCount As Integer = Modmainlog.GetLowStockDrugs().Count
        lbllowstock.Text = lowStockCount.ToString("00")

        'changing the color of the text
        lbllowstock.ForeColor = If(lowStockCount > 0, Color.Red, Color.Black)  'using the ternary if,Color.Red = false and Color.Black = true


        'Today's dispensing 
        Dim todaycount As Integer = Modmainlog.PrescriptionList.Where(
            Function(disp) disp.status = "Dispensed" AndAlso disp.DispensedDate.Date = DateTime.Today).Count
        lbltodaydispensing.Text = todaycount.ToString("000")


        'for the expiry date
        lbldrugexpiried.Text = "No expiry date yet"

        Modmainlog.DashboardNeedsRefer = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Tmrcurrenttime.Tick
        tlscurrenttimeheader.Text = Now

    End Sub

    Private Sub btnadddrugdashboard_Click(sender As Object, e As EventArgs) Handles btnadddrugdashboard.Click
        Dim ref As New Frmadddrugtab() : ref.Show() 'this will keep the dashboard ref

    End Sub

    Private Sub btnstockdashboard_Click(sender As Object, e As EventArgs) Handles btnstockdashboard.Click
        Dim ref As New FrmStock : ref.Show()
    End Sub

    Private Sub btnreportdashboard_Click(sender As Object, e As EventArgs) Handles btnreportdashboard.Click
        Dim ref As New FrmReporttab : ref.Show()

    End Sub

    Private Sub TimeActiveDrug_Tick(sender As Object, e As EventArgs) Handles TmrActiveDrug.Tick
        'this will keep the dashboard refereshing 
        LoadDashboard()
    End Sub

    Private Sub FrmDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TmrActiveDrug.Stop()
    End Sub

End Class