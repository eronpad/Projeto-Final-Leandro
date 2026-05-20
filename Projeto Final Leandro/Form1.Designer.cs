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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_imc_calc = new System.Windows.Forms.Button();
            this.picbox_edit = new System.Windows.Forms.PictureBox();
            this.num_altura = new System.Windows.Forms.NumericUpDown();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 506);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_imc_calc);
            this.tabPage2.Controls.Add(this.picbox_edit);
            this.tabPage2.Controls.Add(this.num_altura);
            this.tabPage2.Controls.Add(this.lbl_altura);
            this.tabPage2.Controls.Add(this.lbl_nome);
            this.tabPage2.Controls.Add(this.txt_nome);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_imc_calc
            // 
            this.btn_imc_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imc_calc.Location = new System.Drawing.Point(1013, 429);
            this.btn_imc_calc.Name = "btn_imc_calc";
            this.btn_imc_calc.Size = new System.Drawing.Size(208, 41);
            this.btn_imc_calc.TabIndex = 20;
            this.btn_imc_calc.Text = "Calcular IMC";
            this.btn_imc_calc.UseVisualStyleBackColor = true;
            // 
            // picbox_edit
            // 
            this.picbox_edit.Image = global::Projeto_Final_Leandro.Properties.Resources.edit_mode;
            this.picbox_edit.Location = new System.Drawing.Point(1133, 6);
            this.picbox_edit.Name = "picbox_edit";
            this.picbox_edit.Size = new System.Drawing.Size(83, 74);
            this.picbox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_edit.TabIndex = 19;
            this.picbox_edit.TabStop = false;
            // 
            // num_altura
            // 
            this.num_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_altura.InterceptArrowKeys = false;
            this.num_altura.Location = new System.Drawing.Point(280, 161);
            this.num_altura.Maximum = new decimal(new int[] {
            260,
            0,
            0,
            0});
            this.num_altura.Name = "num_altura";
            this.num_altura.ReadOnly = true;
            this.num_altura.Size = new System.Drawing.Size(120, 34);
            this.num_altura.TabIndex = 18;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.Location = new System.Drawing.Point(4, 166);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(270, 29);
            this.lbl_altura.TabIndex = 17;
            this.lbl_altura.Text = "Insira o Nome do Aluno:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(4, 115);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(270, 29);
            this.lbl_nome.TabIndex = 16;
            this.lbl_nome.Text = "Insira o Nome do Aluno:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(280, 110);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(216, 34);
            this.txt_nome.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Gym";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_imc_calc;
        private System.Windows.Forms.PictureBox picbox_edit;
        private System.Windows.Forms.NumericUpDown num_altura;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
    }
}

