Namespace random_Project_IdeA
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.txtOpenFile = New Guna.UI2.WinForms.Guna2TextBox()
			Me.CheckBox_String_Encryption = New Guna.UI2.WinForms.Guna2CustomCheckBox()
			Me.txtFileName = New Guna.UI2.WinForms.Guna2TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.Int_Encoding = New Guna.UI2.WinForms.Guna2CustomCheckBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.Rename_CheckBox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.Junk_CheckBox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
			Me.Number_Of_Junk = New Guna.UI2.WinForms.Guna2TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
			Me.MinimizeButton = New Guna.UI2.WinForms.Guna2Button()
			Me.guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.label8 = New System.Windows.Forms.Label()
			Me.OpenFile_Button = New Guna.UI2.WinForms.Guna2Button()
			Me.Protect = New Guna.UI2.WinForms.Guna2Button()
			Me.guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
			Me.label9 = New System.Windows.Forms.Label()
			DirectCast(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' txtOpenFile
			' 
			Me.txtOpenFile.BackColor = System.Drawing.Color.Transparent
			Me.txtOpenFile.BorderColor = System.Drawing.Color.Black
			Me.txtOpenFile.BorderThickness = 2
			Me.txtOpenFile.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.txtOpenFile.DefaultText = ""
			Me.txtOpenFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.txtOpenFile.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.txtOpenFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.txtOpenFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.txtOpenFile.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.txtOpenFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.txtOpenFile.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.txtOpenFile.HoverState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.txtOpenFile.Location = New System.Drawing.Point(98, 162)
			Me.txtOpenFile.Name = "txtOpenFile"
			Me.txtOpenFile.PasswordChar = ControlChars.NullChar
			Me.txtOpenFile.PlaceholderForeColor = System.Drawing.Color.Black
			Me.txtOpenFile.PlaceholderText = ""
			Me.txtOpenFile.SelectedText = ""
			Me.txtOpenFile.Size = New System.Drawing.Size(339, 32)
			Me.txtOpenFile.TabIndex = 1
			' 
			' CheckBox_String_Encryption
			' 
			Me.CheckBox_String_Encryption.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.CheckBox_String_Encryption.CheckedState.BorderRadius = 2
			Me.CheckBox_String_Encryption.CheckedState.BorderThickness = 0
			Me.CheckBox_String_Encryption.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.CheckBox_String_Encryption.Location = New System.Drawing.Point(8, 20)
			Me.CheckBox_String_Encryption.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.CheckBox_String_Encryption.Name = "CheckBox_String_Encryption"
			Me.CheckBox_String_Encryption.Size = New System.Drawing.Size(24, 22)
			Me.CheckBox_String_Encryption.TabIndex = 2
			Me.CheckBox_String_Encryption.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.CheckBox_String_Encryption.UncheckedState.BorderRadius = 2
			Me.CheckBox_String_Encryption.UncheckedState.BorderThickness = 0
			Me.CheckBox_String_Encryption.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
'			Me.CheckBox_String_Encryption.CheckedChanged += New System.EventHandler(Me.CheckBox_String_Encryption_CheckedChanged)
			' 
			' txtFileName
			' 
			Me.txtFileName.BackColor = System.Drawing.Color.Transparent
			Me.txtFileName.BorderColor = System.Drawing.Color.Black
			Me.txtFileName.BorderThickness = 2
			Me.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.txtFileName.DefaultText = ""
			Me.txtFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.txtFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.txtFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.txtFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.txtFileName.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.txtFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.txtFileName.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.txtFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.txtFileName.Location = New System.Drawing.Point(98, 201)
			Me.txtFileName.Name = "txtFileName"
			Me.txtFileName.PasswordChar = ControlChars.NullChar
			Me.txtFileName.PlaceholderForeColor = System.Drawing.Color.Black
			Me.txtFileName.PlaceholderText = ""
			Me.txtFileName.SelectedText = ""
			Me.txtFileName.Size = New System.Drawing.Size(339, 32)
			Me.txtFileName.TabIndex = 4
'			Me.txtFileName.TextChanged += New System.EventHandler(Me.guna2TextBox1_TextChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(37, 20)
			Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(144, 21)
			Me.label1.TabIndex = 8
			Me.label1.Text = "String Encryption"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.label2.ForeColor = System.Drawing.Color.Gray
			Me.label2.Location = New System.Drawing.Point(4, 162)
			Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(95, 21)
			Me.label2.TabIndex = 9
			Me.label2.Text = "Assembly : "
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.label3.ForeColor = System.Drawing.Color.Gray
			Me.label3.Location = New System.Drawing.Point(4, 201)
			Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(95, 21)
			Me.label3.TabIndex = 10
			Me.label3.Text = "File Name :"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.label4.ForeColor = System.Drawing.Color.White
			Me.label4.Location = New System.Drawing.Point(214, 20)
			Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(113, 21)
			Me.label4.TabIndex = 12
			Me.label4.Text = "Int Confusion"
			' 
			' Int_Encoding
			' 
			Me.Int_Encoding.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Int_Encoding.CheckedState.BorderRadius = 2
			Me.Int_Encoding.CheckedState.BorderThickness = 0
			Me.Int_Encoding.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Int_Encoding.Location = New System.Drawing.Point(186, 20)
			Me.Int_Encoding.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Int_Encoding.Name = "Int_Encoding"
			Me.Int_Encoding.Size = New System.Drawing.Size(24, 22)
			Me.Int_Encoding.TabIndex = 11
			Me.Int_Encoding.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.Int_Encoding.UncheckedState.BorderRadius = 2
			Me.Int_Encoding.UncheckedState.BorderThickness = 0
			Me.Int_Encoding.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
'			Me.Int_Encoding.Click += New System.EventHandler(Me.Int_Encoding_Click)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.label5.ForeColor = System.Drawing.Color.White
			Me.label5.Location = New System.Drawing.Point(363, 19)
			Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(78, 21)
			Me.label5.TabIndex = 14
			Me.label5.Text = "Renamer"
			' 
			' Rename_CheckBox
			' 
			Me.Rename_CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Rename_CheckBox.CheckedState.BorderRadius = 2
			Me.Rename_CheckBox.CheckedState.BorderThickness = 0
			Me.Rename_CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Rename_CheckBox.Location = New System.Drawing.Point(334, 19)
			Me.Rename_CheckBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Rename_CheckBox.Name = "Rename_CheckBox"
			Me.Rename_CheckBox.Size = New System.Drawing.Size(24, 22)
			Me.Rename_CheckBox.TabIndex = 13
			Me.Rename_CheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.Rename_CheckBox.UncheckedState.BorderRadius = 2
			Me.Rename_CheckBox.UncheckedState.BorderThickness = 0
			Me.Rename_CheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
'			Me.Rename_CheckBox.Click += New System.EventHandler(Me.Rename_CheckBox_Click)
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.label6.ForeColor = System.Drawing.Color.White
			Me.label6.Location = New System.Drawing.Point(474, 20)
			Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(123, 21)
			Me.label6.TabIndex = 16
			Me.label6.Text = "Junk Spammer"
			' 
			' Junk_CheckBox
			' 
			Me.Junk_CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Junk_CheckBox.CheckedState.BorderRadius = 2
			Me.Junk_CheckBox.CheckedState.BorderThickness = 0
			Me.Junk_CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Junk_CheckBox.Location = New System.Drawing.Point(446, 20)
			Me.Junk_CheckBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Junk_CheckBox.Name = "Junk_CheckBox"
			Me.Junk_CheckBox.Size = New System.Drawing.Size(24, 22)
			Me.Junk_CheckBox.TabIndex = 15
			Me.Junk_CheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.Junk_CheckBox.UncheckedState.BorderRadius = 2
			Me.Junk_CheckBox.UncheckedState.BorderThickness = 0
			Me.Junk_CheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
'			Me.Junk_CheckBox.Click += New System.EventHandler(Me.Junk_CheckBox_Click)
			' 
			' Number_Of_Junk
			' 
			Me.Number_Of_Junk.BackColor = System.Drawing.Color.Transparent
			Me.Number_Of_Junk.BorderColor = System.Drawing.Color.Black
			Me.Number_Of_Junk.BorderThickness = 2
			Me.Number_Of_Junk.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.Number_Of_Junk.DefaultText = "50"
			Me.Number_Of_Junk.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.Number_Of_Junk.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.Number_Of_Junk.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.Number_Of_Junk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.Number_Of_Junk.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.Number_Of_Junk.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Number_Of_Junk.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.Number_Of_Junk.ForeColor = System.Drawing.Color.White
			Me.Number_Of_Junk.HoverState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.Number_Of_Junk.Location = New System.Drawing.Point(497, 83)
			Me.Number_Of_Junk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Number_Of_Junk.Name = "Number_Of_Junk"
			Me.Number_Of_Junk.PasswordChar = ControlChars.NullChar
			Me.Number_Of_Junk.PlaceholderForeColor = System.Drawing.Color.Black
			Me.Number_Of_Junk.PlaceholderText = ""
			Me.Number_Of_Junk.SelectedText = ""
			Me.Number_Of_Junk.Size = New System.Drawing.Size(62, 34)
			Me.Number_Of_Junk.TabIndex = 17
			Me.Number_Of_Junk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.ForeColor = System.Drawing.Color.Gray
			Me.label7.Location = New System.Drawing.Point(481, 62)
			Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(102, 15)
			Me.label7.TabIndex = 18
			Me.label7.Text = "Number Of Junk:"
			' 
			' ExitButton
			' 
			Me.ExitButton.Animated = True
			Me.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.ExitButton.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.ExitButton.ForeColor = System.Drawing.Color.White
			Me.ExitButton.Location = New System.Drawing.Point(646, 10)
			Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.ExitButton.Name = "ExitButton"
			Me.ExitButton.Size = New System.Drawing.Size(32, 22)
			Me.ExitButton.TabIndex = 19
			Me.ExitButton.Text = "X"
			Me.ExitButton.TextOffset = New System.Drawing.Point(1, -3)
'			Me.ExitButton.Click += New System.EventHandler(Me.ExitButton_Click)
			' 
			' MinimizeButton
			' 
			Me.MinimizeButton.Animated = True
			Me.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
			Me.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
			Me.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
			Me.MinimizeButton.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.MinimizeButton.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.MinimizeButton.ForeColor = System.Drawing.Color.White
			Me.MinimizeButton.Location = New System.Drawing.Point(610, 10)
			Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.MinimizeButton.Name = "MinimizeButton"
			Me.MinimizeButton.Size = New System.Drawing.Size(32, 22)
			Me.MinimizeButton.TabIndex = 20
			Me.MinimizeButton.Text = "-"
			Me.MinimizeButton.TextOffset = New System.Drawing.Point(1, -3)
'			Me.MinimizeButton.Click += New System.EventHandler(Me.MinimizeButton_Click)
			' 
			' guna2BorderlessForm1
			' 
			Me.guna2BorderlessForm1.AnimateWindow = True
			Me.guna2BorderlessForm1.ContainerControl = Me
			Me.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
			Me.guna2BorderlessForm1.TransparentWhileDrag = True
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.ForeColor = System.Drawing.Color.DodgerBlue
			Me.label8.Location = New System.Drawing.Point(150, 236)
			Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(221, 19)
			Me.label8.TabIndex = 46
			Me.label8.Text = "https://github.com/ChristmasCatt"
'			Me.label8.Click += New System.EventHandler(Me.label8_Click)
			' 
			' OpenFile_Button
			' 
			Me.OpenFile_Button.Animated = True
			Me.OpenFile_Button.AutoRoundedCorners = True
			Me.OpenFile_Button.BackColor = System.Drawing.Color.Transparent
			Me.OpenFile_Button.BorderRadius = 16
			Me.OpenFile_Button.BorderThickness = 2
			Me.OpenFile_Button.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.OpenFile_Button.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.OpenFile_Button.ForeColor = System.Drawing.Color.White
			Me.OpenFile_Button.Image = My.Resources.folder
			Me.OpenFile_Button.ImageOffset = New System.Drawing.Point(-3, 0)
			Me.OpenFile_Button.ImageSize = New System.Drawing.Size(27, 27)
			Me.OpenFile_Button.Location = New System.Drawing.Point(442, 162)
			Me.OpenFile_Button.Margin = New System.Windows.Forms.Padding(2)
			Me.OpenFile_Button.Name = "OpenFile_Button"
			Me.OpenFile_Button.Size = New System.Drawing.Size(116, 34)
			Me.OpenFile_Button.TabIndex = 5
			Me.OpenFile_Button.Text = "Open File"
			Me.OpenFile_Button.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
'			Me.OpenFile_Button.Click += New System.EventHandler(Me.guna2Button1_Click)
			' 
			' Protect
			' 
			Me.Protect.Animated = True
			Me.Protect.AutoRoundedCorners = True
			Me.Protect.BackColor = System.Drawing.Color.Transparent
			Me.Protect.BorderRadius = 16
			Me.Protect.BorderThickness = 2
			Me.Protect.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(25)))), (CInt((CByte(25)))), (CInt((CByte(25)))))
			Me.Protect.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
			Me.Protect.ForeColor = System.Drawing.Color.White
			Me.Protect.Image = My.Resources.shield
			Me.Protect.ImageOffset = New System.Drawing.Point(-5, 0)
			Me.Protect.ImageSize = New System.Drawing.Size(27, 27)
			Me.Protect.Location = New System.Drawing.Point(562, 162)
			Me.Protect.Margin = New System.Windows.Forms.Padding(2)
			Me.Protect.Name = "Protect"
			Me.Protect.Size = New System.Drawing.Size(116, 34)
			Me.Protect.TabIndex = 0
			Me.Protect.Text = "Protect"
			Me.Protect.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
