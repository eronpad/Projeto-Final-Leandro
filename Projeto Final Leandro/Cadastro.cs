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
using System.Xml.XPath;

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
            Form2 menu = new Form2();
            Close();
            menu.Show();

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            double altura_txt, peso_txt;
            if (double.TryParse(txt_altura.Text, out altura_txt) && double.TryParse(txt_peso.Text, out peso_txt))
            {
                imc(peso_txt, altura_txt);

                try
                {
                    cadastre();
                    GerarRanking();
                }
                catch { }

                Limpar();
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
            double alturaMetros = altura / 100;
            double imc = peso / (alturaMetros * alturaMetros);
            lbl_imc.Text = $"IMC do Aluno: {imc:F2}";
        }

        private void Limpar()
        {
            txt_altura.Clear();
            txt_idade.Clear();
            txt_name.Clear();
            txt_peso.Clear();
            btn_fem.Checked = false;
            btn_mas.Checked = false;
            lbl_imc.Text = "IMC do Aluno: ";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
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

        public void cadastre()
        {
            dado_aluno novoAluno = new dado_aluno();
            novoAluno.Nome = txt_name.Text;
            novoAluno.Peso = Convert.ToDouble(txt_peso.Text);
            novoAluno.Idade = Convert.ToInt32(txt_idade.Text);
            novoAluno.Altura = Convert.ToDouble(txt_altura.Text);
            if (btn_fem.Checked)
            {
                novoAluno.Sexo = 'F';
            }
            else if (btn_mas.Checked)
            {
                novoAluno.Sexo = 'M';
            }

            if (guna2ComboBox1.SelectedItem != null)
            {
                novoAluno.ObjFitness = guna2ComboBox1.SelectedItem.ToString();
            }
            else
            {
                novoAluno.ObjFitness = "Não Informado";
            }

            listaAlunosGeral.Add(novoAluno);

            if (contadorAlunos < vetorAlunosGeral.Length)
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

        private void btn_listar_Click(object sender, EventArgs e)
        {
            // dgvAlunos.DataSource = null;
            // dgvAlunos.DataSource = listaAlunosGeral;
        }

        private void txt_busca_TextChanged(object sender, EventArgs e)
        {
            string termobusca = txt_busca.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termobusca))
            {
                dgvAlunos.DataSource = null;
                dgvAlunos.DataSource = listaAlunosGeral;

                lbl_imc.Text = "IMC do Aluno: ";
                lbl_classificacaoimc.Text = "Classificação do IMC: ";
            }
            else
            {
                var resultadoFiltro = listaAlunosGeral
                    .Where(novoAluno => novoAluno.Nome.ToLower().Contains(termobusca))
                    .ToList();

                dgvAlunos.DataSource = null;
                dgvAlunos.DataSource = resultadoFiltro;

                if (resultadoFiltro.Count == 0)
                {
                    lbl_imc.Text = "IMC do Aluno: ";
                }
                else
                {
                    var primeiroAluno = resultadoFiltro.First();
                    var situacao = lbl_classificacaoimc.Text;
                    double alturaMetros = primeiroAluno.Altura;
                    alturaMetros = alturaMetros / 100;
                    double imcCalculado = primeiroAluno.Peso / (alturaMetros * alturaMetros);
                    lbl_imc.Text = $"IMC de {primeiroAluno.Nome}: {imcCalculado:F2}";
                    if (imcCalculado < 18.5)
                    {
                        lbl_classificacaoimc.Text = "Classificação do IMC: Magreza";
                    }
                    else if (imcCalculado < 25)
                    {
                        lbl_classificacaoimc.Text = "Classificação do IMC: Normal";
                    }
                    else if (imcCalculado < 30)
                    {
                        lbl_classificacaoimc.Text = "Classificação do IMC: Sobrepeso";
                    }
                    else
                    {
                        lbl_classificacaoimc.Text = "Classificação do IMC: Obesidade";
                    }
                }
            }



        }

        private void lbl_imc_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            Close();
            menu.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            Close();
            menu.Show();
        }

        private void txt_busca2_TextChanged(object sender, EventArgs e)
        {
            string termobusca = txt_busca2.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termobusca))
            {
                dvgAluno2.DataSource = null;
                dvgAluno2.DataSource = listaAlunosGeral;
            }
            else
            {
                var resultadoFiltro = listaAlunosGeral
                    .Where(novoAluno => novoAluno.Nome.ToLower().Contains(termobusca))
                    .ToList();

                dvgAluno2.DataSource = null;
                dvgAluno2.DataSource = resultadoFiltro;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            
            if (dvgAluno2.CurrentRow != null && !dvgAluno2.CurrentRow.IsNewRow)
            {
                try
                {
                    if (txt_busca2 != null)
                    {
                        dado_aluno objetoAluno = (dado_aluno)dvgAluno2.CurrentRow.DataBoundItem;
                        if (MessageBox.Show($"Deseja excluir {objetoAluno.Nome}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            listaAlunosGeral.Remove(objetoAluno);
                            txt_busca2_TextChanged(sender, e);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira o Nome do Aluno para prosseguir com a Exclusão!");
                    }
                } 
                catch (InvalidCastException)
                {
                    MessageBox.Show("Erro de tipo.");
                }
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hr.Text = DateTime.Now.ToString("HH:mm");
        }

        private void lst_ranking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GerarRanking()
        {
            lst_ranking.Items.Clear();

            var ranking = listaAlunosGeral
                .OrderByDescending(a =>
                {
                    double altura = a.Altura / 100;
                    return a.Peso / (altura * altura);
                });

            int posicao = 1;

            foreach (var aluno in ranking)
            {
                double altura = aluno.Altura / 100;
                double imc = aluno.Peso / (altura * altura);

                lst_ranking.Items.Add(
                    $"{posicao}º - {aluno.Nome} | IMC: {imc:F2}"
                );

                posicao++;
            }
        }
    }
    }

