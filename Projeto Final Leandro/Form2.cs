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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 100;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadastro = new Aluno();
            cadastro.Show();
        }

        private void img_exit_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            Close();
            tela.Show();
        }

        private void lbl_hr_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hr.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluno Alunos = new Aluno();
            Alunos.Show();
            Hide();

        }

        
    }
}
