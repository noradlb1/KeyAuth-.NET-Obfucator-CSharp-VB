Imports dnlib.DotNet.Emit
Imports dnlib.DotNet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace random_Project_IdeA.Protactions
	Friend Class Confusion
		Public Shared Sub Execute(ByVal [mod] As ModuleDef)
			For Each type In [mod].GetTypes()
				If type.IsGlobalModuleType Then
					Continue For
				End If
				For Each method In type.Methods
					If Not method.HasBody Then
						Continue For
					End If
						Dim i = 0
						Do While i < method.Body.Instructions.Count
							If Not method.Body.Instructions(i).IsLdcI4() Then
								i += 1
								Continue Do
							End If
							Dim numorig = (New Random(Guid.NewGuid().GetHashCode())).Next()
							Dim div = (New Random(Guid.NewGuid().GetHashCode())).Next()
							Dim num = numorig Xor div

							Dim nop = OpCodes.Nop.ToInstruction()

							Dim local = New Local(method.Module.ImportAsTypeSig(GetType(Integer)))
							method.Body.Variables.Add(local)

							method.Body.Instructions.Insert(i + 1, OpCodes.Stloc.ToInstruction(local))
							method.Body.Instructions.Insert(i + 2, Instruction.Create(OpCodes.Ldc_I4, method.Body.Instructions(i).GetLdcI4Value() - Len(New Single)))
							method.Body.Instructions.Insert(i + 3, Instruction.Create(OpCodes.Ldc_I4, num))
							method.Body.Instructions.Insert(i + 4, Instruction.Create(OpCodes.Ldc_I4, div))
							method.Body.Instructions.Insert(i + 5, Instruction.Create(OpCodes.Xor))
							method.Body.Instructions.Insert(i + 6, Instruction.Create(OpCodes.Ldc_I4, numorig))
							method.Body.Instructions.Insert(i + 7, Instruction.Create(OpCodes.Bne_Un, nop))
							method.Body.Instructions.Insert(i + 8, Instruction.Create(OpCodes.Ldc_I4, 2))
							method.Body.Instructions.Insert(i + 9, OpCodes.Stloc.ToInstruction(local))
							method.Body.Instructions.Insert(i + 10, Instruction.Create(OpCodes.Sizeof, method.Module.Import(GetType(Single))))
							method.Body.Instructions.Insert(i + 11, Instruction.Create(OpCodes.Add))
							method.Body.Instructions.Insert(i + 12, nop)
							i += 12
							i += 1
						Loop
						method.Body.SimplifyBranches()
				Next method
			Next type
		End Sub
	End Class
End Namespace
