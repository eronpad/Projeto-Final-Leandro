using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_Leandro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void edit_mode_on()
        {
        }
        private void picbox_edit_Click(object sender, EventArgs e)
        {
            edit_mode_on();
        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {

            string email = txt_gmail.Text;
            string senha = txt_password.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("O email ou sua senha esta incorreto, favor verificar e tentar novamete");
            }
            else
            {
                Form2 novoForm = new Form2();
                novoForm.Show();
                Hide();
            }
        }
    }
  }
