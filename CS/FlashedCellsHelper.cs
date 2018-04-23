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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public class FlashedCellsHelper
    {

        public static AppearanceObject FlashedCellAppearance = new AppearanceObject();

        List<FlashedCell> flashedCells = new List<FlashedCell>();
        private readonly GridView _View;

        public FlashedCellsHelper(GridView view)
        {
            _View = view;

        }

        FlashedCell FindFlashedCell(int rowHanlde, GridColumn col)
        {
            foreach (FlashedCell cell in flashedCells)
            {
                if (cell.RowHandle == rowHanlde && cell.Column == col)
                    return cell;
            }

            FlashedCell result = new FlashedCell(rowHanlde, col, _View);
            flashedCells.Add(result);
            return result;
        }

        public void SetFlashSpeed(int rowHanlde, GridColumn col, int speed)
        {
            FindFlashedCell(rowHanlde, col).Speed = speed;
        }
    }
}
