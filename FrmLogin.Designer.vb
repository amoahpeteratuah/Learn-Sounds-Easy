<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogin))
        Me.Pnllogin = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblforgotpassword = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.piclogin = New System.Windows.Forms.PictureBox()
        Me.eplogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Pnllogin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eplogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnllogin
        '
        Me.Pnllogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnllogin.BackColor = System.Drawing.Color.MistyRose
        Me.Pnllogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnllogin.Controls.Add(Me.btncancel)
        Me.Pnllogin.Controls.Add(Me.lblforgotpassword)
        Me.Pnllogin.Controls.Add(Me.PictureBox2)
        Me.Pnllogin.Controls.Add(Me.btnlogin)
        Me.Pnllogin.Controls.Add(Me.txtpassword)
        Me.Pnllogin.Controls.Add(Me.txtusername)
        Me.Pnllogin.Controls.Add(Me.lblpassword)
        Me.Pnllogin.Controls.Add(Me.Lblusername)
        Me.Pnllogin.Controls.Add(Me.piclogin)
        Me.Pnllogin.Location = New System.Drawing.Point(702, 178)
        Me.Pnllogin.Name = "Pnllogin"
        Me.Pnllogin.Size = New System.Drawing.Size(521, 540)
        Me.Pnllogin.TabIndex = 0
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.No
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Location = New System.Drawing.Point(305, 418)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(119, 40)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "&CANCEL"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lblforgotpassword
        '
        Me.lblforgotpassword.AutoSize = True
        Me.lblforgotpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblforgotpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgotpassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblforgotpassword.Location = New System.Drawing.Point(204, 486)
        Me.lblforgotpassword.Name = "lblforgotpassword"
        Me.lblforgotpassword.Size = New System.Drawing.Size(136, 23)
        Me.lblforgotpassword.TabIndex = 4
        Me.lblforgotpassword.Text = "Forgot password"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(414, 345)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Location = New System.Drawing.Point(90, 418)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(146, 40)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "&LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(208, 342)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(200, 22)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Location = New System.Drawing.Point(208, 267)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(200, 22)
        Me.txtusername.TabIndex = 0
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Image = CType(resources.GetObject("lblpassword.Image"), System.Drawing.Image)
        Me.lblpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblpassword.Location = New System.Drawing.Point(41, 332)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(151, 32)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Password    "
        Me.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusername.Image = CType(resources.GetObject("Lblusername.Image"), System.Drawing.Image)
        Me.Lblusername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Lblusername.Location = New System.Drawing.Point(41, 258)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(161, 32)
        Me.Lblusername.TabIndex = 1
        Me.Lblusername.Text = "UserName    "
        '
        'piclogin
        '
        Me.piclogin.Image = CType(resources.GetObject("piclogin.Image"), System.Drawing.Image)
        Me.piclogin.Location = New System.Drawing.Point(185, 48)
        Me.piclogin.Name = "piclogin"
        Me.piclogin.Size = New System.Drawing.Size(149, 124)
        Me.piclogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogin.TabIndex = 0
        Me.piclogin.TabStop = False
        '
        'eplogin
        '
        Me.eplogin.ContainerControl = Me
        '
        'Frmlogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Pnllogin)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmlogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Pnllogin.ResumeLayout(False)
        Me.Pnllogin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eplogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnllogin As Panel
    Friend WithEvents lblpassword As Label
    Friend WithEvents Lblusername As Label
    Friend WithEvents piclogin As PictureBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblforgotpassword As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents eplogin As ErrorProvider
End Class
