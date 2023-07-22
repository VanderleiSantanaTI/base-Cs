using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            nome = nome.ToLower(); // para o resultata sair em minúscula
            
            lblMsg.Text = "Muinto prazer em te conhecer " + nome + "!";
            lblMsg.Visible = true;
            txtNome.Clear();
                }
    }
}
