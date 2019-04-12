Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace GridCellsCreepingLine
    Partial Public Class Form1
        Inherits Form

        Private column As GridColumn = Nothing
        Private creep As Boolean = False
        Private rowHandle As Integer = -1

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = GetPersonDataTable()
            AddHandler gridControl1.GetToolTipController().GetActiveObjectInfo, New ToolTipControllerGetActiveObjectInfoEventHandler(AddressOf OnGridControlToolTipControllerGetActiveObjectInfo)
        End Sub

        Private Function GetPersonDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Persons"
            table.Columns.Add(New DataColumn("FirstName", GetType(String)))
            table.Columns.Add(New DataColumn("SecondName", GetType(String)))
            table.Columns.Add(New DataColumn("Age", GetType(Integer)))
            table.Columns.Add(New DataColumn("ID", GetType(Integer)))

            For i As Integer = 0 To 50 - 1
                table.Rows.Add("Adam van Dorian " & i, "Peterson-Don-Abraham " & i, 20 + i / 2, i)
            Next

            Return table
        End Function

        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If creep AndAlso e.Column Is column AndAlso e.RowHandle = rowHandle Then
                Dim szCellValue As SizeF = e.Appearance.CalcTextSize(e.Graphics, Convert.ToString(e.CellValue) & ".", 1000)

                If szCellValue.Width > e.Bounds.Width Then
                    If e.DisplayText = Convert.ToString(e.CellValue) Then e.DisplayText = e.DisplayText + " "c
                    Dim letter As Char = e.DisplayText(0)
                    e.DisplayText = e.DisplayText.Remove(0, 1)
                    e.DisplayText = e.DisplayText + letter
                End If
            Else
                e.DisplayText = e.DisplayText
            End If
        End Sub

        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.X, e.Y)

            If hitInfo.HitTest = GridHitTest.RowCell Then

                If column IsNot hitInfo.Column OrElse rowHandle <> hitInfo.RowHandle Then
                    Dim previousRowhandle As Integer = rowHandle
                    Dim previousColumn As GridColumn = column
                    column = hitInfo.Column
                    rowHandle = hitInfo.RowHandle
                    view.RefreshRowCell(previousRowhandle, previousColumn)
                End If
            End If
        End Sub

        Private Sub OnGridControlToolTipControllerGetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            If e.Info Is Nothing Then Return
            Dim hitInfo As GridHitInfo = gridView1.CalcHitInfo(e.ControlMousePosition.X, e.ControlMousePosition.Y)
            If hitInfo.HitTest = GridHitTest.RowCell Then e.Info.Text = Convert.ToString(gridView1.GetRowCellValue(hitInfo.RowHandle, hitInfo.Column))
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            creep = True
            gridView1.InvalidateRowCell(rowHandle, column)
        End Sub
    End Class
End Namespace
