<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmailAd = New System.Windows.Forms.TextBox()
        Me.txtlog = New System.Windows.Forms.Label()
        Me.txtbbxpass = New System.Windows.Forms.TextBox()
        Me.showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.forgotpass = New System.Windows.Forms.LinkLabel()
        Me.signinbtn = New System.Windows.Forms.Button()
        Me.account = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(565, 691)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'EmailAd
        '
        Me.EmailAd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAd.Location = New System.Drawing.Point(638, 223)
        Me.EmailAd.Name = "EmailAd"
        Me.EmailAd.Size = New System.Drawing.Size(270, 31)
        Me.EmailAd.TabIndex = 1
        '
        'txtlog
        '
        Me.txtlog.AutoSize = True
        Me.txtlog.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlog.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtlog.Location = New System.Drawing.Point(629, 155)
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(120, 50)
        Me.txtlog.TabIndex = 3
        Me.txtlog.Text = "Login"
        '
        'txtbbxpass
        '
        Me.txtbbxpass.Location = New System.Drawing.Point(638, 301)
        Me.txtbbxpass.Name = "txtbbxpass"
        Me.txtbbxpass.Size = New System.Drawing.Size(270, 22)
        Me.txtbbxpass.TabIndex = 4
        '
        'showpass
        '
        Me.showpass.AutoSize = True
        Me.showpass.BackColor = System.Drawing.SystemColors.Control
        Me.showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showpass.CheckedState.BorderRadius = 0
        Me.showpass.CheckedState.BorderThickness = 0
        Me.showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showpass.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpass.ForeColor = System.Drawing.Color.SeaGreen
        Me.showpass.Location = New System.Drawing.Point(648, 370)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(151, 27)
        Me.showpass.TabIndex = 5
        Me.showpass.Text = "Show Password"
        Me.showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.showpass.UncheckedState.BorderRadius = 0
        Me.showpass.UncheckedState.BorderThickness = 0
        Me.showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.showpass.UseVisualStyleBackColor = False
        '
        'forgotpass
        '
        Me.forgotpass.ActiveLinkColor = System.Drawing.Color.DarkCyan
        Me.forgotpass.AutoSize = True
        Me.forgotpass.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotpass.LinkColor = System.Drawing.Color.SeaGreen
        Me.forgotpass.Location = New System.Drawing.Point(867, 374)
        Me.forgotpass.Name = "forgotpass"
        Me.forgotpass.Size = New System.Drawing.Size(138, 23)
        Me.forgotpass.TabIndex = 6
        Me.forgotpass.TabStop = True
        Me.forgotpass.Text = "Forgot Password"
        '
        'signinbtn
        '
        Me.signinbtn.BackColor = System.Drawing.Color.SeaGreen
        Me.signinbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signinbtn.ForeColor = System.Drawing.Color.White
        Me.signinbtn.Location = New System.Drawing.Point(713, 498)
        Me.signinbtn.Name = "signinbtn"
        Me.signinbtn.Size = New System.Drawing.Size(214, 44)
        Me.signinbtn.TabIndex = 7
        Me.signinbtn.Text = "Sign In"
        Me.signinbtn.UseVisualStyleBackColor = False
        '
        'account
        '
        Me.account.AutoSize = True
        Me.account.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account.LinkColor = System.Drawing.Color.SeaGreen
        Me.account.Location = New System.Drawing.Point(745, 545)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(150, 23)
        Me.account.TabIndex = 8
        Me.account.TabStop = True
        Me.account.Text = "Create an account"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 688)
        Me.Controls.Add(Me.account)
        Me.Controls.Add(Me.signinbtn)
        Me.Controls.Add(Me.forgotpass)
        Me.Controls.Add(Me.showpass)
        Me.Controls.Add(Me.txtbbxpass)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.EmailAd)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmailAd As TextBox
    Friend WithEvents txtlog As Label
    Friend WithEvents txtbbxpass As TextBox
    Friend WithEvents showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents forgotpass As LinkLabel
    Friend WithEvents signinbtn As Button
    Friend WithEvents account As LinkLabel
End Class
