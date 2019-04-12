namespace GridCellsCreepingLine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SecondName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(579, 427);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.SecondName,
            this.Age,
            this.ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FirstName
            // 
            this.FirstName.Caption = "FirstName";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            this.FirstName.Width = 50;
            // 
            // SecondName
            // 
            this.SecondName.Caption = "SecondName";
            this.SecondName.FieldName = "SecondName";
            this.SecondName.Name = "SecondName";
            this.SecondName.Visible = true;
            this.SecondName.VisibleIndex = 1;
            this.SecondName.Width = 50;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 2;
            this.Age.Width = 227;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 3;
            this.ID.Width = 234;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 427);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn SecondName;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}

