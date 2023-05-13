Imports dnlib.DotNet
Imports dnlib.DotNet.Emit
Imports Guna.UI2.WinForms
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Threading
Imports random_Project_IdeA.Protactions
Imports System.Diagnostics

Namespace random_Project_IdeA
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			Me.StartPosition = FormStartPosition.CenterScreen
		End Sub
		Friend Shared filepath As String

		Private Shared random As New Random()

		Public Shared Function RandomString(ByVal length As Integer) As String
			Const chars As String = "日本書紀العالمحالعجلة林氏家族การดำน้ำดูปะการังसंस्कृतम्संस्कृतावाक्abcdeiu78ajd76的是有为也而要你可生家发如成起经abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789"
			Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
		End Function
		Public Sub JunkSpam(ByVal [module] As ModuleDefMD)
			Dim number As Integer = System.Convert.ToInt32(Number_Of_Junk.Text)
			For i As Integer = 0 To number - 1
				Dim junkatrb = New TypeDefUser("https://github.com/ChristmasCatt" & RandomString(20), "https://github.com/ChristmasCatt" & RandomString(20), [module].CorLibTypes.Object.TypeDefOrRef)
				[module].Types.Add(junkatrb)
			Next i
		End Sub
		Private Sub Protect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Protect.Click
			filepath = txtOpenFile.Text
			If String.IsNullOrEmpty(filepath) OrElse String.IsNullOrWhiteSpace(filepath) Then
				MessageBox.Show("Enter valid path!", "Error!")
			Else
				If File.Exists(filepath) Then


					Try
						Dim assembly As AssemblyDef = AssemblyDef.Load(txtOpenFile.Text)
						Dim modCtx As ModuleContext = ModuleDefMD.CreateModuleContext()
						Dim [module] As ModuleDefMD = ModuleDefMD.Load(txtOpenFile.Text, modCtx)
						Dim outputFile As String = Path.Combine(Path.GetDirectoryName(filepath), txtFileName.Text & ".exe")

						If CheckBox_String_Encryption.Checked Then
							Strings.Execute([module])
						End If
						If Int_Encoding.Checked Then
							Confusion.Execute([module])
						End If
						If Rename_CheckBox.Checked Then
							NameProtect.Execute(assembly, [module])
						End If
						If Junk_CheckBox.Checked Then
							JunkSpam([module])
						End If

						[module].Write(outputFile)

						MessageBox.Show("Protected." & ControlChars.Lf & "File located at: " & outputFile, "Protected", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Catch
						MessageBox.Show("Protection failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End Try
				Else
					MessageBox.Show("File doesn't exist!", "Error!")
				End If
			End If
		End Sub




		Private Sub guna2Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenFile_Button.Click
			Dim openfiledialog As New OpenFileDialog()
			openfiledialog.Filter = "Executables | *.*"
			openfiledialog.ShowDialog()
			txtOpenFile.Text = openfiledialog.FileName
			filepath = txtOpenFile.Text
			If File.Exists(filepath) Then
				If Path.GetExtension(filepath) = ".dll" Then
					MessageBox.Show("DLL Loaded", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)
				ElseIf Path.GetExtension(filepath) = ".exe" Then
					MessageBox.Show("EXE Loaded", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If
		End Sub

		Private Sub CheckBox_String_Encryption_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox_String_Encryption.CheckedChanged

		End Sub

		Private Sub guna2TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtFileName.TextChanged

		End Sub

		Private Sub Int_Encoding_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Int_Encoding.Click

		End Sub

		Private Sub Rename_CheckBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Rename_CheckBox.Click

		End Sub

		Private Sub Junk_CheckBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Junk_CheckBox.Click

		End Sub

		Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitButton.Click
			Me.Close()
		End Sub

		Private Sub MinimizeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MinimizeButton.Click
			Me.WindowState = FormWindowState.Minimized
		End Sub

		Private Sub label8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label8.Click
			Process.Start("https://github.com/ChristmasCatt")
		End Sub

		Private Sub label9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label9.Click
			Process.Start("https://keyauth.cc/")
		End Sub
	End Class
End Namespace
