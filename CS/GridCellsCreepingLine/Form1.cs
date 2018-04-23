using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GridCellsCreepingLine
{
    public partial class Form1 : Form
    {
        private bool creep = false;
        private GridColumn column = null;
        private int rowHandle = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            
            gridControl1.GetToolTipController().GetActiveObjectInfo += new ToolTipControllerGetActiveObjectInfoEventHandler(OnGridControlToolTipControllerGetActiveObjectInfo);
        }

        private void OnGridControlToolTipControllerGetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info == null)
                return;

            GridHitInfo hitInfo = gridView1.CalcHitInfo(e.ControlMousePosition.X, e.ControlMousePosition.Y);
            if (hitInfo.HitTest == GridHitTest.RowCell)
                e.Info.Text = Convert.ToString(gridView1.GetRowCellValue(hitInfo.RowHandle, hitInfo.Column));
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (creep && e.Column == column && e.RowHandle == rowHandle)
            {
                SizeF szCellValue = e.Appearance.CalcTextSize(e.Graphics, Convert.ToString(e.CellValue) + ".", 1000);
                if (szCellValue.Width > e.Bounds.Width)
                {
                    if (e.DisplayText == Convert.ToString(e.CellValue))
                        e.DisplayText = e.DisplayText + ' ';

                    char letter = e.DisplayText[0];
                    e.DisplayText = e.DisplayText.Remove(0, 1);
                    e.DisplayText = e.DisplayText + letter;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            creep = true;
            gridView1.InvalidateRowCell(rowHandle, column);
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = gridView1.CalcHitInfo(e.X, e.Y);
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                column = hitInfo.Column;
                rowHandle = hitInfo.RowHandle;
            }
        }
    }
}