using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectData
{
    public partial class FmMain : MetroFramework.Forms.MetroForm
    {
        public FmMain()
        {
            InitializeComponent();
        }

        MessageQueue mq = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            mq = new MessageQueue();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mlExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mlkLogin_Click(object sender, EventArgs e)
        {
            LogInOut("IN");
        }

        private void mlkLogout_Click(object sender, EventArgs e)
        {
            LogInOut("OUT");
        }

        private void LogInOut(string flag)
        {
            if (flag.Equals("IN"))
            {
                mlkLogin.Visible = false;
                mlkLogout.Visible = true;
            }
            else
            {
                mlkLogin.Visible = true;
                mlkLogout.Visible = false;
            }

        }
    }
}
