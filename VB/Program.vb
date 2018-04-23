﻿' Developer Express Code Central Example:
' How to implement a flashing cell in GridView?
' 
' This example demonstrates how to force a specific cell to flash in GridView. The
' first column allows you to specify flashing speed.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2987

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace