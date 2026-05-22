namespace Projeto_Final_Leandro
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.img_exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oiToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.treinosToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oiToolStripMenuItem
            // 
            this.oiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.oiToolStripMenuItem.Name = "oiToolStripMenuItem";
            this.oiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oiToolStripMenuItem.Text = "Arquivo";
            this.oiToolStripMenuItem.Click += new System.EventHandler(this.oiToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // treinosToolStripMenuItem
            // 
            this.treinosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.treinosToolStripMenuItem.Name = "treinosToolStripMenuItem";
            this.treinosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.treinosToolStripMenuItem.Text = "Treinos";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // lbl_hr
            // 
            this.lbl_hr.AutoSize = true;
            this.lbl_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_hr.Location = new System.Drawing.Point(705, 454);
            this.lbl_hr.Name = "lbl_hr";
            this.lbl_hr.Size = new System.Drawing.Size(92, 25);
            this.lbl_hr.TabIndex = 2;
            this.lbl_hr.Text = "Relógio";
            this.lbl_hr.Click += new System.EventHandler(this.lbl_hr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(695, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Logout";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bem-Vindo Professor!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // img_exit
            // 
            this.img_exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Image = global::Projeto_Final_Leandro.Properties.Resources.X1;
            this.img_exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.img_exit.ImageRotate = 0F;
            this.img_exit.ImageSize = new System.Drawing.Size(32, 32);
            this.img_exit.Location = new System.Drawing.Point(766, 26);
            this.img_exit.Name = "img_exit";
            this.img_exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Size = new System.Drawing.Size(49, 50);
            this.img_exit.TabIndex = 7;
            this.img_exit.Click += new System.EventHandler(this.img_exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img_exit);
            this.Controls.Add(this.lbl_hr);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oiToolStripMenuItem;
        private System.Windows.Forms.Label lbl_hr;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treinosToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton img_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}