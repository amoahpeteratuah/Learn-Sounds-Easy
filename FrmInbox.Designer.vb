<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frminbox
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frminbox))
        Me.Pnlinboxheader = New System.Windows.Forms.Panel()
        Me.lblpharmacyheader = New System.Windows.Forms.Label()
        Me.pnlinboxbuttom = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lstinbox = New System.Windows.Forms.ListBox()
        Me.Pnlheaderinb = New System.Windows.Forms.Panel()
        Me.lblinboxtxt = New System.Windows.Forms.Label()
        Me.lblinboxcont = New System.Windows.Forms.Label()
        Me.BtnaddtoReceipt = New System.Windows.Forms.Button()
        Me.Pnlheadermedi = New System.Windows.Forms.Panel()
        Me.lblmedicineselections = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.cmbcategorypharmacy = New System.Windows.Forms.ComboBox()
        Me.lbldosage = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblselectmedicine = New System.Windows.Forms.Label()
        Me.txtdosagephar = New System.Windows.Forms.TextBox()
        Me.txtquantityphar = New System.Windows.Forms.TextBox()
        Me.cmbselectmedi = New System.Windows.Forms.ComboBox()
        Me.dgvpharmacy = New System.Windows.Forms.DataGridView()
        Me.Columndrugname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnquatity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnunitpr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columntotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pnlheader = New System.Windows.Forms.Panel()
        Me.lblodersummary = New System.Windows.Forms.Label()
        Me.btndispensePrint = New System.Windows.Forms.Button()
        Me.ttinbox = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlsinbox = New System.Windows.Forms.ToolStrip()
        Me.tlsaddtorecipt = New System.Windows.Forms.ToolStripButton()
        Me.tlsdispenseandprint = New System.Windows.Forms.ToolStripButton()
        Me.epinbox = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.lblrealamount = New System.Windows.Forms.Label()
        Me.TmrPhar = New System.Windows.Forms.Timer(Me.components)
        Me.lblnote = New System.Windows.Forms.Label()
        Me.Pnlinboxheader.SuspendLayout()
        Me.Pnlheaderinb.SuspendLayout()
        Me.Pnlheadermedi.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvpharmacy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnlheader.SuspendLayout()
        Me.tlsinbox.SuspendLayout()
        CType(Me.epinbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnlinboxheader
        '
        Me.Pnlinboxheader.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Pnlinboxheader.Controls.Add(Me.lblpharmacyheader)
        Me.Pnlinboxheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnlinboxheader.Location = New System.Drawing.Point(0, 0)
        Me.Pnlinboxheader.Name = "Pnlinboxheader"
        Me.Pnlinboxheader.Size = New System.Drawing.Size(1059, 41)
        Me.Pnlinboxheader.TabIndex = 0
        '
        'lblpharmacyheader
        '
        Me.lblpharmacyheader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblpharmacyheader.AutoSize = True
        Me.lblpharmacyheader.BackColor = System.Drawing.Color.Transparent
        Me.lblpharmacyheader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpharmacyheader.ForeColor = System.Drawing.Color.White
        Me.lblpharmacyheader.Location = New System.Drawing.Point(361, 9)
        Me.lblpharmacyheader.Name = "lblpharmacyheader"
        Me.lblpharmacyheader.Size = New System.Drawing.Size(188, 28)
        Me.lblpharmacyheader.TabIndex = 0
        Me.lblpharmacyheader.Text = "PHARMACIST HUB"
        '
        'pnlinboxbuttom
        '
        Me.pnlinboxbuttom.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlinboxbuttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlinboxbuttom.Location = New System.Drawing.Point(0, 608)
        Me.pnlinboxbuttom.Name = "pnlinboxbuttom"
        Me.pnlinboxbuttom.Size = New System.Drawing.Size(1059, 25)
        Me.pnlinboxbuttom.TabIndex = 1
        '
        'Lstinbox
        '
        Me.Lstinbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lstinbox.FormattingEnabled = True
        Me.Lstinbox.ItemHeight = 16
        Me.Lstinbox.Location = New System.Drawing.Point(12, 143)
        Me.Lstinbox.Name = "Lstinbox"
        Me.Lstinbox.Size = New System.Drawing.Size(263, 388)
        Me.Lstinbox.TabIndex = 0
        '
        'Pnlheaderinb
        '
        Me.Pnlheaderinb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnlheaderinb.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnlheaderinb.Controls.Add(Me.lblinboxtxt)
        Me.Pnlheaderinb.Controls.Add(Me.lblinboxcont)
        Me.Pnlheaderinb.Location = New System.Drawing.Point(12, 77)
        Me.Pnlheaderinb.Name = "Pnlheaderinb"
        Me.Pnlheaderinb.Size = New System.Drawing.Size(263, 60)
        Me.Pnlheaderinb.TabIndex = 3
        '
        'lblinboxtxt
        '
        Me.lblinboxtxt.AutoSize = True
        Me.lblinboxtxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinboxtxt.ForeColor = System.Drawing.Color.White
        Me.lblinboxtxt.Location = New System.Drawing.Point(77, 0)
        Me.lblinboxtxt.Name = "lblinboxtxt"
        Me.lblinboxtxt.Size = New System.Drawing.Size(65, 28)
        Me.lblinboxtxt.TabIndex = 5
        Me.lblinboxtxt.Text = "Inbox"
        '
        'lblinboxcont
        '
        Me.lblinboxcont.AutoSize = True
        Me.lblinboxcont.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinboxcont.ForeColor = System.Drawing.Color.White
        Me.lblinboxcont.Location = New System.Drawing.Point(3, 26)
        Me.lblinboxcont.Name = "lblinboxcont"
        Me.lblinboxcont.Size = New System.Drawing.Size(214, 25)
        Me.lblinboxcont.TabIndex = 4
        Me.lblinboxcont.Text = "Incoming Prescriptions"
        '
        'BtnaddtoReceipt
        '
        Me.BtnaddtoReceipt.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnaddtoReceipt.FlatAppearance.BorderSize = 0
        Me.BtnaddtoReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnaddtoReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnaddtoReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnaddtoReceipt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnaddtoReceipt.ForeColor = System.Drawing.Color.White
        Me.BtnaddtoReceipt.Location = New System.Drawing.Point(442, 134)
        Me.BtnaddtoReceipt.Name = "BtnaddtoReceipt"
        Me.BtnaddtoReceipt.Size = New System.Drawing.Size(191, 39)
        Me.BtnaddtoReceipt.TabIndex = 5
        Me.BtnaddtoReceipt.Text = "&Add to Receipt"
        Me.ttinbox.SetToolTip(Me.BtnaddtoReceipt, "Add to the receipt")
        Me.BtnaddtoReceipt.UseVisualStyleBackColor = False
        '
        'Pnlheadermedi
        '
        Me.Pnlheadermedi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnlheadermedi.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnlheadermedi.Controls.Add(Me.lblmedicineselections)
        Me.Pnlheadermedi.Location = New System.Drawing.Point(335, 77)
        Me.Pnlheadermedi.Name = "Pnlheadermedi"
        Me.Pnlheadermedi.Size = New System.Drawing.Size(668, 60)
        Me.Pnlheadermedi.TabIndex = 6
        '
        'lblmedicineselections
        '
        Me.lblmedicineselections.AutoSize = True
        Me.lblmedicineselections.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedicineselections.ForeColor = System.Drawing.Color.White
        Me.lblmedicineselections.Location = New System.Drawing.Point(189, 26)
        Me.lblmedicineselections.Name = "lblmedicineselections"
        Me.lblmedicineselections.Size = New System.Drawing.Size(275, 25)
        Me.lblmedicineselections.TabIndex = 4
        Me.lblmedicineselections.Text = "Medicine Selection(Inventory)"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblnote)
        Me.Panel4.Controls.Add(Me.lblcategory)
        Me.Panel4.Controls.Add(Me.cmbcategorypharmacy)
        Me.Panel4.Controls.Add(Me.lbldosage)
        Me.Panel4.Controls.Add(Me.lblquantity)
        Me.Panel4.Controls.Add(Me.BtnaddtoReceipt)
        Me.Panel4.Controls.Add(Me.lblselectmedicine)
        Me.Panel4.Controls.Add(Me.txtdosagephar)
        Me.Panel4.Controls.Add(Me.txtquantityphar)
        Me.Panel4.Controls.Add(Me.cmbselectmedi)
        Me.Panel4.Location = New System.Drawing.Point(335, 131)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(668, 191)
        Me.Panel4.TabIndex = 7
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(49, 8)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(91, 25)
        Me.lblcategory.TabIndex = 7
        Me.lblcategory.Text = "Category"
        '
        'cmbcategorypharmacy
        '
        Me.cmbcategorypharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategorypharmacy.FormattingEnabled = True
        Me.cmbcategorypharmacy.Items.AddRange(New Object() {"ANTACIDS", "ANTIBIOTICS", "SULFA DRUGS", "ANALGESICS", "TRANQUILIZERS"})
        Me.cmbcategorypharmacy.Location = New System.Drawing.Point(19, 39)
        Me.cmbcategorypharmacy.Name = "cmbcategorypharmacy"
        Me.cmbcategorypharmacy.Size = New System.Drawing.Size(167, 24)
        Me.cmbcategorypharmacy.TabIndex = 1
        Me.ttinbox.SetToolTip(Me.cmbcategorypharmacy, "Select category")
        '
        'lbldosage
        '
        Me.lbldosage.AutoSize = True
        Me.lbldosage.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldosage.Location = New System.Drawing.Point(49, 82)
        Me.lbldosage.Name = "lbldosage"
        Me.lbldosage.Size = New System.Drawing.Size(76, 25)
        Me.lbldosage.TabIndex = 5
        Me.lbldosage.Text = "Dosage"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(500, 8)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(87, 25)
        Me.lblquantity.TabIndex = 4
        Me.lblquantity.Text = "Quantity"
        '
        'lblselectmedicine
        '
        Me.lblselectmedicine.AutoSize = True
        Me.lblselectmedicine.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectmedicine.Location = New System.Drawing.Point(237, 10)
        Me.lblselectmedicine.Name = "lblselectmedicine"
        Me.lblselectmedicine.Size = New System.Drawing.Size(147, 25)
        Me.lblselectmedicine.TabIndex = 3
        Me.lblselectmedicine.Text = "Select Medicine"
        '
        'txtdosagephar
        '
        Me.txtdosagephar.Location = New System.Drawing.Point(19, 110)
        Me.txtdosagephar.Multiline = True
        Me.txtdosagephar.Name = "txtdosagephar"
        Me.txtdosagephar.Size = New System.Drawing.Size(316, 41)
        Me.txtdosagephar.TabIndex = 4
        Me.ttinbox.SetToolTip(Me.txtdosagephar, "The dosage")
        '
        'txtquantityphar
        '
        Me.txtquantityphar.Location = New System.Drawing.Point(474, 41)
        Me.txtquantityphar.Name = "txtquantityphar"
        Me.txtquantityphar.Size = New System.Drawing.Size(159, 22)
        Me.txtquantityphar.TabIndex = 3
        Me.ttinbox.SetToolTip(Me.txtquantityphar, "Enter the quantity here")
        '
        'cmbselectmedi
        '
        Me.cmbselectmedi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbselectmedi.FormattingEnabled = True
        Me.cmbselectmedi.Location = New System.Drawing.Point(214, 39)
        Me.cmbselectmedi.Name = "cmbselectmedi"
        Me.cmbselectmedi.Size = New System.Drawing.Size(239, 24)
        Me.cmbselectmedi.TabIndex = 2
        Me.ttinbox.SetToolTip(Me.cmbselectmedi, "Select medicine")
        '
        'dgvpharmacy
        '
        Me.dgvpharmacy.AllowUserToAddRows = False
        Me.dgvpharmacy.AllowUserToDeleteRows = False
        Me.dgvpharmacy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvpharmacy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpharmacy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvpharmacy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpharmacy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Columndrugname, Me.Columnquatity, Me.Columnunitpr, Me.Columntotal})
        Me.dgvpharmacy.EnableHeadersVisualStyles = False
        Me.dgvpharmacy.Location = New System.Drawing.Point(335, 381)
        Me.dgvpharmacy.Name = "dgvpharmacy"
        Me.dgvpharmacy.ReadOnly = True
        Me.dgvpharmacy.RowHeadersWidth = 51
        Me.dgvpharmacy.RowTemplate.Height = 24
        Me.dgvpharmacy.Size = New System.Drawing.Size(668, 150)
        Me.dgvpharmacy.TabIndex = 8
        '
        'Columndrugname
        '
        Me.Columndrugname.HeaderText = "Medicine Name"
        Me.Columndrugname.MinimumWidth = 6
        Me.Columndrugname.Name = "Columndrugname"
        Me.Columndrugname.ReadOnly = True
        Me.Columndrugname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Columnquatity
        '
        Me.Columnquatity.HeaderText = "Quantity"
        Me.Columnquatity.MinimumWidth = 6
        Me.Columnquatity.Name = "Columnquatity"
        Me.Columnquatity.ReadOnly = True
        Me.Columnquatity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Columnunitpr
        '
        Me.Columnunitpr.HeaderText = "Unit Price"
        Me.Columnunitpr.MinimumWidth = 6
        Me.Columnunitpr.Name = "Columnunitpr"
        Me.Columnunitpr.ReadOnly = True
        Me.Columnunitpr.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Columntotal
        '
        Me.Columntotal.HeaderText = "Total Price"
        Me.Columntotal.MinimumWidth = 6
        Me.Columntotal.Name = "Columntotal"
        Me.Columntotal.ReadOnly = True
        Me.Columntotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Pnlheader
        '
        Me.Pnlheader.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnlheader.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnlheader.Controls.Add(Me.lblodersummary)
        Me.Pnlheader.Location = New System.Drawing.Point(335, 338)
        Me.Pnlheader.Name = "Pnlheader"
        Me.Pnlheader.Size = New System.Drawing.Size(668, 49)
        Me.Pnlheader.TabIndex = 7
        '
        'lblodersummary
        '
        Me.lblodersummary.AutoSize = True
        Me.lblodersummary.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblodersummary.ForeColor = System.Drawing.Color.White
        Me.lblodersummary.Location = New System.Drawing.Point(211, 15)
        Me.lblodersummary.Name = "lblodersummary"
        Me.lblodersummary.Size = New System.Drawing.Size(231, 25)
        Me.lblodersummary.TabIndex = 4
        Me.lblodersummary.Text = "Order Summary(Receipt)"
        '
        'btndispensePrint
        '
        Me.btndispensePrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndispensePrint.BackColor = System.Drawing.Color.SteelBlue
        Me.btndispensePrint.FlatAppearance.BorderSize = 0
        Me.btndispensePrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndispensePrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btndispensePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndispensePrint.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndispensePrint.ForeColor = System.Drawing.Color.White
        Me.btndispensePrint.Location = New System.Drawing.Point(621, 541)
        Me.btndispensePrint.Name = "btndispensePrint"
        Me.btndispensePrint.Size = New System.Drawing.Size(191, 39)
        Me.btndispensePrint.TabIndex = 6
        Me.btndispensePrint.Text = "&Dispense ∕ Print"
        Me.ttinbox.SetToolTip(Me.btndispensePrint, "Dispense and print receipt")
        Me.btndispensePrint.UseVisualStyleBackColor = False
        '
        'tlsinbox
        '
        Me.tlsinbox.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsinbox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsaddtorecipt, Me.tlsdispenseandprint})
        Me.tlsinbox.Location = New System.Drawing.Point(0, 41)
        Me.tlsinbox.Name = "tlsinbox"
        Me.tlsinbox.Size = New System.Drawing.Size(1059, 27)
        Me.tlsinbox.TabIndex = 9
        Me.tlsinbox.Text = "ToolStrip1"
        '
        'tlsaddtorecipt
        '
        Me.tlsaddtorecipt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsaddtorecipt.Image = CType(resources.GetObject("tlsaddtorecipt.Image"), System.Drawing.Image)
        Me.tlsaddtorecipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsaddtorecipt.Name = "tlsaddtorecipt"
        Me.tlsaddtorecipt.Size = New System.Drawing.Size(29, 24)
        Me.tlsaddtorecipt.ToolTipText = "Add to receipt"
        '
        'tlsdispenseandprint
        '
        Me.tlsdispenseandprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsdispenseandprint.Image = CType(resources.GetObject("tlsdispenseandprint.Image"), System.Drawing.Image)
        Me.tlsdispenseandprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsdispenseandprint.Name = "tlsdispenseandprint"
        Me.tlsdispenseandprint.Size = New System.Drawing.Size(29, 24)
        Me.tlsdispenseandprint.ToolTipText = "Dispense and print receipt"
        '
        'epinbox
        '
        Me.epinbox.ContainerControl = Me
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.Location = New System.Drawing.Point(330, 549)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(118, 25)
        Me.lbltotalamount.TabIndex = 10
        Me.lbltotalamount.Text = "TOTAL: GHS"
        '
        'lblrealamount
        '
        Me.lblrealamount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblrealamount.AutoSize = True
        Me.lblrealamount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrealamount.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblrealamount.Location = New System.Drawing.Point(454, 549)
        Me.lblrealamount.Name = "lblrealamount"
        Me.lblrealamount.Size = New System.Drawing.Size(61, 25)
        Me.lblrealamount.TabIndex = 11
        Me.lblrealamount.Text = "00.00"
        Me.lblrealamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrPhar
        '
        Me.TmrPhar.Enabled = True
        Me.TmrPhar.Interval = 2000
        '
        'lblnote
        '
        Me.lblnote.Location = New System.Drawing.Point(19, 154)
        Me.lblnote.Name = "lblnote"
        Me.lblnote.Size = New System.Drawing.Size(402, 23)
        Me.lblnote.TabIndex = 8
        Me.lblnote.Text = "..notes"
        '
        'Frminbox
        '
        Me.AcceptButton = Me.BtnaddtoReceipt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 633)
        Me.Controls.Add(Me.lblrealamount)
        Me.Controls.Add(Me.lbltotalamount)
        Me.Controls.Add(Me.tlsinbox)
        Me.Controls.Add(Me.btndispensePrint)
        Me.Controls.Add(Me.Pnlheader)
        Me.Controls.Add(Me.dgvpharmacy)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Pnlheadermedi)
        Me.Controls.Add(Me.Pnlheaderinb)
        Me.Controls.Add(Me.Lstinbox)
        Me.Controls.Add(Me.pnlinboxbuttom)
        Me.Controls.Add(Me.Pnlinboxheader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frminbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frminbox"
        Me.Pnlinboxheader.ResumeLayout(False)
        Me.Pnlinboxheader.PerformLayout()
        Me.Pnlheaderinb.ResumeLayout(False)
        Me.Pnlheaderinb.PerformLayout()
        Me.Pnlheadermedi.ResumeLayout(False)
        Me.Pnlheadermedi.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvpharmacy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnlheader.ResumeLayout(False)
        Me.Pnlheader.PerformLayout()
        Me.tlsinbox.ResumeLayout(False)
        Me.tlsinbox.PerformLayout()
        CType(Me.epinbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pnlinboxheader As Panel
    Friend WithEvents pnlinboxbuttom As FlowLayoutPanel
    Friend WithEvents Lstinbox As ListBox
    Friend WithEvents Pnlheaderinb As Panel
    Friend WithEvents BtnaddtoReceipt As Button
    Friend WithEvents lblpharmacyheader As Label
    Friend WithEvents lblinboxtxt As Label
    Friend WithEvents lblinboxcont As Label
    Friend WithEvents Pnlheadermedi As Panel
    Friend WithEvents lblmedicineselections As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbldosage As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lblselectmedicine As Label
    Friend WithEvents txtdosagephar As TextBox
    Friend WithEvents txtquantityphar As TextBox
    Friend WithEvents cmbselectmedi As ComboBox
    Friend WithEvents dgvpharmacy As DataGridView
    Friend WithEvents Pnlheader As Panel
    Friend WithEvents lblodersummary As Label
    Friend WithEvents btndispensePrint As Button
    Friend WithEvents ttinbox As ToolTip
    Friend WithEvents tlsinbox As ToolStrip
    Friend WithEvents tlsaddtorecipt As ToolStripButton
    Friend WithEvents tlsdispenseandprint As ToolStripButton
    Friend WithEvents epinbox As ErrorProvider
    Friend WithEvents lblrealamount As Label
    Friend WithEvents lbltotalamount As Label
    Friend WithEvents lblcategory As Label
    Friend WithEvents cmbcategorypharmacy As ComboBox
    Friend WithEvents TmrPhar As Timer
    Friend WithEvents Columndrugname As DataGridViewTextBoxColumn
    Friend WithEvents Columnquatity As DataGridViewTextBoxColumn
    Friend WithEvents Columnunitpr As DataGridViewTextBoxColumn
    Friend WithEvents Columntotal As DataGridViewTextBoxColumn
    Friend WithEvents lblnote As Label
End Class
