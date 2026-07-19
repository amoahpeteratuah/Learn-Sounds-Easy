Public Class EmployeePagevb
    Private Sub btnuserhome_Click(sender As Object, e As EventArgs) Handles btnuserhome.Click
        showPanel(Panuserhome)


    End Sub

    Private Sub btnuserpayslip_Click(sender As Object, e As EventArgs) Handles btnuserpayslip.Click
        'this will show the payslip page interface
        showPanel(PanPayslip)


    End Sub

    Private Sub EmployeePagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'I want the home page to load as the page is opened
        showPanel(Panuserhome)  'you then have showPanel(name of button) for every button in it's click event code

    End Sub

    'creating a method that will handle
    Private Sub showPanel(panelToShow As Panel)
        'function name showPanel
        'we will fisrt have all the panel visible set to false
        Panuserhome.Visible = False
        PanuserAfford.Visible = False
        PanPayslip.Visible = False

        'now we will take requred from the user
        panelToShow.Visible = True
        panelToShow.BringToFront()


    End Sub

    Private Sub PanPayslip_Paint(sender As Object, e As PaintEventArgs)
        'this is payslip panel

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Labtime.Text = "Welcome to RS Payroll Management System. Your Salary is safe wwith us!❤️" & DateTime.Now.ToString("yyyy ddd MMM-HH:mm:ss")
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnuserAfford_Click(sender As Object, e As EventArgs) Handles btnuserAfford.Click
        showPanel(PanuserAfford)

    End Sub
End Class