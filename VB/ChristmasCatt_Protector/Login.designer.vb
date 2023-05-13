Namespace KeyAuth
	' Token: 0x02000002 RID: 2
	Partial Public Class Login
		Inherits System.Windows.Forms.Form

		' Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
			If flag Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.siticoneControlBox1 = New Siticone.UI.WinForms.SiticoneControlBox()
			Me.siticoneControlBox2 = New Siticone.UI.WinForms.SiticoneControlBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.LoginBtn = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.username = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.password = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.RgstrBtn = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.status = New Siticone.UI.WinForms.SiticoneLabel()
			Me.siticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()
			Me.key = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.siticoneRoundedTextBox1 = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.siticoneRoundedTextBox2 = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.label9 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' siticoneControlBox1
			' 
			Me.siticoneControlBox1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.siticoneControlBox1.BorderRadius = 10
			Me.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(232)))), (CInt((CByte(17)))), (CInt((CByte(35)))))
			Me.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White
			Me.siticoneControlBox1.HoveredState.Parent = Me.siticoneControlBox1
			Me.siticoneControlBox1.IconColor = System.Drawing.Color.White
			Me.siticoneControlBox1.Location = New System.Drawing.Point(636, 4)
			Me.siticoneControlBox1.Name = "siticoneControlBox1"
			Me.siticoneControlBox1.ShadowDecoration.Parent = Me.siticoneControlBox1
			Me.siticoneControlBox1.Size = New System.Drawing.Size(45, 29)
			Me.siticoneControlBox1.TabIndex = 1
'			Me.siticoneControlBox1.Click += New System.EventHandler(Me.siticoneControlBox1_Click)
			' 
			' siticoneControlBox2
			' 
			Me.siticoneControlBox2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.siticoneControlBox2.BorderRadius = 10
			Me.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox
			Me.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.siticoneControlBox2.HoveredState.Parent = Me.siticoneControlBox2
			Me.siticoneControlBox2.IconColor = System.Drawing.Color.White
			Me.siticoneControlBox2.Location = New System.Drawing.Point(591, 4)
			Me.siticoneControlBox2.Name = "siticoneControlBox2"
			Me.siticoneControlBox2.ShadowDecoration.Parent = Me.siticoneControlBox2
			Me.siticoneControlBox2.Size = New System.Drawing.Size(45, 29)
			Me.siticoneControlBox2.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI Light", 10F)
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(-1, 136)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(0, 19)
			Me.label1.TabIndex = 22
			' 
			' LoginBtn
			' 
			Me.LoginBtn.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.LoginBtn.BorderThickness = 1
			Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
			Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
			Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.LoginBtn.ForeColor = System.Drawing.Color.White
			Me.LoginBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.LoginBtn.HoveredState.Parent = Me.LoginBtn
			Me.LoginBtn.Location = New System.Drawing.Point(423, 153)
			Me.LoginBtn.Name = "LoginBtn"
			Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
			Me.LoginBtn.Size = New System.Drawing.Size(151, 27)
			Me.LoginBtn.TabIndex = 26
			Me.LoginBtn.Text = "Login"
'			Me.LoginBtn.Click += New System.EventHandler(Me.LoginBtn_Click)
			' 
			' username
			' 
			Me.username.AllowDrop = True
			Me.username.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.username.DefaultText = "Username"
			Me.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.username.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.username.DisabledState.Parent = Me.username
			Me.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.username.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.username.FocusedState.Parent = Me.username
			Me.username.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.username.HoveredState.Parent = Me.username
			Me.username.Location = New System.Drawing.Point(383, 51)
			Me.username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.username.Name = "username"
			Me.username.PasswordChar = ControlChars.NullChar
			Me.username.PlaceholderText = ""
			Me.username.SelectedText = ""
			Me.username.ShadowDecoration.Parent = Me.username
			Me.username.Size = New System.Drawing.Size(236, 30)
			Me.username.TabIndex = 33
			Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' password
			' 
			Me.password.AllowDrop = True
			Me.password.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.password.DefaultText = "Password"
			Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.password.DisabledState.Parent = Me.password
			Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.password.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.password.FocusedState.Parent = Me.password
			Me.password.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.password.HoveredState.Parent = Me.password
			Me.password.Location = New System.Drawing.Point(383, 84)
			Me.password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.password.Name = "password"
			Me.password.PasswordChar = ControlChars.NullChar
			Me.password.PlaceholderText = ""
			Me.password.SelectedText = ""
			Me.password.ShadowDecoration.Parent = Me.password
			Me.password.Size = New System.Drawing.Size(236, 30)
			Me.password.TabIndex = 34
			Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' RgstrBtn
			' 
			Me.RgstrBtn.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.RgstrBtn.BorderThickness = 1
			Me.RgstrBtn.CheckedState.Parent = Me.RgstrBtn
			Me.RgstrBtn.CustomImages.Parent = Me.RgstrBtn
			Me.RgstrBtn.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.RgstrBtn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.RgstrBtn.ForeColor = System.Drawing.Color.White
			Me.RgstrBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.RgstrBtn.HoveredState.Parent = Me.RgstrBtn
			Me.RgstrBtn.Location = New System.Drawing.Point(104, 153)
			Me.RgstrBtn.Name = "RgstrBtn"
			Me.RgstrBtn.ShadowDecoration.Parent = Me.RgstrBtn
			Me.RgstrBtn.Size = New System.Drawing.Size(153, 27)
			Me.RgstrBtn.TabIndex = 35
			Me.RgstrBtn.Text = "Register"
