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
    public partial class Aluno : Form
    {
        private List<dado_aluno> listaAlunosGeral = new List<dado_aluno>();
        private dado_aluno[] vetorAlunosGeral = new dado_aluno[100];
        private int contadorAlunos = 0;

        public Aluno()
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
            
            double altura_txt, peso_txt;
            if(double.TryParse(txt_altura.Text, out altura_txt) && double.TryParse(txt_peso.Text, out peso_txt))
            {
                imc(peso_txt, altura_txt);
                try
                {
                    dado_aluno novoAluno = new dado_aluno();
                    
                    novoAluno.Nome = txt_name.Text;

                    novoAluno.Peso = Convert.ToDouble(txt_peso.Text);
                    novoAluno.Idade = Convert.ToInt32(txt_idade.Text);
                    novoAluno.Altura = Convert.ToDouble(txt_altura.Text);

                    if (btn_fem.Checked )
                    {
                        novoAluno.Sexo = 'F';
                    }
                    else if (btn_mas.Checked )
                    {
                        novoAluno.Sexo = 'M';
                    }

                    if(guna2ComboBox1.SelectedItem !=  null)
                    {
                        novoAluno.ObjFitness = guna2ComboBox1.SelectedItem.ToString();
                    }
                    else
                    {
                        novoAluno.ObjFitness = "Não Informado";
                    }

                    listaAlunosGeral.Add(novoAluno);

                    if(contadorAlunos  < vetorAlunosGeral.Length)
                    {
                        vetorAlunosGeral[contadorAlunos] = novoAluno;
                        contadorAlunos++;

                        MessageBox.Show("Aluno Salvo com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Memoria Cheia, whomp whomp");
                    }
                }
                catch { }
                
            }
            else
            {
                MessageBox.Show("Coloque um valor válido na altura e no peso!");
            }
            
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void imc(double peso, double altura)
        {
            double imc = peso / (altura * altura);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public struct dado_aluno
        {
            public string Nome { get; set; }
            public double Peso { get; set; }
            public int Idade { get; set; }
            public double Altura { get; set; }
            public string ObjFitness { get; set; }
            public char Sexo { get; set; }
        }
    }
}
