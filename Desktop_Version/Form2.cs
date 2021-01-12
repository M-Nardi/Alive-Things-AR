using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {

        }

        private void como_jogar_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void sair_Click(object sender, EventArgs e)
        {

            var newForm = new Form1();
            newForm.Close();
            this.Close();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1yC0VRDVbL6mnIL5jEqN8z8axKL6U-FCy?usp=sharing");
        }
    }
}
