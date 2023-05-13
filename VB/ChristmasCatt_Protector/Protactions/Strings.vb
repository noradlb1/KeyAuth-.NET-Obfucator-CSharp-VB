Imports dnlib.DotNet.Emit
Imports dnlib.DotNet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace random_Project_IdeA.Protactions
	Friend Class Strings
		Public Shared Sub Execute(ByVal [module] As ModuleDef)
			For Each type As TypeDef In [module].Types
				For Each method As MethodDef In type.Methods
					If method.Body Is Nothing Then
						Continue For
					End If
					method.Body.SimplifyBranches()
					Dim i As Integer = 0
					Do While i < method.Body.Instructions.Count
						If method.Body.Instructions(i).OpCode IsNot OpCodes.Ldstr Then
						Else
							Dim base64toencrypt As String = method.Body.Instructions(i).Operand.ToString()
							Dim base64EncryptedString As String = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(base64toencrypt))
							method.Body.Instructions(i).OpCode = OpCodes.Nop
							method.Body.Instructions.Insert(i + 1, New Instruction(OpCodes.Call, [module].Import(GetType(System.Text.Encoding).GetMethod("get_UTF8", New Type() { }))))
							method.Body.Instructions.Insert(i + 2, New Instruction(OpCodes.Ldstr, base64EncryptedString))
							method.Body.Instructions.Insert(i + 3, New Instruction(OpCodes.Call, [module].Import(GetType(System.Convert).GetMethod("FromBase64String", New Type() { GetType(String) }))))
							method.Body.Instructions.Insert(i + 4, New Instruction(OpCodes.Callvirt, [module].Import(GetType(System.Text.Encoding).GetMethod("GetString", New Type() { GetType(Byte()) }))))
							i += 4
						End If
						i += 1
					Loop
				Next method
			Next type
		End Sub
	End Class
End Namespace
