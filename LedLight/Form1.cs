using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedLight
{
    public partial class Form1 : Form
    {
        System.Timers.Timer ledTimer = new System.Timers.Timer();
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            led1.GridentColor = Color.Red;
            ledTimer.AutoReset = true;
            ledTimer.Interval = 1000;
            ledTimer.Elapsed += LedTimer_Elapsed;
            ledTimer.Enabled = true;
        }

        private void LedTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            led1.Invoke(new Action(() => {
                if (flag)
                {
                    led1.GridentColor = Color.Red;
                    flag = false;
                }
                else
                {
                    flag = true;
                    led1.GridentColor = Color.Green;
                }
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ledTimer.Enabled = false;
        }
    }
}
