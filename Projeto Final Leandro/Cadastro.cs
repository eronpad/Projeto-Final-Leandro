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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluno Cadastrado com Sucesso!");
            txt_altura.Clear();
            txt_idade.Clear();
            txt_name.Clear();
            txt_peso.Clear();
            btn_fem.Checked = false;
            btn_mas.Checked = false;
            btn_outro.Checked = false;
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
