using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
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
            
            int altura_txt, peso_txt;
            if(int.TryParse(txt_altura.Text, out altura_txt) && int.TryParse(txt_peso.Text, out peso_txt))
            {
                imc(peso_txt, altura_txt);
                MessageBox.Show("Aluno Cadastrado com Sucesso!");
                
            }
            else
            {
                MessageBox.Show("Coloque um valor válido na altura e no peso!");
            }
            
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void imc(int peso, int altura)
        {
            
            double alturaMetros = (double)altura / 100;
            double imc = peso / (alturaMetros * alturaMetros);
            lbl_imc.Text = $"IMC do Aluno: {imc:F2}";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_altura.Clear();
            txt_idade.Clear();
            txt_name.Clear();
            txt_peso.Clear();
            btn_fem.Checked = false;
            btn_mas.Checked = false;
            btn_outro.Checked = false;
            lbl_imc.Text = "IMC do Aluno: ";
        }
    }
}
