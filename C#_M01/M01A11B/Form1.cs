using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {// evento de um botão do Form
            lblmsg.Text = "Olá";
            await Task.Delay(3000);// 'await ==> escolher (Tornar o método assícrono(permanecer nulo))
            lblmsg.Text += ", tudo bem?";
        }
    }
}
