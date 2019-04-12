using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GridCellsCreepingLine
{
    public partial class Form1 : Form
    {
        private GridColumn column = null;
        private bool creep = false;
        private int rowHandle = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GetPersonDataTable();
            gridControl1.GetToolTipController().GetActiveObjectInfo += new ToolTipControllerGetActiveObjectInfoEventHandler(OnGridControlToolTipControllerGetActiveObjectInfo);
        }
        DataTable GetPersonDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Persons";
            table.Columns.Add(new DataColumn("FirstName", typeof(string)));
            table.Columns.Add(new DataColumn("SecondName", typeof(string)));
            table.Columns.Add(new DataColumn("Age", typeof(int)));
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            for(int i = 0; i < 50; i++)
                table.Rows.Add("Adam van Dorian " + i, "Peterson-Don-Abraham " + i, 20 + i / 2, i);
            return table;
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(creep && e.Column == column && e.RowHandle == rowHandle)
            {
                SizeF szCellValue = e.Appearance.CalcTextSize(e.Graphics, Convert.ToString(e.CellValue) + ".", 1000);
                if(szCellValue.Width > e.Bounds.Width)
                {
                    if(e.DisplayText == Convert.ToString(e.CellValue))
                        e.DisplayText = e.DisplayText + ' ';

                    char letter = e.DisplayText[0];
                    e.DisplayText = e.DisplayText.Remove(0, 1);
                    e.DisplayText = e.DisplayText + letter;
                }
            }
            else { e.DisplayText = e.DisplayText; }
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.X, e.Y);
            if(hitInfo.HitTest == GridHitTest.RowCell)
            {
                if(column != hitInfo.Column || rowHandle != hitInfo.RowHandle)
                {
                    int previousRowhandle = rowHandle;
                    GridColumn previousColumn = column;
                    column = hitInfo.Column;
                    rowHandle = hitInfo.RowHandle;
                    view.RefreshRowCell(previousRowhandle, previousColumn);
                }
            }
        }
        private void OnGridControlToolTipControllerGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if(e.Info == null)
                return;

            GridHitInfo hitInfo = gridView1.CalcHitInfo(e.ControlMousePosition.X, e.ControlMousePosition.Y);
            if(hitInfo.HitTest == GridHitTest.RowCell)
                e.Info.Text = Convert.ToString(gridView1.GetRowCellValue(hitInfo.RowHandle, hitInfo.Column));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            creep = true;
            gridView1.InvalidateRowCell(rowHandle, column);
        }
    }
}