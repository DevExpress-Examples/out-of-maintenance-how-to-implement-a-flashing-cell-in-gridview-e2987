// Developer Express Code Central Example:
// How to implement a flashing cell in GridView?
// 
// This example demonstrates how to force a specific cell to flash in GridView. The
// first column allows you to specify flashing speed.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2987

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private FlashedCellsHelper _Helper;
                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Speed", typeof(int));
            tbl.Columns.Add("Status", typeof(string));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { 0, String.Format("Test{0}", i) });
            return tbl;
        }
        
        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(5);
            gridControl1.ForceInitialize();
            gridView1.Columns[0].Width = 20;
            _Helper = new FlashedCellsHelper(gridView1);
            FlashedCellsHelper.FlashedCellAppearance.BackColor = Color.Red;
            FlashedCellsHelper.FlashedCellAppearance.BackColor2 = Color.Yellow;
            FlashedCellsHelper.FlashedCellAppearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
        }

        private void repositoryItemSpinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            int speed = (int)e.Value;
            _Helper.SetFlashSpeed(e.RowHandle, gridView1.Columns["Status"], (int)speed);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.SetRowCellValue(0, gridView1.Columns[0], 100);
            gridView1.SetRowCellValue(1, gridView1.Columns[0], 1000);
        }
    }
}