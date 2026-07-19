<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmadddrugtab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmadddrugtab))
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlbuttom = New System.Windows.Forms.Panel()
        Me.Pnldrugtab = New System.Windows.Forms.Panel()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.txtreorderlevel = New System.Windows.Forms.TextBox()
        Me.cmbunit = New System.Windows.Forms.ComboBox()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.txtdrugname = New System.Windows.Forms.TextBox()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.lblreorder = New System.Windows.Forms.Label()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lbldrugname = New System.Windows.Forms.Label()
        Me.btnadddrug = New System.Windows.Forms.Button()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.ttadddrug = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlsadddrug = New System.Windows.Forms.ToolStrip()
        Me.tlsadd = New System.Windows.Forms.ToolStripButton()
        Me.tlsclear = New System.Windows.Forms.ToolStripButton()
        Me.tlsviewcategory = New System.Windows.Forms.ToolStripButton()
        Me.epadddrug = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ColumnDrugID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDrugname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnReorder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnstock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUnitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlheader.SuspendLayout()
        Me.Pnldrugtab.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsadddrug.SuspendLayout()
        CType(Me.epadddrug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.Navy
        Me.pnlheader.Controls.Add(Me.Label7)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1305, 39)
        Me.pnlheader.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(465, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(347, 28)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "PHARMACY MANAGER DRUGS TAB"
        '
        'pnlbuttom
        '
        Me.pnlbuttom.BackColor = System.Drawing.Color.Navy
        Me.pnlbuttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbuttom.Location = New System.Drawing.Point(0, 655)
        Me.pnlbuttom.Name = "pnlbuttom"
        Me.pnlbuttom.Size = New System.Drawing.Size(1305, 35)
        Me.pnlbuttom.TabIndex = 1
        '
        'Pnldrugtab
        '
        Me.Pnldrugtab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnldrugtab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pnldrugtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnldrugtab.Controls.Add(Me.txtunitprice)
        Me.Pnldrugtab.Controls.Add(Me.txtreorderlevel)
        Me.Pnldrugtab.Controls.Add(Me.cmbunit)
        Me.Pnldrugtab.Controls.Add(Me.cmbcategory)
        Me.Pnldrugtab.Controls.Add(Me.txtdrugname)
        Me.Pnldrugtab.Controls.Add(Me.lblcategory)
        Me.Pnldrugtab.Controls.Add(Me.lblunit)
        Me.Pnldrugtab.Controls.Add(Me.lblreorder)
        Me.Pnldrugtab.Controls.Add(Me.lblunitprice)
        Me.Pnldrugtab.Controls.Add(Me.lbldrugname)
        Me.Pnldrugtab.Location = New System.Drawing.Point(167, 94)
        Me.Pnldrugtab.Name = "Pnldrugtab"
        Me.Pnldrugtab.Size = New System.Drawing.Size(982, 289)
        Me.Pnldrugtab.TabIndex = 2
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(226, 256)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(286, 22)
        Me.txtunitprice.TabIndex = 4
        Me.ttadddrug.SetToolTip(Me.txtunitprice, "Please, enter the unit price of each drug")
        '
        'txtreorderlevel
        '
        Me.txtreorderlevel.Location = New System.Drawing.Point(226, 205)
        Me.txtreorderlevel.Name = "txtreorderlevel"
        Me.txtreorderlevel.Size = New System.Drawing.Size(286, 22)
        Me.txtreorderlevel.TabIndex = 3
        Me.ttadddrug.SetToolTip(Me.txtreorderlevel, "Enter the reorder level number")
        '
        'cmbunit
        '
        Me.cmbunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Items.AddRange(New Object() {"Capsules", "Tablets", "Caplets", "Syrup"})
        Me.cmbunit.Location = New System.Drawing.Point(226, 146)
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(286, 24)
        Me.cmbunit.TabIndex = 2
        '
        'cmbcategory
        '
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"ANTACIDS", "ANTIBIOTICS", "SULFA DRUGS", "ANALGESICS", "TRANQUILIZERS"})
        Me.cmbcategory.Location = New System.Drawing.Point(226, 93)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(286, 24)
        Me.cmbcategory.TabIndex = 1
        '
        'txtdrugname
        '
        Me.txtdrugname.Location = New System.Drawing.Point(226, 42)
        Me.txtdrugname.Name = "txtdrugname"
        Me.txtdrugname.Size = New System.Drawing.Size(286, 22)
        Me.txtdrugname.TabIndex = 0
        Me.ttadddrug.SetToolTip(Me.txtdrugname, "Enter drug name")
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(115, 89)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(94, 28)
        Me.lblcategory.TabIndex = 4
        Me.lblcategory.Text = "Category"
        '
        'lblunit
        '
        Me.lblunit.AutoSize = True
        Me.lblunit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(159, 142)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(50, 28)
        Me.lblunit.TabIndex = 3
        Me.lblunit.Text = "Unit"
        '
        'lblreorder
        '
        Me.lblreorder.AutoSize = True
        Me.lblreorder.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreorder.Location = New System.Drawing.Point(78, 199)
        Me.lblreorder.Name = "lblreorder"
        Me.lblreorder.Size = New System.Drawing.Size(131, 28)
        Me.lblreorder.TabIndex = 2
        Me.lblreorder.Text = "Reorder level"
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitprice.Location = New System.Drawing.Point(55, 250)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(154, 28)
        Me.lblunitprice.TabIndex = 1
        Me.lblunitprice.Text = "Unit Price(GHS)"
        '
        'lbldrugname
        '
        Me.lbldrugname.AutoSize = True
        Me.lbldrugname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrugname.Location = New System.Drawing.Point(92, 36)
        Me.lbldrugname.Name = "lbldrugname"
        Me.lbldrugname.Size = New System.Drawing.Size(117, 28)
        Me.lbldrugname.TabIndex = 0
        Me.lbldrugname.Text = "Drug Name"
        '
        'btnadddrug
        '
        Me.btnadddrug.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnadddrug.BackColor = System.Drawing.Color.Navy
        Me.btnadddrug.FlatAppearance.BorderSize = 0
        Me.btnadddrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnadddrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnadddrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadddrug.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadddrug.ForeColor = System.Drawing.Color.White
        Me.btnadddrug.Location = New System.Drawing.Point(557, 411)
        Me.btnadddrug.Name = "btnadddrug"
        Me.btnadddrug.Size = New System.Drawing.Size(191, 44)
        Me.btnadddrug.TabIndex = 5
        Me.btnadddrug.Text = "&ADD DRUG"
        Me.ttadddrug.SetToolTip(Me.btnadddrug, "Click to add a drug")
        Me.btnadddrug.UseVisualStyleBackColor = False
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnDrugID, Me.ColumnDrugname, Me.Columcategory, Me.ColumnUnit, Me.ColumnReorder, Me.Columnstock, Me.ColumnUnitprice, Me.colDelete})
        Me.dgvInventory.EnableHeadersVisualStyles = False
        Me.dgvInventory.Location = New System.Drawing.Point(101, 481)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.RowTemplate.Height = 24
        Me.dgvInventory.Size = New System.Drawing.Size(1097, 150)
        Me.dgvInventory.TabIndex = 4
        Me.ttadddrug.SetToolTip(Me.dgvInventory, "List of drugs added")
        '
        'tlsadddrug
        '
        Me.tlsadddrug.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsadddrug.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsadd, Me.tlsclear, Me.tlsviewcategory})
        Me.tlsadddrug.Location = New System.Drawing.Point(0, 39)
        Me.tlsadddrug.Name = "tlsadddrug"
        Me.tlsadddrug.Size = New System.Drawing.Size(1305, 27)
        Me.tlsadddrug.TabIndex = 6
        Me.tlsadddrug.Text = "ToolStrip1"
        '
        'tlsadd
        '
        Me.tlsadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsadd.Image = CType(resources.GetObject("tlsadd.Image"), System.Drawing.Image)
        Me.tlsadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsadd.Name = "tlsadd"
        Me.tlsadd.Size = New System.Drawing.Size(29, 24)
        Me.tlsadd.Text = "Save"
        '
        'tlsclear
        '
        Me.tlsclear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsclear.Image = CType(resources.GetObject("tlsclear.Image"), System.Drawing.Image)
        Me.tlsclear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsclear.Name = "tlsclear"
        Me.tlsclear.Size = New System.Drawing.Size(29, 24)
        Me.tlsclear.Text = "Clear"
        '
        'tlsviewcategory
        '
        Me.tlsviewcategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsviewcategory.Image = CType(resources.GetObject("tlsviewcategory.Image"), System.Drawing.Image)
        Me.tlsviewcategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsviewcategory.Name = "tlsviewcategory"
        Me.tlsviewcategory.Size = New System.Drawing.Size(29, 24)
        Me.tlsviewcategory.Text = "View Category"
        '
        'epadddrug
        '
        Me.epadddrug.ContainerControl = Me
        '
        'ColumnDrugID
        '
        Me.ColumnDrugID.HeaderText = "Drug ID"
        Me.ColumnDrugID.MinimumWidth = 6
        Me.ColumnDrugID.Name = "ColumnDrugID"
        Me.ColumnDrugID.ReadOnly = True
        Me.ColumnDrugID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnDrugname
        '
        Me.ColumnDrugname.HeaderText = "Drug Name"
        Me.ColumnDrugname.MinimumWidth = 6
        Me.ColumnDrugname.Name = "ColumnDrugname"
        Me.ColumnDrugname.ReadOnly = True
        Me.ColumnDrugname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Columcategory
        '
        Me.Columcategory.HeaderText = "Category"
        Me.Columcategory.MinimumWidth = 6
        Me.Columcategory.Name = "Columcategory"
        Me.Columcategory.ReadOnly = True
        Me.Columcategory.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnUnit
        '
        Me.ColumnUnit.HeaderText = "Unit"
        Me.ColumnUnit.MinimumWidth = 6
        Me.ColumnUnit.Name = "ColumnUnit"
        Me.ColumnUnit.ReadOnly = True
        Me.ColumnUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnReorder
        '
        Me.ColumnReorder.HeaderText = "Reorder"
        Me.ColumnReorder.MinimumWidth = 6
        Me.ColumnReorder.Name = "ColumnReorder"
        Me.ColumnReorder.ReadOnly = True
        Me.ColumnReorder.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Columnstock
        '
        Me.Columnstock.HeaderText = "Stock"
        Me.Columnstock.MinimumWidth = 6
        Me.Columnstock.Name = "Columnstock"
        Me.Columnstock.ReadOnly = True
        Me.Columnstock.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnUnitprice
        '
        Me.ColumnUnitprice.HeaderText = "Unit Price"
        Me.ColumnUnitprice.MinimumWidth = 6
        Me.ColumnUnitprice.Name = "ColumnUnitprice"
        Me.ColumnUnitprice.ReadOnly = True
        Me.ColumnUnitprice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colDelete
        '
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = "Action"
        Me.colDelete.MinimumWidth = 6
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDelete.Text = "Delete"
        Me.colDelete.ToolTipText = "Delete"
        Me.colDelete.UseColumnTextForButtonValue = True
        '
        'Frmadddrugtab
        '
        Me.AcceptButton = Me.btnadddrug
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 690)
        Me.Controls.Add(Me.tlsadddrug)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.btnadddrug)
        Me.Controls.Add(Me.Pnldrugtab)
        Me.Controls.Add(Me.pnlbuttom)
        Me.Controls.Add(Me.pnlheader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmadddrugtab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmadddrugtab"
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.Pnldrugtab.ResumeLayout(False)
        Me.Pnldrugtab.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsadddrug.ResumeLayout(False)
        Me.tlsadddrug.PerformLayout()
        CType(Me.epadddrug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlheader As Panel
    Friend WithEvents pnlbuttom As Panel
    Friend WithEvents Pnldrugtab As Panel
    Friend WithEvents btnadddrug As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lblcategory As Label
    Friend WithEvents lblunit As Label
    Friend WithEvents lblreorder As Label
    Friend WithEvents lblunitprice As Label
    Friend WithEvents lbldrugname As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents txtreorderlevel As TextBox
    Friend WithEvents cmbunit As ComboBox
    Friend WithEvents cmbcategory As ComboBox
    Friend WithEvents txtdrugname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ttadddrug As ToolTip
    Friend WithEvents tlsadddrug As ToolStrip
    Friend WithEvents tlsadd As ToolStripButton
    Friend WithEvents tlsclear As ToolStripButton
    Friend WithEvents tlsviewcategory As ToolStripButton
    Friend WithEvents epadddrug As ErrorProvider
    Friend WithEvents ColumnDrugID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDrugname As DataGridViewTextBoxColumn
    Friend WithEvents Columcategory As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUnit As DataGridViewTextBoxColumn
    Friend WithEvents ColumnReorder As DataGridViewTextBoxColumn
    Friend WithEvents Columnstock As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUnitprice As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
End Class
