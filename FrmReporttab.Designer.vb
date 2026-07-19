<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporttab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporttab))
        Me.pnlreportheader = New System.Windows.Forms.Panel()
        Me.lblreportheader = New System.Windows.Forms.Label()
        Me.pnlreportbuttom = New System.Windows.Forms.FlowLayoutPanel()
        Me.Pnlreport = New System.Windows.Forms.Panel()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.cmbReportType = New System.Windows.Forms.ComboBox()
        Me.lbldateto = New System.Windows.Forms.Label()
        Me.lbldatefrom = New System.Windows.Forms.Label()
        Me.lblreporttype = New System.Windows.Forms.Label()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.ttgenerate = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlsreport = New System.Windows.Forms.ToolStrip()
        Me.tlsgenerate = New System.Windows.Forms.ToolStripButton()
        Me.tlsprint = New System.Windows.Forms.ToolStripButton()
        Me.epgeneratereport = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlreportheader.SuspendLayout()
        Me.Pnlreport.SuspendLayout()
        Me.tlsreport.SuspendLayout()
        CType(Me.epgeneratereport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlreportheader
        '
        Me.pnlreportheader.BackColor = System.Drawing.Color.MediumPurple
        Me.pnlreportheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlreportheader.Controls.Add(Me.lblreportheader)
        Me.pnlreportheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlreportheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlreportheader.Name = "pnlreportheader"
        Me.pnlreportheader.Size = New System.Drawing.Size(1114, 47)
        Me.pnlreportheader.TabIndex = 0
        '
        'lblreportheader
        '
        Me.lblreportheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblreportheader.AutoSize = True
        Me.lblreportheader.BackColor = System.Drawing.Color.Transparent
        Me.lblreportheader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreportheader.ForeColor = System.Drawing.Color.White
        Me.lblreportheader.Location = New System.Drawing.Point(385, 8)
        Me.lblreportheader.Name = "lblreportheader"
        Me.lblreportheader.Size = New System.Drawing.Size(356, 28)
        Me.lblreportheader.TabIndex = 2
        Me.lblreportheader.Text = "PHARMACY MANAGER REPORT TAB"
        '
        'pnlreportbuttom
        '
        Me.pnlreportbuttom.BackColor = System.Drawing.Color.MediumPurple
        Me.pnlreportbuttom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlreportbuttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlreportbuttom.Location = New System.Drawing.Point(0, 539)
        Me.pnlreportbuttom.Name = "pnlreportbuttom"
        Me.pnlreportbuttom.Size = New System.Drawing.Size(1114, 53)
        Me.pnlreportbuttom.TabIndex = 1
        '
        'Pnlreport
        '
        Me.Pnlreport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnlreport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pnlreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnlreport.Controls.Add(Me.dtpDateTo)
        Me.Pnlreport.Controls.Add(Me.dtpDateFrom)
        Me.Pnlreport.Controls.Add(Me.cmbReportType)
        Me.Pnlreport.Controls.Add(Me.lbldateto)
        Me.Pnlreport.Controls.Add(Me.lbldatefrom)
        Me.Pnlreport.Controls.Add(Me.lblreporttype)
        Me.Pnlreport.Location = New System.Drawing.Point(141, 111)
        Me.Pnlreport.Name = "Pnlreport"
        Me.Pnlreport.Size = New System.Drawing.Size(832, 219)
        Me.Pnlreport.TabIndex = 3
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Location = New System.Drawing.Point(239, 132)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(275, 22)
        Me.dtpDateTo.TabIndex = 2
        Me.ttgenerate.SetToolTip(Me.dtpDateTo, "The end date of your report")
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Location = New System.Drawing.Point(239, 81)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(275, 22)
        Me.dtpDateFrom.TabIndex = 1
        Me.ttgenerate.SetToolTip(Me.dtpDateFrom, "Start date of the report you want to generate")
        '
        'cmbReportType
        '
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Location = New System.Drawing.Point(239, 38)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(275, 24)
        Me.cmbReportType.TabIndex = 0
        Me.ttgenerate.SetToolTip(Me.cmbReportType, "Select report type")
        '
        'lbldateto
        '
        Me.lbldateto.AutoSize = True
        Me.lbldateto.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateto.Location = New System.Drawing.Point(94, 126)
        Me.lbldateto.Name = "lbldateto"
        Me.lbldateto.Size = New System.Drawing.Size(81, 28)
        Me.lbldateto.TabIndex = 4
        Me.lbldateto.Text = "Date To"
        '
        'lbldatefrom
        '
        Me.lbldatefrom.AutoSize = True
        Me.lbldatefrom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatefrom.Location = New System.Drawing.Point(94, 81)
        Me.lbldatefrom.Name = "lbldatefrom"
        Me.lbldatefrom.Size = New System.Drawing.Size(107, 28)
        Me.lbldatefrom.TabIndex = 1
        Me.lbldatefrom.Text = "Date From"
        '
        'lblreporttype
        '
        Me.lblreporttype.AutoSize = True
        Me.lblreporttype.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreporttype.Location = New System.Drawing.Point(92, 36)
        Me.lblreporttype.Name = "lblreporttype"
        Me.lblreporttype.Size = New System.Drawing.Size(122, 28)
        Me.lblreporttype.TabIndex = 0
        Me.lblreporttype.Text = "Report Type"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGenerateReport.BackColor = System.Drawing.Color.MediumPurple
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Location = New System.Drawing.Point(418, 452)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(279, 51)
        Me.btnGenerateReport.TabIndex = 3
        Me.btnGenerateReport.Text = "&GENERATE REPORT"
        Me.ttgenerate.SetToolTip(Me.btnGenerateReport, "Click here to generate your report")
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'tlsreport
        '
        Me.tlsreport.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsreport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsgenerate, Me.tlsprint})
        Me.tlsreport.Location = New System.Drawing.Point(0, 47)
        Me.tlsreport.Name = "tlsreport"
        Me.tlsreport.Size = New System.Drawing.Size(1114, 27)
        Me.tlsreport.TabIndex = 4
        Me.tlsreport.Text = "ToolStrip1"
        '
        'tlsgenerate
        '
        Me.tlsgenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsgenerate.Image = CType(resources.GetObject("tlsgenerate.Image"), System.Drawing.Image)
        Me.tlsgenerate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsgenerate.Name = "tlsgenerate"
        Me.tlsgenerate.Size = New System.Drawing.Size(29, 24)
        Me.tlsgenerate.Text = "Generate"
        '
        'tlsprint
        '
        Me.tlsprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsprint.Image = CType(resources.GetObject("tlsprint.Image"), System.Drawing.Image)
        Me.tlsprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsprint.Name = "tlsprint"
        Me.tlsprint.Size = New System.Drawing.Size(29, 24)
        Me.tlsprint.Text = "Print"
        '
        'epgeneratereport
        '
        Me.epgeneratereport.ContainerControl = Me
        '
        'FrmReporttab
        '
        Me.AcceptButton = Me.btnGenerateReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 592)
        Me.Controls.Add(Me.tlsreport)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.Pnlreport)
        Me.Controls.Add(Me.pnlreportbuttom)
        Me.Controls.Add(Me.pnlreportheader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReporttab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReporttab"
        Me.pnlreportheader.ResumeLayout(False)
        Me.pnlreportheader.PerformLayout()
        Me.Pnlreport.ResumeLayout(False)
        Me.Pnlreport.PerformLayout()
        Me.tlsreport.ResumeLayout(False)
        Me.tlsreport.PerformLayout()
        CType(Me.epgeneratereport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlreportheader As Panel
    Friend WithEvents pnlreportbuttom As FlowLayoutPanel
    Friend WithEvents Pnlreport As Panel
    Friend WithEvents lbldateto As Label
    Friend WithEvents lbldatefrom As Label
    Friend WithEvents lblreporttype As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents lblreportheader As Label
    Friend WithEvents ttgenerate As ToolTip
    Friend WithEvents tlsreport As ToolStrip
    Friend WithEvents tlsgenerate As ToolStripButton
    Friend WithEvents tlsprint As ToolStripButton
    Friend WithEvents epgeneratereport As ErrorProvider
End Class
