<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStock))
        Me.pnlstockheader = New System.Windows.Forms.Panel()
        Me.lblpharmacystocktab = New System.Windows.Forms.Label()
        Me.pnlstockbuttom = New System.Windows.Forms.Panel()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.ColumnDrugID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnstock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnReorder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUnitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnrecordstock = New System.Windows.Forms.Button()
        Me.Panestock = New System.Windows.Forms.Panel()
        Me.cmbdrugnamestock = New System.Windows.Forms.ComboBox()
        Me.dtpDateReceived = New System.Windows.Forms.DateTimePicker()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.lblquantityreceived = New System.Windows.Forms.Label()
        Me.lblexpirydate = New System.Windows.Forms.Label()
        Me.lbldatereceived = New System.Windows.Forms.Label()
        Me.lbldrug = New System.Windows.Forms.Label()
        Me.pnlLowstock = New System.Windows.Forms.Panel()
        Me.lbldrugname = New System.Windows.Forms.Label()
        Me.piclowstock = New System.Windows.Forms.PictureBox()
        Me.lbllowstockheader = New System.Windows.Forms.Label()
        Me.ttStock = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlsStock = New System.Windows.Forms.ToolStrip()
        Me.tlsrecordstock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsviewcategory = New System.Windows.Forms.ToolStripButton()
        Me.epStock = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlstockheader.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panestock.SuspendLayout()
        Me.pnlLowstock.SuspendLayout()
        CType(Me.piclowstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsStock.SuspendLayout()
        CType(Me.epStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlstockheader
        '
        Me.pnlstockheader.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlstockheader.Controls.Add(Me.lblpharmacystocktab)
        Me.pnlstockheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlstockheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlstockheader.Name = "pnlstockheader"
        Me.pnlstockheader.Size = New System.Drawing.Size(1217, 37)
        Me.pnlstockheader.TabIndex = 0
        '
        'lblpharmacystocktab
        '
        Me.lblpharmacystocktab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblpharmacystocktab.AutoSize = True
        Me.lblpharmacystocktab.BackColor = System.Drawing.Color.Transparent
        Me.lblpharmacystocktab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpharmacystocktab.ForeColor = System.Drawing.Color.White
        Me.lblpharmacystocktab.Location = New System.Drawing.Point(451, 9)
        Me.lblpharmacystocktab.Name = "lblpharmacystocktab"
        Me.lblpharmacystocktab.Size = New System.Drawing.Size(342, 28)
        Me.lblpharmacystocktab.TabIndex = 1
        Me.lblpharmacystocktab.Text = "PHARMACY MANAGER STOCK TAB"
        '
        'pnlstockbuttom
        '
        Me.pnlstockbuttom.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlstockbuttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlstockbuttom.Location = New System.Drawing.Point(0, 827)
        Me.pnlstockbuttom.Name = "pnlstockbuttom"
        Me.pnlstockbuttom.Size = New System.Drawing.Size(1217, 34)
        Me.pnlstockbuttom.TabIndex = 1
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnDrugID, Me.Columcategory, Me.Columnstock, Me.ColumnReorder, Me.ColumnUnitprice})
        Me.dgvStock.EnableHeadersVisualStyles = False
        Me.dgvStock.Location = New System.Drawing.Point(53, 455)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.RowHeadersWidth = 51
        Me.dgvStock.RowTemplate.Height = 24
        Me.dgvStock.Size = New System.Drawing.Size(1097, 150)
        Me.dgvStock.TabIndex = 7
        '
        'ColumnDrugID
        '
        Me.ColumnDrugID.HeaderText = "Drug Name"
        Me.ColumnDrugID.MinimumWidth = 6
        Me.ColumnDrugID.Name = "ColumnDrugID"
        Me.ColumnDrugID.ReadOnly = True
        '
        'Columcategory
        '
        Me.Columcategory.HeaderText = "Category"
        Me.Columcategory.MinimumWidth = 6
        Me.Columcategory.Name = "Columcategory"
        Me.Columcategory.ReadOnly = True
        '
        'Columnstock
        '
        Me.Columnstock.HeaderText = " Current Stock"
        Me.Columnstock.MinimumWidth = 6
        Me.Columnstock.Name = "Columnstock"
        Me.Columnstock.ReadOnly = True
        '
        'ColumnReorder
        '
        Me.ColumnReorder.HeaderText = "Reorder Level"
        Me.ColumnReorder.MinimumWidth = 6
        Me.ColumnReorder.Name = "ColumnReorder"
        Me.ColumnReorder.ReadOnly = True
        '
        'ColumnUnitprice
        '
        Me.ColumnUnitprice.HeaderText = "Status"
        Me.ColumnUnitprice.MinimumWidth = 6
        Me.ColumnUnitprice.Name = "ColumnUnitprice"
        Me.ColumnUnitprice.ReadOnly = True
        '
        'btnrecordstock
        '
        Me.btnrecordstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnrecordstock.BackColor = System.Drawing.Color.ForestGreen
        Me.btnrecordstock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrecordstock.FlatAppearance.BorderSize = 0
        Me.btnrecordstock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnrecordstock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.btnrecordstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecordstock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecordstock.ForeColor = System.Drawing.Color.White
        Me.btnrecordstock.Location = New System.Drawing.Point(456, 388)
        Me.btnrecordstock.Name = "btnrecordstock"
        Me.btnrecordstock.Size = New System.Drawing.Size(191, 44)
        Me.btnrecordstock.TabIndex = 4
        Me.btnrecordstock.Text = "&RECORD STOCK IN"
        Me.ttStock.SetToolTip(Me.btnrecordstock, "Click to record drug into stock")
        Me.btnrecordstock.UseVisualStyleBackColor = False
        '
        'Panestock
        '
        Me.Panestock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panestock.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panestock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panestock.Controls.Add(Me.cmbdrugnamestock)
        Me.Panestock.Controls.Add(Me.dtpDateReceived)
        Me.Panestock.Controls.Add(Me.dtpExpiryDate)
        Me.Panestock.Controls.Add(Me.txtquantity)
        Me.Panestock.Controls.Add(Me.lblquantityreceived)
        Me.Panestock.Controls.Add(Me.lblexpirydate)
        Me.Panestock.Controls.Add(Me.lbldatereceived)
        Me.Panestock.Controls.Add(Me.lbldrug)
        Me.Panestock.Location = New System.Drawing.Point(121, 102)
        Me.Panestock.Name = "Panestock"
        Me.Panestock.Size = New System.Drawing.Size(982, 274)
        Me.Panestock.TabIndex = 5
        '
        'cmbdrugnamestock
        '
        Me.cmbdrugnamestock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdrugnamestock.FormattingEnabled = True
        Me.cmbdrugnamestock.Location = New System.Drawing.Point(280, 44)
        Me.cmbdrugnamestock.Name = "cmbdrugnamestock"
        Me.cmbdrugnamestock.Size = New System.Drawing.Size(286, 24)
        Me.cmbdrugnamestock.TabIndex = 0
        '
        'dtpDateReceived
        '
        Me.dtpDateReceived.Location = New System.Drawing.Point(280, 204)
        Me.dtpDateReceived.MaxDate = New Date(2026, 6, 25, 0, 0, 0, 0)
        Me.dtpDateReceived.Name = "dtpDateReceived"
        Me.dtpDateReceived.Size = New System.Drawing.Size(286, 22)
        Me.dtpDateReceived.TabIndex = 2
        Me.dtpDateReceived.Value = New Date(2026, 6, 25, 0, 0, 0, 0)
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpExpiryDate.Location = New System.Drawing.Point(280, 151)
        Me.dtpExpiryDate.MinDate = New Date(2026, 6, 25, 0, 0, 0, 0)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(286, 22)
        Me.dtpExpiryDate.TabIndex = 1
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(280, 95)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(286, 22)
        Me.txtquantity.TabIndex = 0
        Me.ttStock.SetToolTip(Me.txtquantity, "Enter the quantity you received")
        '
        'lblquantityreceived
        '
        Me.lblquantityreceived.AutoSize = True
        Me.lblquantityreceived.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantityreceived.Location = New System.Drawing.Point(92, 89)
        Me.lblquantityreceived.Name = "lblquantityreceived"
        Me.lblquantityreceived.Size = New System.Drawing.Size(176, 28)
        Me.lblquantityreceived.TabIndex = 4
        Me.lblquantityreceived.Text = "Quantity Received"
        '
        'lblexpirydate
        '
        Me.lblexpirydate.AutoSize = True
        Me.lblexpirydate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpirydate.Location = New System.Drawing.Point(142, 145)
        Me.lblexpirydate.Name = "lblexpirydate"
        Me.lblexpirydate.Size = New System.Drawing.Size(115, 28)
        Me.lblexpirydate.TabIndex = 3
        Me.lblexpirydate.Text = "Expiry Date"
        '
        'lbldatereceived
        '
        Me.lbldatereceived.AutoSize = True
        Me.lbldatereceived.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatereceived.Location = New System.Drawing.Point(117, 198)
        Me.lbldatereceived.Name = "lbldatereceived"
        Me.lbldatereceived.Size = New System.Drawing.Size(140, 28)
        Me.lbldatereceived.TabIndex = 2
        Me.lbldatereceived.Text = "Date Received"
        '
        'lbldrug
        '
        Me.lbldrug.AutoSize = True
        Me.lbldrug.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrug.Location = New System.Drawing.Point(200, 37)
        Me.lbldrug.Name = "lbldrug"
        Me.lbldrug.Size = New System.Drawing.Size(57, 28)
        Me.lbldrug.TabIndex = 0
        Me.lbldrug.Text = "Drug"
        '
        'pnlLowstock
        '
        Me.pnlLowstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLowstock.BackColor = System.Drawing.Color.PeachPuff
        Me.pnlLowstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLowstock.Controls.Add(Me.lbldrugname)
        Me.pnlLowstock.Controls.Add(Me.piclowstock)
        Me.pnlLowstock.Controls.Add(Me.lbllowstockheader)
        Me.pnlLowstock.Location = New System.Drawing.Point(388, 646)
        Me.pnlLowstock.Name = "pnlLowstock"
        Me.pnlLowstock.Size = New System.Drawing.Size(440, 150)
        Me.pnlLowstock.TabIndex = 8
        '
        'lbldrugname
        '
        Me.lbldrugname.AutoSize = True
        Me.lbldrugname.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrugname.ForeColor = System.Drawing.Color.Black
        Me.lbldrugname.Location = New System.Drawing.Point(26, 47)
        Me.lbldrugname.Name = "lbldrugname"
        Me.lbldrugname.Size = New System.Drawing.Size(105, 23)
        Me.lbldrugname.TabIndex = 2
        Me.lbldrugname.Text = "Paracetamol"
        '
        'piclowstock
        '
        Me.piclowstock.Image = CType(resources.GetObject("piclowstock.Image"), System.Drawing.Image)
        Me.piclowstock.Location = New System.Drawing.Point(41, 3)
        Me.piclowstock.Name = "piclowstock"
        Me.piclowstock.Size = New System.Drawing.Size(35, 25)
        Me.piclowstock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piclowstock.TabIndex = 1
        Me.piclowstock.TabStop = False
        '
        'lbllowstockheader
        '
        Me.lbllowstockheader.AutoSize = True
        Me.lbllowstockheader.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllowstockheader.ForeColor = System.Drawing.Color.Maroon
        Me.lbllowstockheader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbllowstockheader.Location = New System.Drawing.Point(82, 0)
        Me.lbllowstockheader.Name = "lbllowstockheader"
        Me.lbllowstockheader.Size = New System.Drawing.Size(298, 32)
        Me.lbllowstockheader.TabIndex = 0
        Me.lbllowstockheader.Text = "LOW STOCK ALERT PANEL"
        Me.lbllowstockheader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlsStock
        '
        Me.tlsStock.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsStock.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsrecordstock, Me.ToolStripSeparator1, Me.tlsviewcategory})
        Me.tlsStock.Location = New System.Drawing.Point(0, 37)
        Me.tlsStock.Name = "tlsStock"
        Me.tlsStock.Size = New System.Drawing.Size(1217, 27)
        Me.tlsStock.TabIndex = 10
        Me.tlsStock.Text = "ToolStrip1"
        '
        'tlsrecordstock
        '
        Me.tlsrecordstock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsrecordstock.Image = CType(resources.GetObject("tlsrecordstock.Image"), System.Drawing.Image)
        Me.tlsrecordstock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsrecordstock.Name = "tlsrecordstock"
        Me.tlsrecordstock.Size = New System.Drawing.Size(29, 24)
        Me.tlsrecordstock.Text = "Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tlsviewcategory
        '
        Me.tlsviewcategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsviewcategory.Image = CType(resources.GetObject("tlsviewcategory.Image"), System.Drawing.Image)
        Me.tlsviewcategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsviewcategory.Name = "tlsviewcategory"
        Me.tlsviewcategory.Size = New System.Drawing.Size(29, 24)
        Me.tlsviewcategory.Text = "Expiry Tracker"
        '
        'epStock
        '
        Me.epStock.ContainerControl = Me
        '
        'FrmStock
        '
        Me.AcceptButton = Me.btnrecordstock
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 861)
        Me.Controls.Add(Me.tlsStock)
        Me.Controls.Add(Me.pnlLowstock)
        Me.Controls.Add(Me.dgvStock)
        Me.Controls.Add(Me.btnrecordstock)
        Me.Controls.Add(Me.Panestock)
        Me.Controls.Add(Me.pnlstockbuttom)
        Me.Controls.Add(Me.pnlstockheader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStock"
        Me.pnlstockheader.ResumeLayout(False)
        Me.pnlstockheader.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panestock.ResumeLayout(False)
        Me.Panestock.PerformLayout()
        Me.pnlLowstock.ResumeLayout(False)
        Me.pnlLowstock.PerformLayout()
        CType(Me.piclowstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsStock.ResumeLayout(False)
        Me.tlsStock.PerformLayout()
        CType(Me.epStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlstockheader As Panel
    Friend WithEvents pnlstockbuttom As Panel
    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents btnrecordstock As Button
    Friend WithEvents Panestock As Panel
    Friend WithEvents lblquantityreceived As Label
    Friend WithEvents lblexpirydate As Label
    Friend WithEvents lbldatereceived As Label
    Friend WithEvents lbldrug As Label
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents dtpDateReceived As DateTimePicker
    Friend WithEvents ColumnDrugID As DataGridViewTextBoxColumn
    Friend WithEvents Columcategory As DataGridViewTextBoxColumn
    Friend WithEvents Columnstock As DataGridViewTextBoxColumn
    Friend WithEvents ColumnReorder As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUnitprice As DataGridViewTextBoxColumn
    Friend WithEvents pnlLowstock As Panel
    Friend WithEvents piclowstock As PictureBox
    Friend WithEvents lbllowstockheader As Label
    Friend WithEvents lbldrugname As Label
    Friend WithEvents lblpharmacystocktab As Label
    Friend WithEvents ttStock As ToolTip
    Friend WithEvents tlsStock As ToolStrip
    Friend WithEvents tlsrecordstock As ToolStripButton
    Friend WithEvents tlsviewcategory As ToolStripButton
    Friend WithEvents epStock As ErrorProvider
    Friend WithEvents cmbdrugnamestock As ComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
