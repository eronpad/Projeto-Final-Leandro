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
            this.lbl_commit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_commit
            // 
            this.lbl_commit.AutoSize = true;
            this.lbl_commit.Location = new System.Drawing.Point(536, 296);
            this.lbl_commit.Name = "lbl_commit";
            this.lbl_commit.Size = new System.Drawing.Size(129, 16);
            this.lbl_commit.TabIndex = 0;
            this.lbl_commit.Text = "Label for commit test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 587);
            this.Controls.Add(this.lbl_commit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_commit;
    }
}

