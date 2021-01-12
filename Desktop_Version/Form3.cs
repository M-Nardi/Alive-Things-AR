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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
            this.Hide();
        }
    }
}
