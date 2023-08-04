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

namespace EX002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnINICIAR_Click(object sender, EventArgs e)
        {
            
            lblmsg1.Visible = true;
            
            lblmsg2.Visible = true;

            lblmsg3.Visible = true;
            await Task.Delay(1000);

            lblmsg1.BackColor = Color.Blue;
            lblmsg1.ForeColor = Color.White;

            await Task.Delay(1000);
            lblmsg2.BackColor = Color.Yellow;
            lblmsg2.ForeColor = Color.Green;

            await Task.Delay(1000);
            lblmsg3.BackColor = Color.Green;
            lblmsg3.ForeColor = Color.Yellow;

        }

    }
}
