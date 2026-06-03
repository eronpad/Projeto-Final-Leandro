using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        Stopwatch cronometro = new Stopwatch();
        private void btn_timer_iniciar_Click(object sender, EventArgs e)
        {


            if (btn_timer_iniciar.Text == ("Parar!"))
            {
                cronometro.Stop();
                double tempo = cronometro.Elapsed.TotalMinutes;
                int teste = cb_exer.SelectedIndex;
                double resultado = tempo * IntesiCalc(teste);
                
                lbl_result_timer.Text += ($"\n Tempo: {tempo:F2} ---> Calorias Gastas {resultado:F2}");
                btn_timer_iniciar.Text = ("Reiniciar!");
            }
            else if (btn_timer_iniciar.Text == ("Reiniciar!"))
            {
                cronometro.Restart();
                btn_timer_iniciar.Text = ("Parar!");
            }
            else
            {
                cronometro.Start();
                btn_timer_iniciar.Text = ("Parar!");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_crono.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            cronometro.Elapsed.Hours,
            cronometro.Elapsed.Minutes,
            cronometro.Elapsed.Seconds,
            cronometro.Elapsed.Milliseconds / 10);
        }
        

        private void cb_exer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_exercicios.Items.Clear();
            int teste = cb_exer.SelectedIndex;

            switch (teste)
            {
                case 0:
                    lst_exercicios.Items.Add("Caminhada Rápida 30 min");
                    lst_exercicios.Items.Add("Corrida Leve 20 min");
                    break;
                case 1:
                    lst_exercicios.Items.Add("Supino Reto 3 x 10");
                    lst_exercicios.Items.Add("Supino Inclinado 3 x 10");
                    lst_exercicios.Items.Add("Supino Declinado 3 x 10");
                    lst_exercicios.Items.Add("Crucifixo Reto 3 x 12");
                    lst_exercicios.Items.Add("Crucifixo Inclinado 3 x 12");
                    lst_exercicios.Items.Add("Cross Over 3 x 12");
                    lst_exercicios.Items.Add("Peck Deck 3 x 12");
                    lst_exercicios.Items.Add("Flexão de Braço 3 x 15");
                    lst_exercicios.Items.Add("Paralelas para Peito 3 x 10");
                    lst_exercicios.Items.Add("Pullover com Halter 3 x 12");


                    break;
                case 2:
                    lst_exercicios.Items.Add("Puxada Frontal 3 x 10");
                    lst_exercicios.Items.Add("Barra Fixa 3 x 8");
                    lst_exercicios.Items.Add("Remada Curvada 3 x 10");
                    lst_exercicios.Items.Add("Remada Unilateral 3 x 10");
                    lst_exercicios.Items.Add("Remada Baixa 3 x 12");
                    lst_exercicios.Items.Add("Pulldown 3 x 12");
                    lst_exercicios.Items.Add("Levantamento Terra 3 x 8");
                    lst_exercicios.Items.Add("Remada Cavalinho 3 x 10");
                    lst_exercicios.Items.Add("Puxada Neutra 3 x 10");
                    lst_exercicios.Items.Add("Remada com Halteres 3 x 12");
                    break;
                case 3:
                    lst_exercicios.Items.Add("Agachamento Livre 4 x 10");
                    lst_exercicios.Items.Add("Leg Press 4 x 12");
                    lst_exercicios.Items.Add("Cadeira Extensora 3 x 15");
                    lst_exercicios.Items.Add("Mesa Flexora 3 x 15");
                    lst_exercicios.Items.Add("Stiff 3 x 12");
                    lst_exercicios.Items.Add("Afundo 3 x 10");
                    lst_exercicios.Items.Add("Passada 3 x 12");
                    lst_exercicios.Items.Add("Agachamento Búlgaro 3 x 10");
                    lst_exercicios.Items.Add("Panturrilha em Pé 4 x 20");
                    lst_exercicios.Items.Add("Panturrilha Sentado 4 x 20");
                    break;
                case 4:
                    lst_exercicios.Items.Add("Burpee 3 x 15");
                    lst_exercicios.Items.Add("Polichinelo 3 x 30");
                    lst_exercicios.Items.Add("Corrida no Lugar 3 x 1 min");
                    lst_exercicios.Items.Add("Mountain Climber 3 x 30 seg");
                    lst_exercicios.Items.Add("Prancha 3 x 45 seg");
                    lst_exercicios.Items.Add("Agachamento Livre 3 x 20");
                    lst_exercicios.Items.Add("Flexão de Braço 3 x 12");
                    lst_exercicios.Items.Add("Abdominal Bicicleta 3 x 20");
                    lst_exercicios.Items.Add("Saltos no Banco 3 x 15");
                    lst_exercicios.Items.Add("Elevação de Joelhos 3 x 30 seg");
                    break;
            }
        }
        static public int IntesiCalc(int teste)
        {
            
            switch (teste)
            {
                case 0:
                    return 1;
                    break;
                case 1:
                    return 2;
                    break;
                case 2:
                    return 3;
                    break;
                case 3:
                    return 4;
                    break;
                case 4:
                    return 5;
                    break;
            }
            return -1;
        }
        
    }
}