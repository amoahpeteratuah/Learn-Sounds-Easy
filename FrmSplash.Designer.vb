<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmsplash))
        Me.Pbsplash = New System.Windows.Forms.ProgressBar()
        Me.Lblhpims = New System.Windows.Forms.Label()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.Timesplash = New System.Windows.Forms.Timer(Me.components)
        Me.lblsplashmessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Pbsplash
        '
        Me.Pbsplash.Location = New System.Drawing.Point(128, 372)
        Me.Pbsplash.Name = "Pbsplash"
        Me.Pbsplash.Size = New System.Drawing.Size(537, 10)
        Me.Pbsplash.TabIndex = 0
        '
        'Lblhpims
        '
        Me.Lblhpims.AutoSize = True
        Me.Lblhpims.BackColor = System.Drawing.Color.Transparent
        Me.Lblhpims.Font = New System.Drawing.Font("SansSerif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblhpims.ForeColor = System.Drawing.Color.White
        Me.Lblhpims.Location = New System.Drawing.Point(31, 22)
        Me.Lblhpims.Name = "Lblhpims"
        Me.Lblhpims.Size = New System.Drawing.Size(709, 29)
        Me.Lblhpims.TabIndex = 1
        Me.Lblhpims.Text = "HOSPITAL PHARMACY INVENTORY MANAGEMENT SYSTEM"
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.BackColor = System.Drawing.Color.Transparent
        Me.lblversion.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblversion.ForeColor = System.Drawing.Color.White
        Me.lblversion.Location = New System.Drawing.Point(676, 382)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(117, 23)
        Me.lblversion.TabIndex = 2
        Me.lblversion.Text = "Version 1.0"
        '
        'Timesplash
        '
        Me.Timesplash.Enabled = True
        '
        'lblsplashmessage
        '
        Me.lblsplashmessage.AutoSize = True
        Me.lblsplashmessage.BackColor = System.Drawing.Color.Transparent
        Me.lblsplashmessage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsplashmessage.ForeColor = System.Drawing.Color.White
        Me.lblsplashmessage.Location = New System.Drawing.Point(303, 341)
        Me.lblsplashmessage.Name = "lblsplashmessage"
        Me.lblsplashmessage.Size = New System.Drawing.Size(37, 28)
        Me.lblsplashmessage.TabIndex = 3
        Me.lblsplashmessage.Text = "....."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(558, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "©️ 2026 Developer PWGE"
        '
        'Frmsplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblsplashmessage)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.Lblhpims)
        Me.Controls.Add(Me.Pbsplash)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmsplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmmainpage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbsplash As ProgressBar
    Friend WithEvents Lblhpims As Label
    Friend WithEvents lblversion As Label
    Friend WithEvents Timesplash As Timer
    Friend WithEvents lblsplashmessage As Label
    Friend WithEvents Label1 As Label
End Class
