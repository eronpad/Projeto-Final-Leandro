namespace Projeto_Final_Leandro
{
    partial class Aluno
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
            System.Windows.Forms.TabPage tbpg_cadastro;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_limpar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idade = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_peso = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_altura = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_fem = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_mas = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbpg_imc = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.img_exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.combobox_cadastro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_nmcadastro = new System.Windows.Forms.Label();
            this.lbl_classificacaoimc = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dadoalunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objFitnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbpg_cadastro = new System.Windows.Forms.TabPage();
            tbpg_cadastro.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tbpg_imc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadoalunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpg_cadastro
            // 
            tbpg_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            tbpg_cadastro.Controls.Add(this.guna2PictureBox1);
            tbpg_cadastro.Controls.Add(this.btn_limpar);
            tbpg_cadastro.Controls.Add(this.txt_name);
            tbpg_cadastro.Controls.Add(this.txt_idade);
            tbpg_cadastro.Controls.Add(this.guna2ComboBox1);
            tbpg_cadastro.Controls.Add(this.txt_peso);
            tbpg_cadastro.Controls.Add(this.txt_altura);
            tbpg_cadastro.Controls.Add(this.btn_cadastrar);
            tbpg_cadastro.Controls.Add(this.guna2GroupBox1);
            tbpg_cadastro.Controls.Add(this.label5);
            tbpg_cadastro.Controls.Add(this.img_exit);
            tbpg_cadastro.Controls.Add(this.label4);
            tbpg_cadastro.Controls.Add(this.label1);
            tbpg_cadastro.Controls.Add(this.label3);
            tbpg_cadastro.Controls.Add(this.label2);
            tbpg_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbpg_cadastro.Location = new System.Drawing.Point(184, 4);
            tbpg_cadastro.Name = "tbpg_cadastro";
            tbpg_cadastro.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tbpg_cadastro.Size = new System.Drawing.Size(846, 494);
            tbpg_cadastro.TabIndex = 0;
            tbpg_cadastro.Text = "Cadastro";
            tbpg_cadastro.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BorderRadius = 15;
            this.btn_limpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_limpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_limpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_limpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_limpar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.btn_limpar.Location = new System.Drawing.Point(685, 378);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(112, 45);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "Limpar!";
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_name
            // 
            this.txt_name.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_name.BorderRadius = 10;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(377, 106);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceholderText = "Insira o Nome do Aluno:";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(200, 29);
            this.txt_name.TabIndex = 0;
            // 
            // txt_idade
            // 
            this.txt_idade.BorderRadius = 10;
            this.txt_idade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idade.DefaultText = "";
            this.txt_idade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idade.ForeColor = System.Drawing.Color.White;
            this.txt_idade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idade.Location = new System.Drawing.Point(377, 172);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.PlaceholderText = "Insira a Idade do Aluno:";
            this.txt_idade.SelectedText = "";
            this.txt_idade.Size = new System.Drawing.Size(200, 29);
            this.txt_idade.TabIndex = 1;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Lime;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Emagreciemento",
            "Hipertrofia",
            "Resistência",
            "Saúde"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(377, 239);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2ComboBox1.TabIndex = 15;
            // 
            // txt_peso
            // 
            this.txt_peso.BorderRadius = 10;
            this.txt_peso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_peso.DefaultText = "";
            this.txt_peso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_peso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_peso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_peso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_peso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_peso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_peso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_peso.ForeColor = System.Drawing.Color.White;
            this.txt_peso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_peso.Location = new System.Drawing.Point(585, 106);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.PlaceholderText = "80Kg";
            this.txt_peso.SelectedText = "";
            this.txt_peso.Size = new System.Drawing.Size(200, 29);
            this.txt_peso.TabIndex = 2;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // txt_altura
            // 
            this.txt_altura.BorderRadius = 10;
            this.txt_altura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_altura.DefaultText = "";
            this.txt_altura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_altura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_altura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_altura.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_altura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_altura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_altura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_altura.ForeColor = System.Drawing.Color.White;
            this.txt_altura.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_altura.Location = new System.Drawing.Point(585, 172);
            this.txt_altura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.PlaceholderText = "180(cm)";
            this.txt_altura.SelectedText = "";
            this.txt_altura.Size = new System.Drawing.Size(200, 29);
            this.txt_altura.TabIndex = 3;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BorderRadius = 15;
            this.btn_cadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.btn_cadastrar.Location = new System.Drawing.Point(377, 378);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(188, 45);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar Aluno";
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.guna2GroupBox1.Controls.Add(this.btn_fem);
            this.guna2GroupBox1.Controls.Add(this.btn_mas);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(585, 211);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(221, 143);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Sexo:";
            // 
            // btn_fem
            // 
            this.btn_fem.AutoSize = true;
            this.btn_fem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_fem.CheckedState.BorderThickness = 0;
            this.btn_fem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_fem.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btn_fem.CheckedState.InnerOffset = -4;
            this.btn_fem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.btn_fem.Location = new System.Drawing.Point(24, 68);
            this.btn_fem.Name = "btn_fem";
            this.btn_fem.Size = new System.Drawing.Size(113, 29);
            this.btn_fem.TabIndex = 1;
            this.btn_fem.Text = "Feminino";
            this.btn_fem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_fem.UncheckedState.BorderThickness = 2;
            this.btn_fem.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_fem.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btn_mas
            // 
            this.btn_mas.AutoSize = true;
            this.btn_mas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_mas.CheckedState.BorderThickness = 0;
            this.btn_mas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_mas.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btn_mas.CheckedState.InnerOffset = -4;
            this.btn_mas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.btn_mas.Location = new System.Drawing.Point(24, 43);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(121, 29);
            this.btn_mas.TabIndex = 0;
            this.btn_mas.Text = "Masculino";
            this.btn_mas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_mas.UncheckedState.BorderThickness = 2;
            this.btn_mas.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_mas.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.label5.Location = new System.Drawing.Point(383, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Objetivo Fitness:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.label4.Location = new System.Drawing.Point(638, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Altura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(434, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.label3.Location = new System.Drawing.Point(647, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.label2.Location = new System.Drawing.Point(434, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Idade:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(tbpg_cadastro);
            this.guna2TabControl1.Controls.Add(this.tbpg_imc);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(-4, 2);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1034, 502);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 18;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tbpg_imc
            // 
            this.tbpg_imc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.tbpg_imc.Controls.Add(this.guna2DataGridView1);
            this.tbpg_imc.Controls.Add(this.guna2PictureBox3);
            this.tbpg_imc.Controls.Add(this.lbl_classificacaoimc);
            this.tbpg_imc.Controls.Add(this.lbl_nmcadastro);
            this.tbpg_imc.Controls.Add(this.combobox_cadastro);
            this.tbpg_imc.Controls.Add(this.lbl_imc);
            this.tbpg_imc.Location = new System.Drawing.Point(184, 4);
            this.tbpg_imc.Name = "tbpg_imc";
            this.tbpg_imc.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpg_imc.Size = new System.Drawing.Size(846, 494);
            this.tbpg_imc.TabIndex = 1;
            this.tbpg_imc.Text = "Cálculo de IMC";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1002, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_imc.Location = new System.Drawing.Point(434, 133);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(160, 25);
            this.lbl_imc.TabIndex = 17;
            this.lbl_imc.Text = "IMC do Aluno:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Projeto_Final_Leandro.Properties.Resources.Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 99);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(371, 229);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // img_exit
            // 
            this.img_exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Image = global::Projeto_Final_Leandro.Properties.Resources.logouticon;
            this.img_exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.img_exit.ImageRotate = 0F;
            this.img_exit.ImageSize = new System.Drawing.Size(32, 32);
            this.img_exit.Location = new System.Drawing.Point(761, 0);
            this.img_exit.Name = "img_exit";
            this.img_exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_exit.Size = new System.Drawing.Size(59, 59);
            this.img_exit.TabIndex = 7;
            this.img_exit.Click += new System.EventHandler(this.img_exit_Click);
            // 
            // combobox_cadastro
            // 
            this.combobox_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.combobox_cadastro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_cadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_cadastro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_cadastro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_cadastro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_cadastro.ItemHeight = 30;
            this.combobox_cadastro.Location = new System.Drawing.Point(544, 29);
            this.combobox_cadastro.Name = "combobox_cadastro";
            this.combobox_cadastro.Size = new System.Drawing.Size(243, 36);
            this.combobox_cadastro.TabIndex = 18;
            // 
            // lbl_nmcadastro
            // 
            this.lbl_nmcadastro.AutoSize = true;
            this.lbl_nmcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmcadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_nmcadastro.Location = new System.Drawing.Point(50, 28);
            this.lbl_nmcadastro.Name = "lbl_nmcadastro";
            this.lbl_nmcadastro.Size = new System.Drawing.Size(488, 37);
            this.lbl_nmcadastro.TabIndex = 19;
            this.lbl_nmcadastro.Text = "Selecione o Aluno Cadastrado:";
            // 
            // lbl_classificacaoimc
            // 
            this.lbl_classificacaoimc.AutoSize = true;
            this.lbl_classificacaoimc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classificacaoimc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(242)))), ((int)(((byte)(5)))));
            this.lbl_classificacaoimc.Location = new System.Drawing.Point(434, 190);
            this.lbl_classificacaoimc.Name = "lbl_classificacaoimc";
            this.lbl_classificacaoimc.Size = new System.Drawing.Size(241, 25);
            this.lbl_classificacaoimc.TabIndex = 20;
            this.lbl_classificacaoimc.Text = "Classificação do IMC:";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::Projeto_Final_Leandro.Properties.Resources.Logo;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(57, 133);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(371, 229);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 19;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.objFitnessDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.dadoalunoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(439, 250);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(396, 231);
            this.guna2DataGridView1.TabIndex = 21;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dadoalunoBindingSource
            // 
            this.dadoalunoBindingSource.DataSource = typeof(Projeto_Final_Leandro.Aluno.dado_aluno);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "Altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            // 
            // objFitnessDataGridViewTextBoxColumn
            // 
            this.objFitnessDataGridViewTextBoxColumn.DataPropertyName = "ObjFitness";
            this.objFitnessDataGridViewTextBoxColumn.HeaderText = "ObjFitness";
            this.objFitnessDataGridViewTextBoxColumn.Name = "objFitnessDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1027, 499);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            tbpg_cadastro.ResumeLayout(false);
            tbpg_cadastro.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.tbpg_imc.ResumeLayout(false);
            this.tbpg_imc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadoalunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton btn_mas;
        private Guna.UI2.WinForms.Guna2TextBox txt_altura;
        private Guna.UI2.WinForms.Guna2TextBox txt_peso;
        private Guna.UI2.WinForms.Guna2TextBox txt_idade;
        private Guna.UI2.WinForms.Guna2ImageButton img_exit;
        private Guna.UI2.WinForms.Guna2RadioButton btn_fem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_cadastrar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btn_limpar;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbpg_imc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_classificacaoimc;
        private System.Windows.Forms.Label lbl_nmcadastro;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_cadastro;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objFitnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dadoalunoBindingSource;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}