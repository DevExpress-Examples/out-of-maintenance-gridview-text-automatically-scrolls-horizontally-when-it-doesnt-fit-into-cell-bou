Namespace GridCellsCreepingLine
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
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.FirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.SecondName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.Age = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(579, 427)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.Row.Options.UseTextOptions = True
			Me.gridView1.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Character
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.FirstName, Me.SecondName, Me.Age, Me.ID})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 500
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			' 
			' FirstName
			' 
			Me.FirstName.Caption = "FirstName"
			Me.FirstName.FieldName = "FirstName"
			Me.FirstName.Name = "FirstName"
			Me.FirstName.Visible = True
			Me.FirstName.VisibleIndex = 0
			Me.FirstName.Width = 50
			' 
			' SecondName
			' 
			Me.SecondName.Caption = "SecondName"
			Me.SecondName.FieldName = "SecondName"
			Me.SecondName.Name = "SecondName"
			Me.SecondName.Visible = True
			Me.SecondName.VisibleIndex = 1
			Me.SecondName.Width = 50
			' 
			' Age
			' 
			Me.Age.Caption = "Age"
			Me.Age.FieldName = "Age"
			Me.Age.Name = "Age"
			Me.Age.Visible = True
			Me.Age.VisibleIndex = 2
			Me.Age.Width = 227
			' 
			' ID
			' 
			Me.ID.Caption = "ID"
			Me.ID.FieldName = "ID"
			Me.ID.Name = "ID"
			Me.ID.Visible = True
			Me.ID.VisibleIndex = 3
			Me.ID.Width = 234
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(579, 427)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private FirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private SecondName As DevExpress.XtraGrid.Columns.GridColumn
		Private Age As DevExpress.XtraGrid.Columns.GridColumn
		Private ID As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

