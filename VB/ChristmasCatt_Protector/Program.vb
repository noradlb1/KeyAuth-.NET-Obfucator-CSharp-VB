Imports KeyAuth
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace random_Project_IdeA
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub


		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Login())
		End Sub
	End Class
End Namespace
