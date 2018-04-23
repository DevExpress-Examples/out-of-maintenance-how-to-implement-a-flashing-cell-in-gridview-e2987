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
Namespace WindowsApplication1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(731, 559)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CellValueChanged += New DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(Me.gridView1_CellValueChanged);
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Speed"
			Me.gridColumn1.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn1.FieldName = "Speed"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Flashed cells"
			Me.gridColumn2.FieldName = "Status"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
'			Me.repositoryItemSpinEdit1.EditValueChanged += New System.EventHandler(Me.repositoryItemSpinEdit1_EditValueChanged);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(515, 13)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(154, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Test"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(731, 559)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.gridControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

