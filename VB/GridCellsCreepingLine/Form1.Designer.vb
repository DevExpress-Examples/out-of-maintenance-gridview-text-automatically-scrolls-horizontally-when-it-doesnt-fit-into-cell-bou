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
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet_Renamed = New GridCellsCreepingLine.CarsDBDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHP = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLiter = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCyl = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTransmissSpeedCount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTransmissAutomatic = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.carsTableAdapter = New GridCellsCreepingLine.CarsDBDataSetTableAdapters.CarsTableAdapter()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.carsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(579, 427)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet_Renamed
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.Row.Options.UseTextOptions = True
			Me.gridView1.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Character
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colTrademark, Me.colModel, Me.colHP, Me.colLiter, Me.colCyl, Me.colTransmissSpeedCount, Me.colTransmissAutomatic})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colTrademark
			' 
			Me.colTrademark.FieldName = "Trademark"
			Me.colTrademark.Name = "colTrademark"
			Me.colTrademark.Visible = True
			Me.colTrademark.VisibleIndex = 1
			' 
			' colModel
			' 
			Me.colModel.FieldName = "Model"
			Me.colModel.Name = "colModel"
			Me.colModel.Visible = True
			Me.colModel.VisibleIndex = 2
			' 
			' colHP
			' 
			Me.colHP.FieldName = "HP"
			Me.colHP.Name = "colHP"
			Me.colHP.Visible = True
			Me.colHP.VisibleIndex = 3
			' 
			' colLiter
			' 
			Me.colLiter.FieldName = "Liter"
			Me.colLiter.Name = "colLiter"
			Me.colLiter.Visible = True
			Me.colLiter.VisibleIndex = 4
			' 
			' colCyl
			' 
			Me.colCyl.FieldName = "Cyl"
			Me.colCyl.Name = "colCyl"
			Me.colCyl.Visible = True
			Me.colCyl.VisibleIndex = 5
			' 
			' colTransmissSpeedCount
			' 
			Me.colTransmissSpeedCount.FieldName = "TransmissSpeedCount"
			Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
			Me.colTransmissSpeedCount.Visible = True
			Me.colTransmissSpeedCount.VisibleIndex = 6
			' 
			' colTransmissAutomatic
			' 
			Me.colTransmissAutomatic.FieldName = "TransmissAutomatic"
			Me.colTransmissAutomatic.Name = "colTransmissAutomatic"
			Me.colTransmissAutomatic.Visible = True
			Me.colTransmissAutomatic.VisibleIndex = 7
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 500
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
'INSTANT VB NOTE: The variable carsDBDataSet was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private carsDBDataSet_Renamed As CarsDBDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As GridCellsCreepingLine.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
		Private colModel As DevExpress.XtraGrid.Columns.GridColumn
		Private colHP As DevExpress.XtraGrid.Columns.GridColumn
		Private colLiter As DevExpress.XtraGrid.Columns.GridColumn
		Private colCyl As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransmissSpeedCount As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransmissAutomatic As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents timer1 As System.Windows.Forms.Timer
	End Class
End Namespace

