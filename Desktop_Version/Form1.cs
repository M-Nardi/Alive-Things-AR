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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Close();
            this.Close();
        }
    }
}