'			Me.RgstrBtn.Click += New System.EventHandler(Me.RgstrBtn_Click)
			' 
			' status
			' 
			Me.status.AutoSize = False
			Me.status.BackColor = System.Drawing.Color.Transparent
			Me.status.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.status.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.status.Location = New System.Drawing.Point(0, 278)
			Me.status.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.status.Name = "status"
			Me.status.Size = New System.Drawing.Size(686, 53)
			Me.status.TabIndex = 38
			Me.status.Text = "Status: Awaiting login"
			Me.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' siticoneLabel1
			' 
			Me.siticoneLabel1.AutoSize = False
			Me.siticoneLabel1.BackColor = System.Drawing.Color.Transparent
			Me.siticoneLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.siticoneLabel1.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
			Me.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.siticoneLabel1.Location = New System.Drawing.Point(0, 225)
			Me.siticoneLabel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.siticoneLabel1.Name = "siticoneLabel1"
			Me.siticoneLabel1.Size = New System.Drawing.Size(686, 53)
			Me.siticoneLabel1.TabIndex = 39
			Me.siticoneLabel1.Text = "Current Session Validation Status: " & ControlChars.CrLf
			Me.siticoneLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' key
			' 
			Me.key.AllowDrop = True
			Me.key.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.key.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.key.DefaultText = "Key"
			Me.key.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.key.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.key.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.key.DisabledState.Parent = Me.key
			Me.key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.key.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.key.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.key.FocusedState.Parent = Me.key
			Me.key.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.key.HoveredState.Parent = Me.key
			Me.key.Location = New System.Drawing.Point(66, 116)
			Me.key.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.key.Name = "key"
			Me.key.PasswordChar = ControlChars.NullChar
			Me.key.PlaceholderText = ""
			Me.key.SelectedText = ""
			Me.key.ShadowDecoration.Parent = Me.key
			Me.key.Size = New System.Drawing.Size(236, 30)
			Me.key.TabIndex = 40
			Me.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' siticoneRoundedTextBox1
			' 
			Me.siticoneRoundedTextBox1.AllowDrop = True
			Me.siticoneRoundedTextBox1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.siticoneRoundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.siticoneRoundedTextBox1.DefaultText = "Username"
			Me.siticoneRoundedTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.siticoneRoundedTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.siticoneRoundedTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.siticoneRoundedTextBox1.DisabledState.Parent = Me.siticoneRoundedTextBox1
			Me.siticoneRoundedTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.siticoneRoundedTextBox1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.siticoneRoundedTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.siticoneRoundedTextBox1.FocusedState.Parent = Me.siticoneRoundedTextBox1
			Me.siticoneRoundedTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.siticoneRoundedTextBox1.HoveredState.Parent = Me.siticoneRoundedTextBox1
			Me.siticoneRoundedTextBox1.Location = New System.Drawing.Point(66, 51)
			Me.siticoneRoundedTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.siticoneRoundedTextBox1.Name = "siticoneRoundedTextBox1"
			Me.siticoneRoundedTextBox1.PasswordChar = ControlChars.NullChar
			Me.siticoneRoundedTextBox1.PlaceholderText = ""
			Me.siticoneRoundedTextBox1.SelectedText = ""
			Me.siticoneRoundedTextBox1.ShadowDecoration.Parent = Me.siticoneRoundedTextBox1
			Me.siticoneRoundedTextBox1.Size = New System.Drawing.Size(236, 30)
			Me.siticoneRoundedTextBox1.TabIndex = 41
			Me.siticoneRoundedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' siticoneRoundedTextBox2
			' 
			Me.siticoneRoundedTextBox2.AllowDrop = True
			Me.siticoneRoundedTextBox2.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.siticoneRoundedTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.siticoneRoundedTextBox2.DefaultText = "Password"
			Me.siticoneRoundedTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.siticoneRoundedTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.siticoneRoundedTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.siticoneRoundedTextBox2.DisabledState.Parent = Me.siticoneRoundedTextBox2
			Me.siticoneRoundedTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.siticoneRoundedTextBox2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.siticoneRoundedTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.siticoneRoundedTextBox2.FocusedState.Parent = Me.siticoneRoundedTextBox2
			Me.siticoneRoundedTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.siticoneRoundedTextBox2.HoveredState.Parent = Me.siticoneRoundedTextBox2
			Me.siticoneRoundedTextBox2.Location = New System.Drawing.Point(66, 84)
			Me.siticoneRoundedTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.siticoneRoundedTextBox2.Name = "siticoneRoundedTextBox2"
			Me.siticoneRoundedTextBox2.PasswordChar = ControlChars.NullChar
			Me.siticoneRoundedTextBox2.PlaceholderText = ""
			Me.siticoneRoundedTextBox2.SelectedText = ""
			Me.siticoneRoundedTextBox2.ShadowDecoration.Parent = Me.siticoneRoundedTextBox2
			Me.siticoneRoundedTextBox2.Size = New System.Drawing.Size(236, 30)
			Me.siticoneRoundedTextBox2.TabIndex = 42
			Me.siticoneRoundedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.SystemColors.ButtonFace
			Me.label3.Location = New System.Drawing.Point(390, 28)
			Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(44, 19)
			Me.label3.TabIndex = 43
			Me.label3.Text = "Login"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.ForeColor = System.Drawing.SystemColors.ButtonFace
			Me.label4.Location = New System.Drawing.Point(74, 28)
			Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(60, 19)
			Me.label4.TabIndex = 44
			Me.label4.Text = "Register"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.DodgerBlue
			Me.label2.Location = New System.Drawing.Point(390, 118)
			Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(221, 19)
			Me.label2.TabIndex = 45
			Me.label2.Text = "https://github.com/ChristmasCatt"
