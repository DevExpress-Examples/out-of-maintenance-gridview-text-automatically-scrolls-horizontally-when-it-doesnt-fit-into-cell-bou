Namespace GridCellsCreepingLine
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.FirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SecondName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Age = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(579, 427)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            Me.gridView1.Appearance.Row.Options.UseTextOptions = True
            Me.gridView1.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Character
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FirstName, Me.SecondName, Me.Age, Me.ID})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            AddHandler Me.gridView1.CustomDrawCell, New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawCell)
            AddHandler Me.gridView1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gridView1_MouseMove)
            Me.timer1.Enabled = True
            Me.timer1.Interval = 500
            AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.timer1_Tick)
            Me.FirstName.Caption = "FirstName"
            Me.FirstName.FieldName = "FirstName"
            Me.FirstName.Name = "FirstName"
            Me.FirstName.Visible = True
            Me.FirstName.VisibleIndex = 0
            Me.FirstName.Width = 50
            Me.SecondName.Caption = "SecondName"
            Me.SecondName.FieldName = "SecondName"
            Me.SecondName.Name = "SecondName"
            Me.SecondName.Visible = True
            Me.SecondName.VisibleIndex = 1
            Me.SecondName.Width = 50
            Me.Age.Caption = "Age"
            Me.Age.FieldName = "Age"
            Me.Age.Name = "Age"
            Me.Age.Visible = True
            Me.Age.VisibleIndex = 2
            Me.Age.Width = 227
            Me.ID.Caption = "ID"
            Me.ID.FieldName = "ID"
            Me.ID.Name = "ID"
            Me.ID.Visible = True
            Me.ID.VisibleIndex = 3
            Me.ID.Width = 234
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(579, 427)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private timer1 As System.Windows.Forms.Timer
        Private FirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private SecondName As DevExpress.XtraGrid.Columns.GridColumn
        Private Age As DevExpress.XtraGrid.Columns.GridColumn
        Private ID As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
