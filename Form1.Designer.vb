<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogic))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Piceyeview = New System.Windows.Forms.PictureBox()
        Me.Labpassword = New System.Windows.Forms.Label()
        Me.Labusername = New System.Windows.Forms.Label()
        Me.Picpassword = New System.Windows.Forms.PictureBox()
        Me.PicuserName = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Labforget = New System.Windows.Forms.Label()
        Me.Cheboxrememberme = New System.Windows.Forms.CheckBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.Piceyeview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picpassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicuserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Piceyeview)
        Me.Panel2.Controls.Add(Me.Labpassword)
        Me.Panel2.Controls.Add(Me.Labusername)
        Me.Panel2.Controls.Add(Me.Picpassword)
        Me.Panel2.Controls.Add(Me.PicuserName)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Labforget)
        Me.Panel2.Controls.Add(Me.Cheboxrememberme)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.txtuserName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1007, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(543, 544)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(248, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Click to Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(164, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "New Here"
        '
        'Piceyeview
        '
        Me.Piceyeview.BackColor = System.Drawing.Color.Gold
        Me.Piceyeview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Piceyeview.Image = CType(resources.GetObject("Piceyeview.Image"), System.Drawing.Image)
        Me.Piceyeview.Location = New System.Drawing.Point(357, 234)
        Me.Piceyeview.Name = "Piceyeview"
        Me.Piceyeview.Size = New System.Drawing.Size(20, 23)
        Me.Piceyeview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Piceyeview.TabIndex = 10
        Me.Piceyeview.TabStop = False
        '
        'Labpassword
        '
        Me.Labpassword.AutoSize = True
        Me.Labpassword.BackColor = System.Drawing.Color.White
        Me.Labpassword.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labpassword.ForeColor = System.Drawing.Color.Gray
        Me.Labpassword.Location = New System.Drawing.Point(165, 237)
        Me.Labpassword.Name = "Labpassword"
        Me.Labpassword.Size = New System.Drawing.Size(68, 17)
        Me.Labpassword.TabIndex = 9
        Me.Labpassword.Text = "Password"
        '
        'Labusername
        '
        Me.Labusername.AutoSize = True
        Me.Labusername.BackColor = System.Drawing.Color.White
        Me.Labusername.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labusername.ForeColor = System.Drawing.Color.Gray
        Me.Labusername.Location = New System.Drawing.Point(165, 154)
        Me.Labusername.Name = "Labusername"
        Me.Labusername.Size = New System.Drawing.Size(71, 17)
        Me.Labusername.TabIndex = 8
        Me.Labusername.Text = "Username"
        '
        'Picpassword
        '
        Me.Picpassword.BackColor = System.Drawing.Color.Gold
        Me.Picpassword.Image = CType(resources.GetObject("Picpassword.Image"), System.Drawing.Image)
        Me.Picpassword.Location = New System.Drawing.Point(116, 234)
        Me.Picpassword.Name = "Picpassword"
        Me.Picpassword.Size = New System.Drawing.Size(20, 23)
        Me.Picpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picpassword.TabIndex = 7
        Me.Picpassword.TabStop = False
        '
        'PicuserName
        '
        Me.PicuserName.BackColor = System.Drawing.Color.Gold
        Me.PicuserName.Image = CType(resources.GetObject("PicuserName.Image"), System.Drawing.Image)
        Me.PicuserName.Location = New System.Drawing.Point(116, 150)
        Me.PicuserName.Name = "PicuserName"
        Me.PicuserName.Size = New System.Drawing.Size(20, 23)
        Me.PicuserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicuserName.TabIndex = 6
        Me.PicuserName.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(139, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Labforget
        '
        Me.Labforget.AutoSize = True
        Me.Labforget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Labforget.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labforget.ForeColor = System.Drawing.Color.Gold
        Me.Labforget.Location = New System.Drawing.Point(261, 287)
        Me.Labforget.Name = "Labforget"
        Me.Labforget.Size = New System.Drawing.Size(121, 19)
        Me.Labforget.TabIndex = 4
        Me.Labforget.Text = "Forget password"
        '
        'Cheboxrememberme
        '
        Me.Cheboxrememberme.AutoSize = True
        Me.Cheboxrememberme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cheboxrememberme.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cheboxrememberme.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cheboxrememberme.Location = New System.Drawing.Point(95, 289)
        Me.Cheboxrememberme.Name = "Cheboxrememberme"
        Me.Cheboxrememberme.Size = New System.Drawing.Size(131, 23)
        Me.Cheboxrememberme.TabIndex = 3
        Me.Cheboxrememberme.Text = "Remember me"
        Me.Cheboxrememberme.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(139, 234)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(214, 22)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtuserName
        '
        Me.txtuserName.Location = New System.Drawing.Point(139, 151)
        Me.txtuserName.Name = "txtuserName"
        Me.txtuserName.Size = New System.Drawing.Size(214, 22)
        Me.txtuserName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(228, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(365, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(603, 544)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmLogic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1033)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "frmLogic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Piceyeview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picpassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicuserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Labforget As Label
    Friend WithEvents Cheboxrememberme As CheckBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtuserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Picpassword As PictureBox
    Friend WithEvents PicuserName As PictureBox
    Friend WithEvents Labusername As Label
    Friend WithEvents Labpassword As Label
    Friend WithEvents Piceyeview As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
