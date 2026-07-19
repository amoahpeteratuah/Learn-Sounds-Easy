<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmdoctor))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnldoctorheader = New System.Windows.Forms.Panel()
        Me.lbldoctortab = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnldoctorbuttom = New System.Windows.Forms.Panel()
        Me.Pnlpriscriptiontab = New System.Windows.Forms.Panel()
        Me.cmbdrug = New System.Windows.Forms.ComboBox()
        Me.txtnotes = New System.Windows.Forms.TextBox()
        Me.txtdosageinstruction = New System.Windows.Forms.TextBox()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.lblnotes = New System.Windows.Forms.Label()
        Me.lbldosageinstruction = New System.Windows.Forms.Label()
        Me.lbldrug = New System.Windows.Forms.Label()
        Me.lblpatientname = New System.Windows.Forms.Label()
        Me.btnsendtoPharmacist = New System.Windows.Forms.Button()
        Me.dgvPrescriptions = New System.Windows.Forms.DataGridView()
        Me.Columnname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDrug = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDosage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDatesent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnldoctormiddlebar = New System.Windows.Forms.Panel()
        Me.picsentprescription = New System.Windows.Forms.PictureBox()
        Me.lblsentheader = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.ttdoctortab = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlsdoctortab = New System.Windows.Forms.ToolStrip()
        Me.tlsadd = New System.Windows.Forms.ToolStripButton()
        Me.tlssaveSent = New System.Windows.Forms.ToolStripButton()
        Me.tlscancel = New System.Windows.Forms.ToolStripButton()
        Me.epdoctortab = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblemail = New System.Windows.Forms.Label()
        Me.txtdoctoremail = New System.Windows.Forms.TextBox()
        Me.pnldoctorheader.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnlpriscriptiontab.SuspendLayout()
        CType(Me.dgvPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnldoctormiddlebar.SuspendLayout()
        CType(Me.picsentprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsdoctortab.SuspendLayout()
        CType(Me.epdoctortab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnldoctorheader
        '
        Me.pnldoctorheader.BackColor = System.Drawing.Color.Turquoise
        Me.pnldoctorheader.Controls.Add(Me.lbldoctortab)
        Me.pnldoctorheader.Controls.Add(Me.PictureBox2)
        Me.pnldoctorheader.Controls.Add(Me.PictureBox1)
        Me.pnldoctorheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnldoctorheader.Location = New System.Drawing.Point(0, 0)
        Me.pnldoctorheader.Name = "pnldoctorheader"
        Me.pnldoctorheader.Size = New System.Drawing.Size(1482, 42)
        Me.pnldoctorheader.TabIndex = 0
        '
        'lbldoctortab
        '
        Me.lbldoctortab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbldoctortab.AutoSize = True
        Me.lbldoctortab.BackColor = System.Drawing.Color.Transparent
        Me.lbldoctortab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoctortab.ForeColor = System.Drawing.Color.White
        Me.lbldoctortab.Location = New System.Drawing.Point(576, 9)
        Me.lbldoctortab.Name = "lbldoctortab"
        Me.lbldoctortab.Size = New System.Drawing.Size(220, 28)
        Me.lbldoctortab.TabIndex = 2
        Me.lbldoctortab.Text = "DOCTOR'S INTERFACE"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-165, -9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1505, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnldoctorbuttom
        '
        Me.pnldoctorbuttom.BackColor = System.Drawing.Color.Turquoise
        Me.pnldoctorbuttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnldoctorbuttom.Location = New System.Drawing.Point(0, 943)
        Me.pnldoctorbuttom.Name = "pnldoctorbuttom"
        Me.pnldoctorbuttom.Size = New System.Drawing.Size(1482, 50)
        Me.pnldoctorbuttom.TabIndex = 1
        '
        'Pnlpriscriptiontab
        '
        Me.Pnlpriscriptiontab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnlpriscriptiontab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pnlpriscriptiontab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnlpriscriptiontab.Controls.Add(Me.txtdoctoremail)
        Me.Pnlpriscriptiontab.Controls.Add(Me.lblemail)
        Me.Pnlpriscriptiontab.Controls.Add(Me.cmbdrug)
        Me.Pnlpriscriptiontab.Controls.Add(Me.txtnotes)
        Me.Pnlpriscriptiontab.Controls.Add(Me.txtdosageinstruction)
        Me.Pnlpriscriptiontab.Controls.Add(Me.txtpatientname)
        Me.Pnlpriscriptiontab.Controls.Add(Me.lblnotes)
        Me.Pnlpriscriptiontab.Controls.Add(Me.lbldosageinstruction)
        Me.Pnlpriscriptiontab.Controls.Add(Me.lbldrug)
        Me.Pnlpriscriptiontab.Controls.Add(Me.lblpatientname)
        Me.Pnlpriscriptiontab.Location = New System.Drawing.Point(68, 89)
        Me.Pnlpriscriptiontab.Name = "Pnlpriscriptiontab"
        Me.Pnlpriscriptiontab.Size = New System.Drawing.Size(1308, 328)
        Me.Pnlpriscriptiontab.TabIndex = 2
        '
        'cmbdrug
        '
        Me.cmbdrug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdrug.FormattingEnabled = True
        Me.cmbdrug.Location = New System.Drawing.Point(272, 80)
        Me.cmbdrug.Name = "cmbdrug"
        Me.cmbdrug.Size = New System.Drawing.Size(284, 24)
        Me.cmbdrug.TabIndex = 1
        '
        'txtnotes
        '
        Me.txtnotes.Location = New System.Drawing.Point(272, 208)
        Me.txtnotes.Multiline = True
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(534, 50)
        Me.txtnotes.TabIndex = 3
        Me.ttdoctortab.SetToolTip(Me.txtnotes, "Please. add note if necessary")
        '
        'txtdosageinstruction
        '
        Me.txtdosageinstruction.Location = New System.Drawing.Point(272, 140)
        Me.txtdosageinstruction.Multiline = True
        Me.txtdosageinstruction.Name = "txtdosageinstruction"
        Me.txtdosageinstruction.Size = New System.Drawing.Size(534, 40)
        Me.txtdosageinstruction.TabIndex = 2
        Me.ttdoctortab.SetToolTip(Me.txtdosageinstruction, "Add dosage instructions")
        '
        'txtpatientname
        '
        Me.txtpatientname.Location = New System.Drawing.Point(272, 28)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(284, 22)
        Me.txtpatientname.TabIndex = 0
        Me.ttdoctortab.SetToolTip(Me.txtpatientname, "Please,enter the patient's name")
        '
        'lblnotes
        '
        Me.lblnotes.AutoSize = True
        Me.lblnotes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotes.Location = New System.Drawing.Point(24, 208)
        Me.lblnotes.Name = "lblnotes"
        Me.lblnotes.Size = New System.Drawing.Size(166, 28)
        Me.lblnotes.TabIndex = 3
        Me.lblnotes.Text = "Notes(optional):"
        '
        'lbldosageinstruction
        '
        Me.lbldosageinstruction.AutoSize = True
        Me.lbldosageinstruction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldosageinstruction.Location = New System.Drawing.Point(24, 133)
        Me.lbldosageinstruction.Name = "lbldosageinstruction"
        Me.lbldosageinstruction.Size = New System.Drawing.Size(195, 28)
        Me.lbldosageinstruction.TabIndex = 2
        Me.lbldosageinstruction.Text = "Dosage Instrustion:"
        '
        'lbldrug
        '
        Me.lbldrug.AutoSize = True
        Me.lbldrug.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrug.Location = New System.Drawing.Point(24, 73)
        Me.lbldrug.Name = "lbldrug"
        Me.lbldrug.Size = New System.Drawing.Size(64, 28)
        Me.lbldrug.TabIndex = 1
        Me.lbldrug.Text = "Drug:"
        '
        'lblpatientname
        '
        Me.lblpatientname.AutoSize = True
        Me.lblpatientname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatientname.Location = New System.Drawing.Point(24, 21)
        Me.lblpatientname.Name = "lblpatientname"
        Me.lblpatientname.Size = New System.Drawing.Size(147, 28)
        Me.lblpatientname.TabIndex = 0
        Me.lblpatientname.Text = "Patient Name:"
        '
        'btnsendtoPharmacist
        '
        Me.btnsendtoPharmacist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsendtoPharmacist.BackColor = System.Drawing.Color.Turquoise
        Me.btnsendtoPharmacist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsendtoPharmacist.FlatAppearance.BorderSize = 0
        Me.btnsendtoPharmacist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsendtoPharmacist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnsendtoPharmacist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsendtoPharmacist.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendtoPharmacist.ForeColor = System.Drawing.Color.White
        Me.btnsendtoPharmacist.Image = CType(resources.GetObject("btnsendtoPharmacist.Image"), System.Drawing.Image)
        Me.btnsendtoPharmacist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsendtoPharmacist.Location = New System.Drawing.Point(361, 434)
        Me.btnsendtoPharmacist.Name = "btnsendtoPharmacist"
        Me.btnsendtoPharmacist.Size = New System.Drawing.Size(308, 69)
        Me.btnsendtoPharmacist.TabIndex = 4
        Me.btnsendtoPharmacist.Text = "&SEND TO PHARMACIST  "
        Me.btnsendtoPharmacist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttdoctortab.SetToolTip(Me.btnsendtoPharmacist, "Click to submit Drug Prescriptions to Pharmarcist")
        Me.btnsendtoPharmacist.UseVisualStyleBackColor = False
        '
        'dgvPrescriptions
        '
        Me.dgvPrescriptions.AllowUserToAddRows = False
        Me.dgvPrescriptions.AllowUserToDeleteRows = False
        Me.dgvPrescriptions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.OldLace
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrescriptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrescriptions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Columnname, Me.columnDrug, Me.ColumnDosage, Me.ColumnStatus, Me.ColumnDatesent})
        Me.dgvPrescriptions.EnableHeadersVisualStyles = False
        Me.dgvPrescriptions.Location = New System.Drawing.Point(54, 587)
        Me.dgvPrescriptions.Name = "dgvPrescriptions"
        Me.dgvPrescriptions.ReadOnly = True
        Me.dgvPrescriptions.RowHeadersWidth = 51
        Me.dgvPrescriptions.RowTemplate.Height = 24
        Me.dgvPrescriptions.Size = New System.Drawing.Size(1322, 182)
        Me.dgvPrescriptions.TabIndex = 5
        '
        'Columnname
        '
        Me.Columnname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Columnname.FillWeight = 100.1603!
        Me.Columnname.HeaderText = "Patient's Name"
        Me.Columnname.MinimumWidth = 6
        Me.Columnname.Name = "Columnname"
        Me.Columnname.ReadOnly = True
        Me.Columnname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'columnDrug
        '
        Me.columnDrug.FillWeight = 100.0624!
        Me.columnDrug.HeaderText = "Drug"
        Me.columnDrug.MinimumWidth = 6
        Me.columnDrug.Name = "columnDrug"
        Me.columnDrug.ReadOnly = True
        Me.columnDrug.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnDosage
        '
        Me.ColumnDosage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDosage.FillWeight = 99.98417!
        Me.ColumnDosage.HeaderText = "Dosage Instrustion"
        Me.ColumnDosage.MinimumWidth = 6
        Me.ColumnDosage.Name = "ColumnDosage"
        Me.ColumnDosage.ReadOnly = True
        Me.ColumnDosage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnStatus
        '
        Me.ColumnStatus.FillWeight = 99.9216!
        Me.ColumnStatus.HeaderText = "Status"
        Me.ColumnStatus.MinimumWidth = 6
        Me.ColumnStatus.Name = "ColumnStatus"
        Me.ColumnStatus.ReadOnly = True
        Me.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnDatesent
        '
        Me.ColumnDatesent.FillWeight = 99.87157!
        Me.ColumnDatesent.HeaderText = "Date Sent"
        Me.ColumnDatesent.MinimumWidth = 6
        Me.ColumnDatesent.Name = "ColumnDatesent"
        Me.ColumnDatesent.ReadOnly = True
        Me.ColumnDatesent.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'pnldoctormiddlebar
        '
        Me.pnldoctormiddlebar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnldoctormiddlebar.BackColor = System.Drawing.Color.Turquoise
        Me.pnldoctormiddlebar.Controls.Add(Me.picsentprescription)
        Me.pnldoctormiddlebar.Controls.Add(Me.lblsentheader)
        Me.pnldoctormiddlebar.Location = New System.Drawing.Point(0, 521)
        Me.pnldoctormiddlebar.Name = "pnldoctormiddlebar"
        Me.pnldoctormiddlebar.Size = New System.Drawing.Size(1601, 47)
        Me.pnldoctormiddlebar.TabIndex = 6
        '
        'picsentprescription
        '
        Me.picsentprescription.Image = CType(resources.GetObject("picsentprescription.Image"), System.Drawing.Image)
        Me.picsentprescription.Location = New System.Drawing.Point(12, 4)
        Me.picsentprescription.Name = "picsentprescription"
        Me.picsentprescription.Size = New System.Drawing.Size(46, 37)
        Me.picsentprescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picsentprescription.TabIndex = 8
        Me.picsentprescription.TabStop = False
        '
        'lblsentheader
        '
        Me.lblsentheader.AutoSize = True
        Me.lblsentheader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsentheader.ForeColor = System.Drawing.Color.White
        Me.lblsentheader.Location = New System.Drawing.Point(64, 9)
        Me.lblsentheader.Name = "lblsentheader"
        Me.lblsentheader.Size = New System.Drawing.Size(188, 28)
        Me.lblsentheader.TabIndex = 7
        Me.lblsentheader.Text = "Sent Prescriptions:"
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.BackColor = System.Drawing.Color.Turquoise
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.Location = New System.Drawing.Point(867, 434)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(186, 69)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&CANCEL"
        Me.ttdoctortab.SetToolTip(Me.btncancel, "Cancel Prescriptions")
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'tlsdoctortab
        '
        Me.tlsdoctortab.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsdoctortab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsadd, Me.tlssaveSent, Me.tlscancel})
        Me.tlsdoctortab.Location = New System.Drawing.Point(0, 42)
        Me.tlsdoctortab.Name = "tlsdoctortab"
        Me.tlsdoctortab.Size = New System.Drawing.Size(1482, 27)
        Me.tlsdoctortab.TabIndex = 7
        Me.tlsdoctortab.Text = "ToolStrip1"
        '
        'tlsadd
        '
        Me.tlsadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsadd.Image = CType(resources.GetObject("tlsadd.Image"), System.Drawing.Image)
        Me.tlsadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsadd.Name = "tlsadd"
        Me.tlsadd.Size = New System.Drawing.Size(29, 24)
        Me.tlsadd.Text = "New "
        Me.tlsadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlssaveSent
        '
        Me.tlssaveSent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlssaveSent.Image = CType(resources.GetObject("tlssaveSent.Image"), System.Drawing.Image)
        Me.tlssaveSent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlssaveSent.Name = "tlssaveSent"
        Me.tlssaveSent.Size = New System.Drawing.Size(29, 24)
        Me.tlssaveSent.Text = "Save"
        '
        'tlscancel
        '
        Me.tlscancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlscancel.Image = CType(resources.GetObject("tlscancel.Image"), System.Drawing.Image)
        Me.tlscancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlscancel.Name = "tlscancel"
        Me.tlscancel.Size = New System.Drawing.Size(29, 24)
        Me.tlscancel.Text = "Cancel"
        '
        'epdoctortab
        '
        Me.epdoctortab.ContainerControl = Me
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(24, 273)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(247, 28)
        Me.lblemail.TabIndex = 4
        Me.lblemail.Text = "Doctor's Email(optional):"
        '
        'txtdoctoremail
        '
        Me.txtdoctoremail.Location = New System.Drawing.Point(272, 280)
        Me.txtdoctoremail.Name = "txtdoctoremail"
        Me.txtdoctoremail.Size = New System.Drawing.Size(534, 22)
        Me.txtdoctoremail.TabIndex = 5
        Me.ttdoctortab.SetToolTip(Me.txtdoctoremail, "Please,enter the patient's name")
        '
        'Frmdoctor
        '
        Me.AcceptButton = Me.btnsendtoPharmacist
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(1482, 993)
        Me.Controls.Add(Me.tlsdoctortab)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.pnldoctormiddlebar)
        Me.Controls.Add(Me.dgvPrescriptions)
        Me.Controls.Add(Me.btnsendtoPharmacist)
        Me.Controls.Add(Me.Pnlpriscriptiontab)
        Me.Controls.Add(Me.pnldoctorbuttom)
        Me.Controls.Add(Me.pnldoctorheader)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmdoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmdoctor"
        Me.pnldoctorheader.ResumeLayout(False)
        Me.pnldoctorheader.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnlpriscriptiontab.ResumeLayout(False)
        Me.Pnlpriscriptiontab.PerformLayout()
        CType(Me.dgvPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnldoctormiddlebar.ResumeLayout(False)
        Me.pnldoctormiddlebar.PerformLayout()
        CType(Me.picsentprescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsdoctortab.ResumeLayout(False)
        Me.tlsdoctortab.PerformLayout()
        CType(Me.epdoctortab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnldoctorheader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnldoctorbuttom As Panel
    Friend WithEvents Pnlpriscriptiontab As Panel
    Friend WithEvents lblnotes As Label
    Friend WithEvents lbldosageinstruction As Label
    Friend WithEvents lbldrug As Label
    Friend WithEvents btnsendtoPharmacist As Button
    Friend WithEvents lblpatientname As Label
    Friend WithEvents cmbdrug As ComboBox
    Friend WithEvents txtnotes As TextBox
    Friend WithEvents txtdosageinstruction As TextBox
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents dgvPrescriptions As DataGridView
    Friend WithEvents pnldoctormiddlebar As Panel
    Friend WithEvents picsentprescription As PictureBox
    Friend WithEvents lblsentheader As Label
    Friend WithEvents lbldoctortab As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents ttdoctortab As ToolTip
    Friend WithEvents tlsdoctortab As ToolStrip
    Friend WithEvents tlsadd As ToolStripButton
    Friend WithEvents tlssaveSent As ToolStripButton
    Friend WithEvents tlscancel As ToolStripButton
    Friend WithEvents epdoctortab As ErrorProvider
    Friend WithEvents Columnname As DataGridViewTextBoxColumn
    Friend WithEvents columnDrug As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDosage As DataGridViewTextBoxColumn
    Friend WithEvents ColumnStatus As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDatesent As DataGridViewTextBoxColumn
    Friend WithEvents txtdoctoremail As TextBox
    Friend WithEvents lblemail As Label
End Class
