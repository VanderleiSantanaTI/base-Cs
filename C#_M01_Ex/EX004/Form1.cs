using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void btnOk_Click_1(object sender, EventArgs e)
        {

            float num = 0;
            float.TryParse(txtNum.Text, out num);
            int parteInteira = (int) num;
            int arrendondando = Convert.ToInt16(num);

            lblMsg1.Text = $"Você digitou o valor {num:N}";
            lblMsg2.Text = $"A parte  interia é {parteInteira:D}";
            lblMsg3.Text = $"Arrendondando, temos {arrendondando:D}";
            panResultado.Visible = true;

        }
    }
}
