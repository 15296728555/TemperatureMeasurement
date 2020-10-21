using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMeasurement
{
    public partial class FrmValueShow : Form
    {
        public FrmValueShow()
        {
            InitializeComponent();

            Timer myTime = new Timer();
            myTime.Interval = 500;
            myTime.Tick += MyTime_Tick;

            myTime.Start();



        }

        private void MyTime_Tick(object sender, EventArgs e)
        {
            UpdateUI(this);
          
        }

        private void UpdateUI(Control ct)
        {
            foreach (Control ctl in ct.Controls)
            {
                if (ctl is xktControl.JYTextShow ts)
                {
                    if (ts.Tag != null)
                        ts.VarValue = CommonMethods.CurrentPLCValue[ts.Tag.ToString()].ToString();

                }
            }


        }

  
    }
}
