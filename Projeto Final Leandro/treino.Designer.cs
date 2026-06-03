namespace Projeto_Final_Leandro
{
    partial class treino
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
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lst_exercicios = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_crono = new System.Windows.Forms.Label();
            this.btn_timer_iniciar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_result_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Projeto_Final_Leandro.Properties.Resources.logouticon;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(754, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(59, 59);
            this.guna2ImageButton1.TabIndex = 10;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Lime;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Lime;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Cardio",
            "Peito",
            "Costas",
            "Pernas",
            "Funcional"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(332, 12);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(155, 36);
            this.guna2ComboBox1.TabIndex = 11;
            // 
            // lst_exercicios
            // 
            this.lst_exercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_exercicios.FormattingEnabled = true;
            this.lst_exercicios.ItemHeight = 25;
            this.lst_exercicios.Location = new System.Drawing.Point(573, 108);
            this.lst_exercicios.Name = "lst_exercicios";
            this.lst_exercicios.Size = new System.Drawing.Size(206, 354);
            this.lst_exercicios.TabIndex = 12;
            this.lst_exercicios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_crono
            // 
            this.lbl_crono.AutoSize = true;
            this.lbl_crono.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_crono.Location = new System.Drawing.Point(12, 194);
            this.lbl_crono.Name = "lbl_crono";
            this.lbl_crono.Size = new System.Drawing.Size(268, 42);
            this.lbl_crono.TabIndex = 22;
            this.lbl_crono.Text = "Cronônometro";
            // 
            // btn_timer_iniciar
            // 
            this.btn_timer_iniciar.BorderRadius = 15;
            this.btn_timer_iniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timer_iniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timer_iniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timer_iniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timer_iniciar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_timer_iniciar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timer_iniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.btn_timer_iniciar.Location = new System.Drawing.Point(286, 194);
            this.btn_timer_iniciar.Name = "btn_timer_iniciar";
            this.btn_timer_iniciar.Size = new System.Drawing.Size(188, 45);
            this.btn_timer_iniciar.TabIndex = 23;
            this.btn_timer_iniciar.Text = "Iniciar";
            // 
            // lbl_result_timer
            // 
            this.lbl_result_timer.AutoSize = true;
            this.lbl_result_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_result_timer.Location = new System.Drawing.Point(14, 263);
            this.lbl_result_timer.Name = "lbl_result_timer";
            this.lbl_result_timer.Size = new System.Drawing.Size(137, 25);
            this.lbl_result_timer.TabIndex = 24;
            this.lbl_result_timer.Text = "Resultados:";
            // 
            // treino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.lbl_result_timer);
            this.Controls.Add(this.btn_timer_iniciar);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lst_exercicios);
            this.Controls.Add(this.lbl_crono);
            this.Controls.Add(this.guna2ComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "treino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "treino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.ListBox lst_exercicios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_crono;
        private Guna.UI2.WinForms.Guna2Button btn_timer_iniciar;
        private System.Windows.Forms.Label lbl_result_timer;
    }
}