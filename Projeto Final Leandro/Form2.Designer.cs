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
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cronômetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hr = new System.Windows.Forms.Label();
            this.img_exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            this.relatóriosToolStripMenuItem,
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
            this.oiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem,
            this.salvarTXTToolStripMenuItem,
            this.abrirTXTToolStripMenuItem});
            this.oiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.oiToolStripMenuItem.Name = "oiToolStripMenuItem";
            this.oiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oiToolStripMenuItem.Text = "Arquivo";
            this.oiToolStripMenuItem.Click += new System.EventHandler(this.oiToolStripMenuItem_Click);
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoCadastroToolStripMenuItem.Text = "Novo Cadastro";
            // 
            // salvarTXTToolStripMenuItem
            // 
            this.salvarTXTToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.salvarTXTToolStripMenuItem.Name = "salvarTXTToolStripMenuItem";
            this.salvarTXTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarTXTToolStripMenuItem.Text = "Salvar TXT";
            // 
            // abrirTXTToolStripMenuItem
            // 
            this.abrirTXTToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.abrirTXTToolStripMenuItem.Name = "abrirTXTToolStripMenuItem";
            this.abrirTXTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirTXTToolStripMenuItem.Text = "Abrir TXT";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.alunosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // treinosToolStripMenuItem
            // 
            this.treinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cronômetroToolStripMenuItem,
            this.exercíciosToolStripMenuItem});
            this.treinosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.treinosToolStripMenuItem.Name = "treinosToolStripMenuItem";
            this.treinosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.treinosToolStripMenuItem.Text = "Treinos";
            // 
            // cronômetroToolStripMenuItem
            // 
            this.cronômetroToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.cronômetroToolStripMenuItem.Name = "cronômetroToolStripMenuItem";
            this.cronômetroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cronômetroToolStripMenuItem.Text = "Cronômetro";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem,
            this.estatísticasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOSistemaToolStripMenuItem});
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
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
            // img_exit
            // 
            this.img_exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Image = global::Projeto_Final_Leandro.Properties.Resources.X1;
            this.img_exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.img_exit.ImageRotate = 0F;
            this.img_exit.Location = new System.Drawing.Point(790, 26);
            this.img_exit.Name = "img_exit";
            this.img_exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Size = new System.Drawing.Size(25, 25);
            this.img_exit.TabIndex = 7;
            this.img_exit.Click += new System.EventHandler(this.img_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(706, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Logout";
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
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cronômetroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton img_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}