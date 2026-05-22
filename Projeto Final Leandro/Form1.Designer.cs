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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txt_gmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cadastro = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.img_exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txt_gmail
            // 
            this.txt_gmail.BorderRadius = 10;
            this.txt_gmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gmail.DefaultText = "";
            this.txt_gmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gmail.ForeColor = System.Drawing.Color.Black;
            this.txt_gmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gmail.Location = new System.Drawing.Point(308, 254);
            this.txt_gmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.PlaceholderText = "example@email.com";
            this.txt_gmail.SelectedText = "";
            this.txt_gmail.Size = new System.Drawing.Size(221, 33);
            this.txt_gmail.TabIndex = 3;
            this.txt_gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_password
            // 
            this.txt_password.BorderRadius = 10;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(308, 304);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(221, 33);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BorderRadius = 15;
            this.btn_cadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cadastro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.btn_cadastro.Location = new System.Drawing.Point(268, 355);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(295, 45);
            this.btn_cadastro.TabIndex = 7;
            this.btn_cadastro.Text = "Fazer Login como Professor";
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fechar Programa";
            // 
            // img_exit
            // 
            this.img_exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Image = global::Projeto_Final_Leandro.Properties.Resources.X1;
            this.img_exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.img_exit.ImageRotate = 0F;
            this.img_exit.ImageSize = new System.Drawing.Size(32, 32);
            this.img_exit.Location = new System.Drawing.Point(752, 6);
            this.img_exit.Name = "img_exit";
            this.img_exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Size = new System.Drawing.Size(63, 50);
            this.img_exit.TabIndex = 6;
            this.img_exit.Click += new System.EventHandler(this.img_exit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Projeto_Final_Leandro.Properties.Resources.Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(256, 60);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(322, 187);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.img_exit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_gmail);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Gym";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_gmail;
        private Guna.UI2.WinForms.Guna2ImageButton img_exit;
        private Guna.UI2.WinForms.Guna2Button btn_cadastro;
        private System.Windows.Forms.Label label1;
    }
}

