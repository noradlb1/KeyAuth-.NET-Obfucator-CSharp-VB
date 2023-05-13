Imports random_Project_IdeA
Imports System
Imports System.Diagnostics
Imports System.Net
Imports System.Windows.Forms

Namespace KeyAuth
	Partial Public Class Login
		Inherits Form



		Public Shared KeyAuthApp As New api(name:= "", ownerid:= "", secret:= "", version:= "")

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub siticoneControlBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneControlBox1.Click
			Environment.Exit(0)
		End Sub

		Public Shared Function SubExist(ByVal name As String) As Boolean
			If KeyAuthApp.user_data.subscriptions.Exists(Function(x) x.subscription = name) Then
				Return True
			End If
			Return False
		End Function

		Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			KeyAuthApp.init()

			If KeyAuthApp.response.message = "invalidver" Then
				If Not String.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink) Then
'INSTANT VB NOTE: The variable dialogResult was renamed since Visual Basic does not handle local variables named the same as class members well:
					Dim dialogResult_Renamed As DialogResult = MessageBox.Show("Yes to open file in browser" & ControlChars.Lf & "No to download file automatically", "Auto update", MessageBoxButtons.YesNo)
					Select Case dialogResult_Renamed
						Case System.Windows.Forms.DialogResult.Yes
							Process.Start(KeyAuthApp.app_data.downloadLink)
							Environment.Exit(0)
						Case System.Windows.Forms.DialogResult.No
							Dim webClient As New WebClient()
							Dim destFile As String = Application.ExecutablePath

							Dim rand As String = random_string()

							destFile = destFile.Replace(".exe", $"-{rand}.exe")
							webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile)

							Process.Start(destFile)
							Process.Start(New ProcessStartInfo() With {.Arguments = "/C choice /C Y /N /D Y /T 3 & Del """ & Application.ExecutablePath & """", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe"})
							Environment.Exit(0)

						Case Else
							MessageBox.Show("Invalid option")
							Environment.Exit(0)
					End Select
				End If
				MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer")
				Environment.Exit(0)
			End If

			If Not KeyAuthApp.response.success Then
				MessageBox.Show(KeyAuthApp.response.message)
				Environment.Exit(0)
			End If
			' if(KeyAuthApp.checkblack())
			' {
			'     MessageBox.Show("user is blacklisted");
			' }
			' else
			' {
			'     MessageBox.Show("user is not blacklisted");
			' }
			' check if subscription exists
			' if(SubExist("default"))
			' {
			'     MessageBox.Show("default subscription exists");
			' }
			KeyAuthApp.check()
			siticoneLabel1.Text = $"Current Session Validation Status: {KeyAuthApp.response.success}"
		End Sub

		Private Shared Function random_string() As String
			Dim str As String = Nothing

			Dim random As New Random()
			For i As Integer = 0 To 4
				str &= Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString()
			Next i
			Return str

		End Function



		Private Sub LoginBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginBtn.Click
			KeyAuthApp.login(username.Text,password.Text)
			If KeyAuthApp.response.success Then
				Dim main As New Form1()
				main.Show()
				Me.Hide()
			Else
				status.Text = "Status: " & KeyAuthApp.response.message
			End If
		End Sub

		Private Sub RgstrBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RgstrBtn.Click
			KeyAuthApp.register(username.Text, password.Text, key.Text)
			If KeyAuthApp.response.success Then
				Dim main As New Form1()
				main.Show()
				Me.Hide()
			Else
				status.Text = "Status: " & KeyAuthApp.response.message
			End If
		End Sub

		Private Sub label2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label2.Click
			Process.Start("https://github.com/ChristmasCatt")

		End Sub

		Private Sub label9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label9.Click
			Process.Start("https://keyauth.cc/")
		End Sub
	End Class
End Namespace