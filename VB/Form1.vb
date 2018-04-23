' Developer Express Code Central Example:
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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private _Helper As FlashedCellsHelper
				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Speed", GetType(Integer))
			tbl.Columns.Add("Status", GetType(String))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { 0, String.Format("Test{0}", i) })
			Next i
			Return tbl
				End Function

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(5)
			gridControl1.ForceInitialize()
			gridView1.Columns(0).Width = 20
			_Helper = New FlashedCellsHelper(gridView1)
			FlashedCellsHelper.FlashedCellAppearance.BackColor = Color.Red
			FlashedCellsHelper.FlashedCellAppearance.BackColor2 = Color.Yellow
			FlashedCellsHelper.FlashedCellAppearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
		End Sub

		Private Sub repositoryItemSpinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemSpinEdit1.EditValueChanged
			gridView1.PostEditor()
		End Sub

		Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles gridView1.CellValueChanged
			Dim speed As Integer = CInt(Fix(e.Value))
			_Helper.SetFlashSpeed(e.RowHandle, gridView1.Columns("Status"), CInt(Fix(speed)))
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			gridView1.SetRowCellValue(0, gridView1.Columns(0), 100)
			gridView1.SetRowCellValue(1, gridView1.Columns(0), 1000)
		End Sub
	End Class
End Namespace