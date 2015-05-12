using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private Time myTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTime = new Time();

        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            int myHour = Convert.ToInt32(tbxSetHour.Text);
            int myminute = Convert.ToInt32(txbSetMin.Text);
            int mySecond = Convert.ToInt32(txbSetSec.Text);
            myTime.SetTime(myHour,myminute, mySecond);

        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            lblHour.Text = Convert.ToString(myTime.GetHour());
            lblMinute.Text = Convert.ToString(myTime.GetMinute());
            lblSecond.Text = Convert.ToString(myTime.GetSecond());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int myHour = Convert.ToInt32(tbxSetHour.Text);
            int myminute = Convert.ToInt32(txbSetMin.Text);
            int mySecond = Convert.ToInt32(txbSetSec.Text);
            myTime.AddSecond(ref myHour, ref myminute, ref mySecond);
            lblHour.Text = myHour.ToString();
            lblMinute.Text = myminute.ToString();
            lblSecond.Text = mySecond.ToString();
        }
    }
}