'			Me.label2.Click += New System.EventHandler(Me.label2_Click)
			' 
			' guna2BorderlessForm1
			' 
			Me.guna2BorderlessForm1.AnimateWindow = True
			Me.guna2BorderlessForm1.ContainerControl = Me
			Me.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
			Me.guna2BorderlessForm1.TransparentWhileDrag = True
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.ForeColor = System.Drawing.Color.DodgerBlue
			Me.label9.Location = New System.Drawing.Point(553, 303)
			Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(128, 19)
			Me.label9.TabIndex = 49
			Me.label9.Text = "https://keyauth.cc/"
'			Me.label9.Click += New System.EventHandler(Me.label9_Click)
			' 
			' Login
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.ClientSize = New System.Drawing.Size(686, 331)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.siticoneRoundedTextBox2)
			Me.Controls.Add(Me.siticoneRoundedTextBox1)
			Me.Controls.Add(Me.key)
			Me.Controls.Add(Me.siticoneLabel1)
			Me.Controls.Add(Me.status)
			Me.Controls.Add(Me.RgstrBtn)
			Me.Controls.Add(Me.password)
			Me.Controls.Add(Me.username)
			Me.Controls.Add(Me.LoginBtn)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.siticoneControlBox2)
			Me.Controls.Add(Me.siticoneControlBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Login"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Loader"
			Me.TransparencyKey = System.Drawing.Color.Maroon
'			Me.Load += New System.EventHandler(Me.Login_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		' Token: 0x04000001 RID: 1
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000004 RID: 4
		Private WithEvents siticoneControlBox1 As Global.Siticone.UI.WinForms.SiticoneControlBox

		' Token: 0x04000005 RID: 5
		Private siticoneControlBox2 As Global.Siticone.UI.WinForms.SiticoneControlBox

		' Token: 0x0400000A RID: 10
		Private label1 As Global.System.Windows.Forms.Label
		Private WithEvents LoginBtn As Siticone.UI.WinForms.SiticoneRoundedButton
		Private password As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private username As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private WithEvents RgstrBtn As Siticone.UI.WinForms.SiticoneRoundedButton
		Private status As Siticone.UI.WinForms.SiticoneLabel
		Private siticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
		Private key As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private siticoneRoundedTextBox2 As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private siticoneRoundedTextBox1 As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents label2 As System.Windows.Forms.Label
		Private guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
		Private WithEvents label9 As System.Windows.Forms.Label
	End Class
End Namespace
