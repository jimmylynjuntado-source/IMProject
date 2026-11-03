Imports System.Drawing.Drawing2D
Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleRoundedTextBox(EmailAd, "Email Address")
        StyleRoundedTextBox(txtbbxpass, "Password")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dock = DockStyle.Fill
    End Sub

    Private Sub StyleRoundedTextBox(tb As TextBox, placeholder As String,
                                    Optional radius As Integer = 10,
                                    Optional height As Integer = 48)

        Dim borderColor As Color = Color.FromArgb(217, 217, 217)
        Dim focusColor As Color = Color.FromArgb(119, 204, 58)
        Dim focused As Boolean = False

        ' Panel that carries the rounded border, placed exactly where the textbox is
        Dim host As New Panel()
        host.Location = tb.Location
        host.Size = New Size(tb.Width + 80, height)
        host.Anchor = tb.Anchor
        host.BackColor = Color.White
        host.Name = tb.Name & "_Host"

        ' Reparent the textbox into the panel
        Dim parentCtl As Control = tb.Parent
        parentCtl.Controls.Add(host)
        host.Controls.Add(tb)
        host.BringToFront()

        ' Borderless textbox, vertically centered
        tb.BorderStyle = BorderStyle.None
        tb.BackColor = Color.White
        tb.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        tb.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        tb.Width = host.Width - 32
        tb.Location = New Point(16, (host.Height - tb.Height) \ 2)

        ' Placeholder: a gray label sitting on top of the textbox
        Dim hint As New Label()
        hint.Text = placeholder
        hint.AutoSize = True
        hint.Font = tb.Font
        hint.ForeColor = Color.FromArgb(150, 150, 150)
        hint.BackColor = Color.White
        hint.Cursor = Cursors.IBeam
        hint.Location = New Point(tb.Left + 1, (host.Height - hint.PreferredHeight) \ 2)
        host.Controls.Add(hint)
        hint.BringToFront()
        hint.Visible = (tb.Text.Length = 0)

        AddHandler hint.Click, Sub() tb.Focus()
        AddHandler tb.TextChanged, Sub() hint.Visible = (tb.Text.Length = 0)

        ' Smooth rounded border
        AddHandler host.Paint,
            Sub(s, pe)
                Dim g As Graphics = pe.Graphics
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.Clear(parentCtl.BackColor)

                Dim r As New RectangleF(0.5F, 0.5F, host.Width - 2, host.Height - 2)
                Dim d As Single = radius * 2
                Using path As New GraphicsPath()
                    path.AddArc(r.X, r.Y, d, d, 180, 90)
                    path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
                    path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
                    path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
                    path.CloseFigure()
                    Using br As New SolidBrush(Color.White)
                        g.FillPath(br, path)
                    End Using
                    Using pen As New Pen(If(focused, focusColor, borderColor), 1.0F)
                        g.DrawPath(pen, path)
                    End Using
                End Using
            End Sub

        ' Redraw on resize, focus ring on enter/leave, click padding to focus
        AddHandler host.Resize, Sub() host.Invalidate()
        AddHandler host.MouseDown, Sub() tb.Focus()
        AddHandler tb.Enter, Sub()
                                 focused = True
                                 host.Invalidate()
                             End Sub
        AddHandler tb.Leave, Sub()
                                 focused = False
                                 host.Invalidate()
                             End Sub

    End Sub


End Class
