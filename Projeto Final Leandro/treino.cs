using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_Leandro
{
    public partial class treino : Form
    {
        public treino()
        {
            InitializeComponent();
        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            Close();
            menu.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            Close();
            menu.Show();
        }
    }
}
