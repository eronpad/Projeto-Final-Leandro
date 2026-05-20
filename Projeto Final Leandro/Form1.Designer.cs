namespace Projeto_Final_Leandro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.num_altura = new System.Windows.Forms.NumericUpDown();
            this.picbox_edit = new System.Windows.Forms.PictureBox();
            this.btn_imc_calc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.cadastroAlunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cadastroAlunosToolStripMenuItem
            // 
            this.cadastroAlunosToolStripMenuItem.Name = "cadastroAlunosToolStripMenuItem";
            this.cadastroAlunosToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.cadastroAlunosToolStripMenuItem.Text = "Cadastro Alunos";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(288, 108);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(216, 34);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 113);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(270, 29);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Insira o Nome do Aluno:";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.Location = new System.Drawing.Point(12, 164);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(270, 29);
            this.lbl_altura.TabIndex = 5;
            this.lbl_altura.Text = "Insira o Nome do Aluno:";
            // 
            // num_altura
            // 
            this.num_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_altura.InterceptArrowKeys = false;
            this.num_altura.Location = new System.Drawing.Point(288, 159);
            this.num_altura.Maximum = new decimal(new int[] {
            260,
            0,
            0,
            0});
            this.num_altura.Name = "num_altura";
            this.num_altura.ReadOnly = true;
            this.num_altura.Size = new System.Drawing.Size(120, 34);
            this.num_altura.TabIndex = 6;
            // 
            // picbox_edit
            // 
            this.picbox_edit.Image = global::Projeto_Final_Leandro.Properties.Resources.edit_mode;
            this.picbox_edit.Location = new System.Drawing.Point(1137, 31);
            this.picbox_edit.Name = "picbox_edit";
            this.picbox_edit.Size = new System.Drawing.Size(83, 74);
            this.picbox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_edit.TabIndex = 7;
            this.picbox_edit.TabStop = false;
            this.picbox_edit.Click += new System.EventHandler(this.picbox_edit_Click);
            // 
            // btn_imc_calc
            // 
            this.btn_imc_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imc_calc.Location = new System.Drawing.Point(1012, 453);
            this.btn_imc_calc.Name = "btn_imc_calc";
            this.btn_imc_calc.Size = new System.Drawing.Size(208, 41);
            this.btn_imc_calc.TabIndex = 8;
            this.btn_imc_calc.Text = "Calcular IMC";
            this.btn_imc_calc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 506);
            this.Controls.Add(this.btn_imc_calc);
            this.Controls.Add(this.picbox_edit);
            this.Controls.Add(this.num_altura);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Gym";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunosToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.NumericUpDown num_altura;
        private System.Windows.Forms.PictureBox picbox_edit;
        private System.Windows.Forms.Button btn_imc_calc;
    }
}

