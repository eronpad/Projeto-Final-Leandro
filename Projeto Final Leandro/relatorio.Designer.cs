namespace Projeto_Final_Leandro
{
    partial class relatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbl_crono = new System.Windows.Forms.Label();
            this.lst_ranking = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.SystemColors.Window;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lbl_crono
            // 
            this.lbl_crono.AutoSize = true;
            this.lbl_crono.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_crono.Location = new System.Drawing.Point(214, 9);
            this.lbl_crono.Name = "lbl_crono";
            this.lbl_crono.Size = new System.Drawing.Size(370, 42);
            this.lbl_crono.TabIndex = 24;
            this.lbl_crono.Text = "Ranking dos Alunos";
            // 
            // lst_ranking
            // 
            this.lst_ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_ranking.FormattingEnabled = true;
            this.lst_ranking.ItemHeight = 25;
            this.lst_ranking.Location = new System.Drawing.Point(199, 93);
            this.lst_ranking.Name = "lst_ranking";
            this.lst_ranking.Size = new System.Drawing.Size(405, 204);
            this.lst_ranking.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(313, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Maior gasto calórico";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Projeto_Final_Leandro.Properties.Resources.logouticon;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(729, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(59, 59);
            this.guna2ImageButton1.TabIndex = 28;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_ranking);
            this.Controls.Add(this.lbl_crono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "relatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_ranking;
        private System.Windows.Forms.Label lbl_crono;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}