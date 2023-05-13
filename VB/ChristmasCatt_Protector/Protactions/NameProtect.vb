Imports dnlib.DotNet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace random_Project_IdeA.Protactions
	Friend Class NameProtect
		Public Shared Sub Execute(ByVal assembly As AssemblyDef, ByVal [mod] As ModuleDef)

			For Each type As TypeDef In [mod].Types
				[mod].Name = "https://github.com/ChristmasCatt"
				If type.IsGlobalModuleType OrElse type.IsRuntimeSpecialName OrElse type.IsSpecialName OrElse type.IsWindowsRuntime OrElse type.IsInterface Then
					Continue For
				Else
					For Each [property] As PropertyDef In type.Properties
						If [property].IsRuntimeSpecialName Then
							Continue For
						End If
						[property].Name = RandomString(20) & "https://github.com/ChristmasCatt"
					Next [property]
					For Each fields As FieldDef In type.Fields
						fields.Name = RandomString(20) & "https://github.com/ChristmasCatt"
					Next fields
					For Each eventdef As EventDef In type.Events
						eventdef.Name = RandomString(20) & "https://github.com/ChristmasCatt"
					Next eventdef
					For Each method As MethodDef In type.Methods
						If method.IsConstructor OrElse method.IsRuntimeSpecialName OrElse method.IsRuntime OrElse method.IsStaticConstructor OrElse method.IsVirtual Then
							Continue For
						End If
						method.Name = RandomString(20)
					Next method
				End If
			Next type
		End Sub
		Private Shared random As New Random()
		Public Shared Function RandomString(ByVal length As Integer) As String
			Const chars As String = "日本書紀العالمحالعجلة林氏家族การดำน้ำดูปะการังसंस्कृतम्संस्कृतावाक्abcdeiu78ajd76"
			Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
		End Function
	End Class
End Namespace
