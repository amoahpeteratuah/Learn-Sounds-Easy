<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmainpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmainpage))
        Me.msmainpage = New System.Windows.Forms.MenuStrip()
        Me.PHARMACISTTABToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboxTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DOCTORSTABToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrescriptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHARMACYMANAGERSTABToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrugTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsmainpage = New System.Windows.Forms.StatusStrip()
        Me.stsmenus = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DashboardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrescriptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stslivetime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tmrlivetime = New System.Windows.Forms.Timer(Me.components)
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.Tmrmessage = New System.Windows.Forms.Timer(Me.components)
        Me.msmainpage.SuspendLayout()
        Me.stsmainpage.SuspendLayout()
        Me.SuspendLayout()
        '
        'msmainpage
        '
        Me.msmainpage.BackColor = System.Drawing.Color.Navy
        Me.msmainpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.msmainpage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msmainpage.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msmainpage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PHARMACISTTABToolStripMenuItem, Me.DOCTORSTABToolStripMenuItem, Me.PHARMACYMANAGERSTABToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.msmainpage.Location = New System.Drawing.Point(0, 0)
        Me.msmainpage.Name = "msmainpage"
        Me.msmainpage.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.msmainpage.Size = New System.Drawing.Size(942, 36)
        Me.msmainpage.TabIndex = 1
        Me.msmainpage.Text = "MenuStrip1"
        '
        'PHARMACISTTABToolStripMenuItem
        '
        Me.PHARMACISTTABToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InboxTabToolStripMenuItem})
        Me.PHARMACISTTABToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHARMACISTTABToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.PHARMACISTTABToolStripMenuItem.Image = CType(resources.GetObject("PHARMACISTTABToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PHARMACISTTABToolStripMenuItem.Name = "PHARMACISTTABToolStripMenuItem"
        Me.PHARMACISTTABToolStripMenuItem.Size = New System.Drawing.Size(218, 32)
        Me.PHARMACISTTABToolStripMenuItem.Text = "PHARMACIST TAB"
        '
        'InboxTabToolStripMenuItem
        '
        Me.InboxTabToolStripMenuItem.Image = CType(resources.GetObject("InboxTabToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InboxTabToolStripMenuItem.Name = "InboxTabToolStripMenuItem"
        Me.InboxTabToolStripMenuItem.Size = New System.Drawing.Size(190, 32)
        Me.InboxTabToolStripMenuItem.Text = "Inbox Tab"
        '
        'DOCTORSTABToolStripMenuItem
        '
        Me.DOCTORSTABToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrescriptionsToolStripMenuItem})
        Me.DOCTORSTABToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOCTORSTABToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.DOCTORSTABToolStripMenuItem.Image = CType(resources.GetObject("DOCTORSTABToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DOCTORSTABToolStripMenuItem.Name = "DOCTORSTABToolStripMenuItem"
        Me.DOCTORSTABToolStripMenuItem.Size = New System.Drawing.Size(188, 32)
        Me.DOCTORSTABToolStripMenuItem.Text = "DOCTOR'S TAB"
        '
        'PrescriptionsToolStripMenuItem
        '
        Me.PrescriptionsToolStripMenuItem.Image = CType(resources.GetObject("PrescriptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrescriptionsToolStripMenuItem.Name = "PrescriptionsToolStripMenuItem"
        Me.PrescriptionsToolStripMenuItem.Size = New System.Drawing.Size(221, 32)
        Me.PrescriptionsToolStripMenuItem.Text = "Prescriptions"
        '
        'PHARMACYMANAGERSTABToolStripMenuItem
        '
        Me.PHARMACYMANAGERSTABToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.DrugTabToolStripMenuItem, Me.StockTabToolStripMenuItem, Me.ReportsTabToolStripMenuItem})
        Me.PHARMACYMANAGERSTABToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHARMACYMANAGERSTABToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.PHARMACYMANAGERSTABToolStripMenuItem.Image = CType(resources.GetObject("PHARMACYMANAGERSTABToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PHARMACYMANAGERSTABToolStripMenuItem.Name = "PHARMACYMANAGERSTABToolStripMenuItem"
        Me.PHARMACYMANAGERSTABToolStripMenuItem.Size = New System.Drawing.Size(325, 32)
        Me.PHARMACYMANAGERSTABToolStripMenuItem.Text = "PHARMACY MANAGER'S TAB"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = CType(resources.GetObject("DashboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'DrugTabToolStripMenuItem
        '
        Me.DrugTabToolStripMenuItem.Image = CType(resources.GetObject("DrugTabToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DrugTabToolStripMenuItem.Name = "DrugTabToolStripMenuItem"
        Me.DrugTabToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.DrugTabToolStripMenuItem.Text = "Drug Tab"
        '
        'StockTabToolStripMenuItem
        '
        Me.StockTabToolStripMenuItem.Image = CType(resources.GetObject("StockTabToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockTabToolStripMenuItem.Name = "StockTabToolStripMenuItem"
        Me.StockTabToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.StockTabToolStripMenuItem.Text = "Stock Tab"
        '
        'ReportsTabToolStripMenuItem
        '
        Me.ReportsTabToolStripMenuItem.Image = CType(resources.GetObject("ReportsTabToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsTabToolStripMenuItem.Name = "ReportsTabToolStripMenuItem"
        Me.ReportsTabToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.ReportsTabToolStripMenuItem.Text = "Reports Tab"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(14, 32)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.Silver
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(94, 32)
        Me.ToolStripMenuItem2.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(156, 32)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(14, 32)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(14, 32)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(14, 32)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(14, 32)
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(14, 32)
        '
        'stsmainpage
        '
        Me.stsmainpage.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsmainpage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsmenus, Me.stslivetime})
        Me.stsmainpage.Location = New System.Drawing.Point(0, 424)
        Me.stsmainpage.Name = "stsmainpage"
        Me.stsmainpage.Size = New System.Drawing.Size(942, 26)
        Me.stsmainpage.TabIndex = 2
        Me.stsmainpage.Text = "StatusStrip1"
        '
        'stsmenus
        '
        Me.stsmenus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stsmenus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem1, Me.StockToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.DrugsToolStripMenuItem, Me.PrescriptionsToolStripMenuItem1, Me.InboxToolStripMenuItem, Me.SystemAboutToolStripMenuItem})
        Me.stsmenus.Image = CType(resources.GetObject("stsmenus.Image"), System.Drawing.Image)
        Me.stsmenus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stsmenus.Name = "stsmenus"
        Me.stsmenus.Size = New System.Drawing.Size(34, 24)
        Me.stsmenus.Text = "Menus"
        '
        'DashboardToolStripMenuItem1
        '
        Me.DashboardToolStripMenuItem1.Name = "DashboardToolStripMenuItem1"
        Me.DashboardToolStripMenuItem1.Size = New System.Drawing.Size(184, 26)
        Me.DashboardToolStripMenuItem1.Text = "Dashboard"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'DrugsToolStripMenuItem
        '
        Me.DrugsToolStripMenuItem.Name = "DrugsToolStripMenuItem"
        Me.DrugsToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.DrugsToolStripMenuItem.Text = "Drugs"
        '
        'PrescriptionsToolStripMenuItem1
        '
        Me.PrescriptionsToolStripMenuItem1.Name = "PrescriptionsToolStripMenuItem1"
        Me.PrescriptionsToolStripMenuItem1.Size = New System.Drawing.Size(184, 26)
        Me.PrescriptionsToolStripMenuItem1.Text = "Prescriptions"
        '
        'InboxToolStripMenuItem
        '
        Me.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem"
        Me.InboxToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.InboxToolStripMenuItem.Text = "Inbox"
        '
        'SystemAboutToolStripMenuItem
        '
        Me.SystemAboutToolStripMenuItem.Name = "SystemAboutToolStripMenuItem"
        Me.SystemAboutToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.SystemAboutToolStripMenuItem.Text = "System About"
        '
        'stslivetime
        '
        Me.stslivetime.Name = "stslivetime"
        Me.stslivetime.Size = New System.Drawing.Size(72, 20)
        Me.stslivetime.Text = "Live Time"
        Me.stslivetime.ToolTipText = " Clock"
        '
        'Tmrlivetime
        '
        Me.Tmrlivetime.Enabled = True
        Me.Tmrlivetime.Interval = 1000
        '
        'lblmessage
        '
        Me.lblmessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblmessage.AutoSize = True
        Me.lblmessage.BackColor = System.Drawing.Color.Transparent
        Me.lblmessage.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.Navy
        Me.lblmessage.Location = New System.Drawing.Point(96, 245)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(120, 32)
        Me.lblmessage.TabIndex = 5
        Me.lblmessage.Text = "Welcome"
        '
        'Tmrmessage
        '
        Me.Tmrmessage.Enabled = True
        Me.Tmrmessage.Interval = 2000
        '
        'Frmmainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(942, 450)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.stsmainpage)
        Me.Controls.Add(Me.msmainpage)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msmainpage
        Me.Name = "Frmmainpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmmainpage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msmainpage.ResumeLayout(False)
        Me.msmainpage.PerformLayout()
        Me.stsmainpage.ResumeLayout(False)
        Me.stsmainpage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msmainpage As MenuStrip
    Friend WithEvents PHARMACISTTABToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InboxTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DOCTORSTABToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrescriptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PHARMACYMANAGERSTABToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrugTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stsmainpage As StatusStrip
    Friend WithEvents Tmrlivetime As Timer
    Friend WithEvents stsmenus As ToolStripDropDownButton
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrugsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrescriptionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stslivetime As ToolStripStatusLabel
    Friend WithEvents lblmessage As Label
    Friend WithEvents Tmrmessage As Timer
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents SystemAboutToolStripMenuItem As ToolStripMenuItem
End Class
