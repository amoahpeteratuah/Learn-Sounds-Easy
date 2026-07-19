<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.tlsdashboard = New System.Windows.Forms.ToolStrip()
        Me.tlsdashboardheader = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlscurrenttimeheader = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tmrcurrenttime = New System.Windows.Forms.Timer(Me.components)
        Me.Pnltotaldrugs = New System.Windows.Forms.Panel()
        Me.lbltotalquant = New System.Windows.Forms.Label()
        Me.lbldrugadded = New System.Windows.Forms.Label()
        Me.lbltotaldrugs = New System.Windows.Forms.Label()
        Me.lbltotalstock = New System.Windows.Forms.Label()
        Me.Pcbtotalstock = New System.Windows.Forms.PictureBox()
        Me.Pnltotalrevenue = New System.Windows.Forms.Panel()
        Me.Lbltotaltrend = New System.Windows.Forms.Label()
        Me.lbltotalrevenue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltotalmoney = New System.Windows.Forms.Label()
        Me.pcbTotalRevenue = New System.Windows.Forms.PictureBox()
        Me.Pnllowstockdashboard = New System.Windows.Forms.Panel()
        Me.lbllowstockalert = New System.Windows.Forms.Label()
        Me.lbllowstock = New System.Windows.Forms.Label()
        Me.lbllowstockdashbo = New System.Windows.Forms.Label()
        Me.pcblowstockdashboard = New System.Windows.Forms.PictureBox()
        Me.Pnltodaydispensing = New System.Windows.Forms.Panel()
        Me.lbltodayactivity = New System.Windows.Forms.Label()
        Me.lbltodaydispensing = New System.Windows.Forms.Label()
        Me.lbltodaydispense = New System.Windows.Forms.Label()
        Me.pcbtodaydispense = New System.Windows.Forms.PictureBox()
        Me.lblkeystatistics = New System.Windows.Forms.Label()
        Me.ttdashboard = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnadddrugdashboard = New System.Windows.Forms.Button()
        Me.btnstockdashboard = New System.Windows.Forms.Button()
        Me.btnreportdashboard = New System.Windows.Forms.Button()
        Me.PnlExpiry = New System.Windows.Forms.Panel()
        Me.lbldrugexpiried = New System.Windows.Forms.Label()
        Me.pcbexpiryalert = New System.Windows.Forms.PictureBox()
        Me.lblexpiryalert = New System.Windows.Forms.Label()
        Me.PnlQuickation = New System.Windows.Forms.Panel()
        Me.lblQuickaction = New System.Windows.Forms.Label()
        Me.TmrActiveDrug = New System.Windows.Forms.Timer(Me.components)
        Me.tlsdashboard.SuspendLayout()
        Me.Pnltotaldrugs.SuspendLayout()
        CType(Me.Pcbtotalstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnltotalrevenue.SuspendLayout()
        CType(Me.pcbTotalRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnllowstockdashboard.SuspendLayout()
        CType(Me.pcblowstockdashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnltodaydispensing.SuspendLayout()
        CType(Me.pcbtodaydispense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlExpiry.SuspendLayout()
        CType(Me.pcbexpiryalert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlQuickation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlsdashboard
        '
        Me.tlsdashboard.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsdashboard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsdashboardheader, Me.ToolStripSeparator1, Me.tlscurrenttimeheader, Me.ToolStripSeparator2})
        Me.tlsdashboard.Location = New System.Drawing.Point(0, 0)
        Me.tlsdashboard.Name = "tlsdashboard"
        Me.tlsdashboard.Size = New System.Drawing.Size(1090, 25)
        Me.tlsdashboard.TabIndex = 0
        Me.tlsdashboard.Text = "ToolStrip1"
        '
        'tlsdashboardheader
        '
        Me.tlsdashboardheader.Name = "tlsdashboardheader"
        Me.tlsdashboardheader.Size = New System.Drawing.Size(82, 22)
        Me.tlsdashboardheader.Text = "Dashboard"
        Me.tlsdashboardheader.ToolTipText = "Dashboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlscurrenttimeheader
        '
        Me.tlscurrenttimeheader.Name = "tlscurrenttimeheader"
        Me.tlscurrenttimeheader.Size = New System.Drawing.Size(94, 22)
        Me.tlscurrenttimeheader.Text = "Current Time"
        Me.tlscurrenttimeheader.ToolTipText = "Current Time"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tmrcurrenttime
        '
        Me.Tmrcurrenttime.Enabled = True
        Me.Tmrcurrenttime.Interval = 1000
        '
        'Pnltotaldrugs
        '
        Me.Pnltotaldrugs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnltotaldrugs.BackColor = System.Drawing.Color.White
        Me.Pnltotaldrugs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnltotaldrugs.Controls.Add(Me.lbltotalquant)
        Me.Pnltotaldrugs.Controls.Add(Me.lbldrugadded)
        Me.Pnltotaldrugs.Controls.Add(Me.lbltotaldrugs)
        Me.Pnltotaldrugs.Controls.Add(Me.lbltotalstock)
        Me.Pnltotaldrugs.Controls.Add(Me.Pcbtotalstock)
        Me.Pnltotaldrugs.Location = New System.Drawing.Point(30, 88)
        Me.Pnltotaldrugs.Name = "Pnltotaldrugs"
        Me.Pnltotaldrugs.Size = New System.Drawing.Size(291, 186)
        Me.Pnltotaldrugs.TabIndex = 1
        '
        'lbltotalquant
        '
        Me.lbltotalquant.AutoSize = True
        Me.lbltotalquant.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalquant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbltotalquant.Location = New System.Drawing.Point(97, 75)
        Me.lbltotalquant.Name = "lbltotalquant"
        Me.lbltotalquant.Size = New System.Drawing.Size(57, 32)
        Me.lbltotalquant.TabIndex = 12
        Me.lbltotalquant.Text = "000"
        '
        'lbldrugadded
        '
        Me.lbldrugadded.AutoSize = True
        Me.lbldrugadded.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrugadded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbldrugadded.Location = New System.Drawing.Point(14, 117)
        Me.lbldrugadded.Name = "lbldrugadded"
        Me.lbldrugadded.Size = New System.Drawing.Size(244, 28)
        Me.lbldrugadded.TabIndex = 3
        Me.lbldrugadded.Text = "Number of Drugs Added" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbldrugadded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotaldrugs
        '
        Me.lbltotaldrugs.AutoSize = True
        Me.lbltotaldrugs.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaldrugs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbltotaldrugs.Location = New System.Drawing.Point(99, 147)
        Me.lbltotaldrugs.Name = "lbltotaldrugs"
        Me.lbltotaldrugs.Size = New System.Drawing.Size(57, 32)
        Me.lbltotaldrugs.TabIndex = 2
        Me.lbltotaldrugs.Text = "000"
        Me.lbltotaldrugs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttdashboard.SetToolTip(Me.lbltotaldrugs, "Total Drugs in stock")
        '
        'lbltotalstock
        '
        Me.lbltotalstock.AutoSize = True
        Me.lbltotalstock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbltotalstock.Location = New System.Drawing.Point(69, 39)
        Me.lbltotalstock.Name = "lbltotalstock"
        Me.lbltotalstock.Size = New System.Drawing.Size(117, 28)
        Me.lbltotalstock.TabIndex = 1
        Me.lbltotalstock.Text = "Total Stock"
        Me.lbltotalstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pcbtotalstock
        '
        Me.Pcbtotalstock.Image = CType(resources.GetObject("Pcbtotalstock.Image"), System.Drawing.Image)
        Me.Pcbtotalstock.Location = New System.Drawing.Point(88, 3)
        Me.Pcbtotalstock.Name = "Pcbtotalstock"
        Me.Pcbtotalstock.Size = New System.Drawing.Size(77, 33)
        Me.Pcbtotalstock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pcbtotalstock.TabIndex = 0
        Me.Pcbtotalstock.TabStop = False
        '
        'Pnltotalrevenue
        '
        Me.Pnltotalrevenue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnltotalrevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Pnltotalrevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnltotalrevenue.Controls.Add(Me.Lbltotaltrend)
        Me.Pnltotalrevenue.Controls.Add(Me.lbltotalrevenue)
        Me.Pnltotalrevenue.Controls.Add(Me.Label6)
        Me.Pnltotalrevenue.Controls.Add(Me.lbltotalmoney)
        Me.Pnltotalrevenue.Controls.Add(Me.pcbTotalRevenue)
        Me.Pnltotalrevenue.Location = New System.Drawing.Point(378, 88)
        Me.Pnltotalrevenue.Name = "Pnltotalrevenue"
        Me.Pnltotalrevenue.Size = New System.Drawing.Size(291, 186)
        Me.Pnltotalrevenue.TabIndex = 2
        '
        'Lbltotaltrend
        '
        Me.Lbltotaltrend.AutoSize = True
        Me.Lbltotaltrend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotaltrend.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Lbltotaltrend.Location = New System.Drawing.Point(79, 147)
        Me.Lbltotaltrend.Name = "Lbltotaltrend"
        Me.Lbltotaltrend.Size = New System.Drawing.Size(130, 28)
        Me.Lbltotaltrend.TabIndex = 7
        Me.Lbltotaltrend.Text = "Trend more.."
        Me.Lbltotaltrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotalrevenue
        '
        Me.lbltotalrevenue.AutoSize = True
        Me.lbltotalrevenue.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalrevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lbltotalrevenue.Location = New System.Drawing.Point(115, 98)
        Me.lbltotalrevenue.Name = "lbltotalrevenue"
        Me.lbltotalrevenue.Size = New System.Drawing.Size(57, 32)
        Me.lbltotalrevenue.TabIndex = 6
        Me.lbltotalrevenue.Text = "000"
        Me.lbltotalrevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttdashboard.SetToolTip(Me.lbltotalrevenue, "Total Revenue")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(60, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "GHS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotalmoney
        '
        Me.lbltotalmoney.AutoSize = True
        Me.lbltotalmoney.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalmoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lbltotalmoney.Location = New System.Drawing.Point(91, 27)
        Me.lbltotalmoney.Name = "lbltotalmoney"
        Me.lbltotalmoney.Size = New System.Drawing.Size(146, 28)
        Me.lbltotalmoney.TabIndex = 4
        Me.lbltotalmoney.Text = "Total Revenue"
        Me.lbltotalmoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbTotalRevenue
        '
        Me.pcbTotalRevenue.Image = CType(resources.GetObject("pcbTotalRevenue.Image"), System.Drawing.Image)
        Me.pcbTotalRevenue.Location = New System.Drawing.Point(3, 17)
        Me.pcbTotalRevenue.Name = "pcbTotalRevenue"
        Me.pcbTotalRevenue.Size = New System.Drawing.Size(100, 50)
        Me.pcbTotalRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTotalRevenue.TabIndex = 1
        Me.pcbTotalRevenue.TabStop = False
        '
        'Pnllowstockdashboard
        '
        Me.Pnllowstockdashboard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnllowstockdashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Pnllowstockdashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnllowstockdashboard.Controls.Add(Me.lbllowstockalert)
        Me.Pnllowstockdashboard.Controls.Add(Me.lbllowstock)
        Me.Pnllowstockdashboard.Controls.Add(Me.lbllowstockdashbo)
        Me.Pnllowstockdashboard.Controls.Add(Me.pcblowstockdashboard)
        Me.Pnllowstockdashboard.Location = New System.Drawing.Point(30, 304)
        Me.Pnllowstockdashboard.Name = "Pnllowstockdashboard"
        Me.Pnllowstockdashboard.Size = New System.Drawing.Size(291, 186)
        Me.Pnllowstockdashboard.TabIndex = 2
        '
        'lbllowstockalert
        '
        Me.lbllowstockalert.AutoSize = True
        Me.lbllowstockalert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllowstockalert.ForeColor = System.Drawing.Color.Gray
        Me.lbllowstockalert.Location = New System.Drawing.Point(99, 146)
        Me.lbllowstockalert.Name = "lbllowstockalert"
        Me.lbllowstockalert.Size = New System.Drawing.Size(66, 28)
        Me.lbllowstockalert.TabIndex = 10
        Me.lbllowstockalert.Text = "Alert "
        Me.lbllowstockalert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbllowstock
        '
        Me.lbllowstock.AutoSize = True
        Me.lbllowstock.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllowstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lbllowstock.Location = New System.Drawing.Point(111, 91)
        Me.lbllowstock.Name = "lbllowstock"
        Me.lbllowstock.Size = New System.Drawing.Size(43, 32)
        Me.lbllowstock.TabIndex = 9
        Me.lbllowstock.Text = "00"
        Me.lbllowstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttdashboard.SetToolTip(Me.lbllowstock, "Low level")
        '
        'lbllowstockdashbo
        '
        Me.lbllowstockdashbo.AutoSize = True
        Me.lbllowstockdashbo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllowstockdashbo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lbllowstockdashbo.Location = New System.Drawing.Point(99, 26)
        Me.lbllowstockdashbo.Name = "lbllowstockdashbo"
        Me.lbllowstockdashbo.Size = New System.Drawing.Size(108, 28)
        Me.lbllowstockdashbo.TabIndex = 8
        Me.lbllowstockdashbo.Text = "Low Stock"
        Me.lbllowstockdashbo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcblowstockdashboard
        '
        Me.pcblowstockdashboard.Image = CType(resources.GetObject("pcblowstockdashboard.Image"), System.Drawing.Image)
        Me.pcblowstockdashboard.Location = New System.Drawing.Point(19, 15)
        Me.pcblowstockdashboard.Name = "pcblowstockdashboard"
        Me.pcblowstockdashboard.Size = New System.Drawing.Size(100, 50)
        Me.pcblowstockdashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcblowstockdashboard.TabIndex = 2
        Me.pcblowstockdashboard.TabStop = False
        '
        'Pnltodaydispensing
        '
        Me.Pnltodaydispensing.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnltodaydispensing.BackColor = System.Drawing.Color.White
        Me.Pnltodaydispensing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnltodaydispensing.Controls.Add(Me.lbltodayactivity)
        Me.Pnltodaydispensing.Controls.Add(Me.lbltodaydispensing)
        Me.Pnltodaydispensing.Controls.Add(Me.lbltodaydispense)
        Me.Pnltodaydispensing.Controls.Add(Me.pcbtodaydispense)
        Me.Pnltodaydispensing.Location = New System.Drawing.Point(378, 304)
        Me.Pnltodaydispensing.Name = "Pnltodaydispensing"
        Me.Pnltodaydispensing.Size = New System.Drawing.Size(291, 186)
        Me.Pnltodaydispensing.TabIndex = 2
        '
        'lbltodayactivity
        '
        Me.lbltodayactivity.AutoSize = True
        Me.lbltodayactivity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodayactivity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbltodayactivity.Location = New System.Drawing.Point(39, 146)
        Me.lbltodayactivity.Name = "lbltodayactivity"
        Me.lbltodayactivity.Size = New System.Drawing.Size(210, 28)
        Me.lbltodayactivity.TabIndex = 4
        Me.lbltodayactivity.Text = "Activity Transactions"
        Me.lbltodayactivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltodaydispensing
        '
        Me.lbltodaydispensing.AutoSize = True
        Me.lbltodaydispensing.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodaydispensing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbltodaydispensing.Location = New System.Drawing.Point(115, 91)
        Me.lbltodaydispensing.Name = "lbltodaydispensing"
        Me.lbltodaydispensing.Size = New System.Drawing.Size(57, 32)
        Me.lbltodaydispensing.TabIndex = 4
        Me.lbltodaydispensing.Text = "000"
        Me.lbltodaydispensing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttdashboard.SetToolTip(Me.lbltodaydispensing, "Number of dispensing for the day")
        '
        'lbltodaydispense
        '
        Me.lbltodaydispense.AutoSize = True
        Me.lbltodaydispense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodaydispense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbltodaydispense.Location = New System.Drawing.Point(70, 26)
        Me.lbltodaydispense.Name = "lbltodaydispense"
        Me.lbltodaydispense.Size = New System.Drawing.Size(192, 28)
        Me.lbltodaydispense.TabIndex = 5
        Me.lbltodaydispense.Text = "Today's Dispensing"
        Me.lbltodaydispense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbtodaydispense
        '
        Me.pcbtodaydispense.Image = CType(resources.GetObject("pcbtodaydispense.Image"), System.Drawing.Image)
        Me.pcbtodaydispense.Location = New System.Drawing.Point(12, 15)
        Me.pcbtodaydispense.Name = "pcbtodaydispense"
        Me.pcbtodaydispense.Size = New System.Drawing.Size(61, 50)
        Me.pcbtodaydispense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbtodaydispense.TabIndex = 3
        Me.pcbtodaydispense.TabStop = False
        '
        'lblkeystatistics
        '
        Me.lblkeystatistics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblkeystatistics.AutoSize = True
        Me.lblkeystatistics.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkeystatistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblkeystatistics.Location = New System.Drawing.Point(381, 25)
        Me.lblkeystatistics.Name = "lblkeystatistics"
        Me.lblkeystatistics.Size = New System.Drawing.Size(235, 32)
        Me.lblkeystatistics.TabIndex = 3
        Me.lblkeystatistics.Text = "Key Statistics Cards"
        '
        'btnadddrugdashboard
        '
        Me.btnadddrugdashboard.BackColor = System.Drawing.Color.Blue
        Me.btnadddrugdashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadddrugdashboard.FlatAppearance.BorderSize = 0
        Me.btnadddrugdashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadddrugdashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnadddrugdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadddrugdashboard.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadddrugdashboard.ForeColor = System.Drawing.Color.White
        Me.btnadddrugdashboard.Location = New System.Drawing.Point(71, 57)
        Me.btnadddrugdashboard.Name = "btnadddrugdashboard"
        Me.btnadddrugdashboard.Size = New System.Drawing.Size(197, 35)
        Me.btnadddrugdashboard.TabIndex = 0
        Me.btnadddrugdashboard.Text = "&Add Drug"
        Me.ttdashboard.SetToolTip(Me.btnadddrugdashboard, "Click here to open the Add drug Tab")
        Me.btnadddrugdashboard.UseVisualStyleBackColor = False
        '
        'btnstockdashboard
        '
        Me.btnstockdashboard.BackColor = System.Drawing.Color.Blue
        Me.btnstockdashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstockdashboard.FlatAppearance.BorderSize = 0
        Me.btnstockdashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnstockdashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.btnstockdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstockdashboard.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstockdashboard.ForeColor = System.Drawing.Color.White
        Me.btnstockdashboard.Location = New System.Drawing.Point(71, 98)
        Me.btnstockdashboard.Name = "btnstockdashboard"
        Me.btnstockdashboard.Size = New System.Drawing.Size(197, 35)
        Me.btnstockdashboard.TabIndex = 1
        Me.btnstockdashboard.Text = "&Stock"
        Me.ttdashboard.SetToolTip(Me.btnstockdashboard, "Click here to open the Stock tab")
        Me.btnstockdashboard.UseVisualStyleBackColor = False
        '
        'btnreportdashboard
        '
        Me.btnreportdashboard.BackColor = System.Drawing.Color.Blue
        Me.btnreportdashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreportdashboard.FlatAppearance.BorderSize = 0
        Me.btnreportdashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreportdashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreportdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportdashboard.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportdashboard.ForeColor = System.Drawing.Color.White
        Me.btnreportdashboard.Location = New System.Drawing.Point(71, 139)
        Me.btnreportdashboard.Name = "btnreportdashboard"
        Me.btnreportdashboard.Size = New System.Drawing.Size(197, 35)
        Me.btnreportdashboard.TabIndex = 2
        Me.btnreportdashboard.Text = "&Report"
        Me.ttdashboard.SetToolTip(Me.btnreportdashboard, "Click here to open the Generate Report Tab")
        Me.btnreportdashboard.UseVisualStyleBackColor = False
        '
        'PnlExpiry
        '
        Me.PnlExpiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlExpiry.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PnlExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlExpiry.Controls.Add(Me.lbldrugexpiried)
        Me.PnlExpiry.Controls.Add(Me.pcbexpiryalert)
        Me.PnlExpiry.Controls.Add(Me.lblexpiryalert)
        Me.PnlExpiry.Location = New System.Drawing.Point(719, 88)
        Me.PnlExpiry.Name = "PnlExpiry"
        Me.PnlExpiry.Size = New System.Drawing.Size(343, 186)
        Me.PnlExpiry.TabIndex = 10
        '
        'lbldrugexpiried
        '
        Me.lbldrugexpiried.AutoSize = True
        Me.lbldrugexpiried.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lbldrugexpiried.Location = New System.Drawing.Point(22, 75)
        Me.lbldrugexpiried.Name = "lbldrugexpiried"
        Me.lbldrugexpiried.Size = New System.Drawing.Size(72, 17)
        Me.lbldrugexpiried.TabIndex = 6
        Me.lbldrugexpiried.Text = "Amoxicillin"
        '
        'pcbexpiryalert
        '
        Me.pcbexpiryalert.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pcbexpiryalert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbexpiryalert.Image = CType(resources.GetObject("pcbexpiryalert.Image"), System.Drawing.Image)
        Me.pcbexpiryalert.Location = New System.Drawing.Point(3, 3)
        Me.pcbexpiryalert.Name = "pcbexpiryalert"
        Me.pcbexpiryalert.Size = New System.Drawing.Size(38, 38)
        Me.pcbexpiryalert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbexpiryalert.TabIndex = 1
        Me.pcbexpiryalert.TabStop = False
        '
        'lblexpiryalert
        '
        Me.lblexpiryalert.AutoSize = True
        Me.lblexpiryalert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpiryalert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblexpiryalert.Location = New System.Drawing.Point(47, 13)
        Me.lblexpiryalert.Name = "lblexpiryalert"
        Me.lblexpiryalert.Size = New System.Drawing.Size(280, 28)
        Me.lblexpiryalert.TabIndex = 0
        Me.lblexpiryalert.Text = "EXPIRY ALERT(next 60 days)"
        '
        'PnlQuickation
        '
        Me.PnlQuickation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlQuickation.BackColor = System.Drawing.Color.White
        Me.PnlQuickation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlQuickation.Controls.Add(Me.btnreportdashboard)
        Me.PnlQuickation.Controls.Add(Me.btnstockdashboard)
        Me.PnlQuickation.Controls.Add(Me.btnadddrugdashboard)
        Me.PnlQuickation.Controls.Add(Me.lblQuickaction)
        Me.PnlQuickation.Location = New System.Drawing.Point(719, 304)
        Me.PnlQuickation.Name = "PnlQuickation"
        Me.PnlQuickation.Size = New System.Drawing.Size(343, 184)
        Me.PnlQuickation.TabIndex = 11
        '
        'lblQuickaction
        '
        Me.lblQuickaction.AutoSize = True
        Me.lblQuickaction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickaction.ForeColor = System.Drawing.Color.Black
        Me.lblQuickaction.Location = New System.Drawing.Point(104, 14)
        Me.lblQuickaction.Name = "lblQuickaction"
        Me.lblQuickaction.Size = New System.Drawing.Size(131, 28)
        Me.lblQuickaction.TabIndex = 8
        Me.lblQuickaction.Text = "Quick action"
        Me.lblQuickaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrActiveDrug
        '
        Me.TmrActiveDrug.Enabled = True
        Me.TmrActiveDrug.Interval = 1000
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1090, 500)
        Me.Controls.Add(Me.PnlQuickation)
        Me.Controls.Add(Me.PnlExpiry)
        Me.Controls.Add(Me.lblkeystatistics)
        Me.Controls.Add(Me.Pnltodaydispensing)
        Me.Controls.Add(Me.Pnllowstockdashboard)
        Me.Controls.Add(Me.Pnltotalrevenue)
        Me.Controls.Add(Me.Pnltotaldrugs)
        Me.Controls.Add(Me.tlsdashboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDashboard"
        Me.tlsdashboard.ResumeLayout(False)
        Me.tlsdashboard.PerformLayout()
        Me.Pnltotaldrugs.ResumeLayout(False)
        Me.Pnltotaldrugs.PerformLayout()
        CType(Me.Pcbtotalstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnltotalrevenue.ResumeLayout(False)
        Me.Pnltotalrevenue.PerformLayout()
        CType(Me.pcbTotalRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnllowstockdashboard.ResumeLayout(False)
        Me.Pnllowstockdashboard.PerformLayout()
        CType(Me.pcblowstockdashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnltodaydispensing.ResumeLayout(False)
        Me.Pnltodaydispensing.PerformLayout()
        CType(Me.pcbtodaydispense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlExpiry.ResumeLayout(False)
        Me.PnlExpiry.PerformLayout()
        CType(Me.pcbexpiryalert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlQuickation.ResumeLayout(False)
        Me.PnlQuickation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlsdashboard As ToolStrip
    Friend WithEvents tlsdashboardheader As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tlscurrenttimeheader As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Tmrcurrenttime As Timer
    Friend WithEvents Pnltotaldrugs As Panel
    Friend WithEvents Pnltotalrevenue As Panel
    Friend WithEvents Pnllowstockdashboard As Panel
    Friend WithEvents Pnltodaydispensing As Panel
    Friend WithEvents lblkeystatistics As Label
    Friend WithEvents lbldrugadded As Label
    Friend WithEvents lbltotaldrugs As Label
    Friend WithEvents lbltotalstock As Label
    Friend WithEvents Pcbtotalstock As PictureBox
    Friend WithEvents pcbTotalRevenue As PictureBox
    Friend WithEvents pcblowstockdashboard As PictureBox
    Friend WithEvents lbltodaydispensing As Label
    Friend WithEvents lbltodaydispense As Label
    Friend WithEvents pcbtodaydispense As PictureBox
    Friend WithEvents lbltodayactivity As Label
    Friend WithEvents Lbltotaltrend As Label
    Friend WithEvents lbltotalrevenue As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbltotalmoney As Label
    Friend WithEvents lbllowstockalert As Label
    Friend WithEvents lbllowstock As Label
    Friend WithEvents lbllowstockdashbo As Label
    Friend WithEvents ttdashboard As ToolTip
    Friend WithEvents PnlExpiry As Panel
    Friend WithEvents lbldrugexpiried As Label
    Friend WithEvents pcbexpiryalert As PictureBox
    Friend WithEvents lblexpiryalert As Label
    Friend WithEvents PnlQuickation As Panel
    Friend WithEvents btnadddrugdashboard As Button
    Friend WithEvents lblQuickaction As Label
    Friend WithEvents btnreportdashboard As Button
    Friend WithEvents btnstockdashboard As Button
    Friend WithEvents TmrActiveDrug As Timer
    Friend WithEvents lbltotalquant As Label
End Class
