Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace GridCellsCreepingLine
	Partial Public Class Form1
		Inherits Form

		Private creep As Boolean = False
		Private column As GridColumn = Nothing
		Private rowHandle As Integer = -1

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Me.carsTableAdapter.Fill(Me.carsDBDataSet_Renamed.Cars)

			AddHandler gridControl1.GetToolTipController().GetActiveObjectInfo, AddressOf OnGridControlToolTipControllerGetActiveObjectInfo
		End Sub

		Private Sub OnGridControlToolTipControllerGetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
			If e.Info Is Nothing Then
				Return
			End If

			Dim hitInfo As GridHitInfo = gridView1.CalcHitInfo(e.ControlMousePosition.X, e.ControlMousePosition.Y)
			If hitInfo.HitTest = GridHitTest.RowCell Then
				e.Info.Text = Convert.ToString(gridView1.GetRowCellValue(hitInfo.RowHandle, hitInfo.Column))
			End If
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			If creep AndAlso e.Column Is column AndAlso e.RowHandle = rowHandle Then
				Dim szCellValue As SizeF = e.Appearance.CalcTextSize(e.Cache, Convert.ToString(e.CellValue) & ".", 1000)
				If szCellValue.Width > e.Bounds.Width Then
					If e.DisplayText = Convert.ToString(e.CellValue) Then
						e.DisplayText = e.DisplayText & " "c
					End If

					Dim letter As Char = e.DisplayText.Chars(0)
					e.DisplayText = e.DisplayText.Remove(0, 1)
					e.DisplayText = e.DisplayText & letter
				End If
			End If
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			creep = True
			gridView1.InvalidateRowCell(rowHandle, column)
		End Sub

		Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
			Dim hitInfo As GridHitInfo = gridView1.CalcHitInfo(e.X, e.Y)
			If hitInfo.HitTest = GridHitTest.RowCell Then
				column = hitInfo.Column
				rowHandle = hitInfo.RowHandle
			End If
		End Sub
	End Class
End Namespace