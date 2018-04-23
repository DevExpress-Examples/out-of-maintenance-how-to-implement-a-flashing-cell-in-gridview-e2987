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
using System.Windows.Forms;

namespace WindowsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}