'			Me.Protect.Click += New System.EventHandler(Me.Protect_Click)
			' 
			' guna2PictureBox1
			' 
			Me.guna2PictureBox1.Image = My.Resources.Creator
			Me.guna2PictureBox1.ImageRotate = 0F
			Me.guna2PictureBox1.Location = New System.Drawing.Point(8, 59)
			Me.guna2PictureBox1.Name = "guna2PictureBox1"
			Me.guna2PictureBox1.Size = New System.Drawing.Size(462, 97)
			Me.guna2PictureBox1.TabIndex = 47
			Me.guna2PictureBox1.TabStop = False
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.ForeColor = System.Drawing.Color.DodgerBlue
			Me.label9.Location = New System.Drawing.Point(150, 255)
			Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(128, 19)
			Me.label9.TabIndex = 48
			Me.label9.Text = "https://keyauth.cc/"
'			Me.label9.Click += New System.EventHandler(Me.label9_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(17)))), (CInt((CByte(17)))))
			Me.ClientSize = New System.Drawing.Size(686, 299)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.guna2PictureBox1)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.MinimizeButton)
			Me.Controls.Add(Me.ExitButton)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.Number_Of_Junk)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.Junk_CheckBox)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.Rename_CheckBox)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.Int_Encoding)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.OpenFile_Button)
			Me.Controls.Add(Me.txtFileName)
			Me.Controls.Add(Me.CheckBox_String_Encryption)
			Me.Controls.Add(Me.txtOpenFile)
			Me.Controls.Add(Me.Protect)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Name = "Form1"
			Me.Text = "Window"
			DirectCast(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private WithEvents Protect As Guna.UI2.WinForms.Guna2Button
		Private txtOpenFile As Guna.UI2.WinForms.Guna2TextBox
		Private WithEvents CheckBox_String_Encryption As Guna.UI2.WinForms.Guna2CustomCheckBox
		Private WithEvents txtFileName As Guna.UI2.WinForms.Guna2TextBox
		Private WithEvents OpenFile_Button As Guna.UI2.WinForms.Guna2Button
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private WithEvents Int_Encoding As Guna.UI2.WinForms.Guna2CustomCheckBox
		Private label5 As System.Windows.Forms.Label
		Private WithEvents Rename_CheckBox As Guna.UI2.WinForms.Guna2CustomCheckBox
		Private label6 As System.Windows.Forms.Label
		Private WithEvents Junk_CheckBox As Guna.UI2.WinForms.Guna2CustomCheckBox
		Private Number_Of_Junk As Guna.UI2.WinForms.Guna2TextBox
		Private label7 As System.Windows.Forms.Label
		Private WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
		Private WithEvents MinimizeButton As Guna.UI2.WinForms.Guna2Button
		Private guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
		Private WithEvents label8 As System.Windows.Forms.Label
		Private guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
		Private WithEvents label9 As System.Windows.Forms.Label
	End Class
End Namespace

