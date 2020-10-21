using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TemperatureMeasurement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMain());
            string ProcessName = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(ProcessName).Length > 1)
            {
                MessageBox.Show("系统已运行", "系统运行", MessageBoxButtons.OK);
                return;
            }
            else
            {
                FrmLogin objFrmLogin = new FrmLogin();
                objFrmLogin.TopMost = true;
                DialogResult dr = objFrmLogin.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Application.Run(new FrmMain());
                }
            }


        }
    }
}
