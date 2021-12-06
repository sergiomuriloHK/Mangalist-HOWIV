
namespace Mangalist
{
    partial class MinhaLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_lido = new System.Windows.Forms.Button();
            this.btn_lendo = new System.Windows.Forms.Button();
            this.btn_naoLidos = new System.Windows.Forms.Button();
            this.btn_todosMangas = new System.Windows.Forms.Button();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_manga = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_visualizar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_lista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(270, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 699);
            this.panel1.TabIndex = 0;
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.FlatAppearance.BorderSize = 0;
            this.btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.ForeColor = System.Drawing.Color.White;
            this.btn_visualizar.Location = new System.Drawing.Point(396, 190);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(165, 42);
            this.btn_visualizar.TabIndex = 30;
            this.btn_visualizar.TabStop = false;
            this.btn_visualizar.Text = "VISUALIZAR";
            this.btn_visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_visualizar.UseVisualStyleBackColor = false;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(605, 190);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(121, 42);
            this.btn_excluir.TabIndex = 29;
            this.btn_excluir.TabStop = false;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(43, 235);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(909, 429);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Mangalist.Properties.Resources.imgVisualizar;
            this.pictureBox8.Location = new System.Drawing.Point(354, 191);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Mangalist.Properties.Resources.imgExcluir;
            this.pictureBox7.Location = new System.Drawing.Point(567, 191);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.txt_pesquisa);
            this.panel4.Location = new System.Drawing.Point(732, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 38);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Mangalist.Properties.Resources.imgPesquisa;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.Location = new System.Drawing.Point(37, 6);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(180, 27);
            this.txt_pesquisa.TabIndex = 1;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_lido);
            this.panel2.Controls.Add(this.btn_lendo);
            this.panel2.Controls.Add(this.btn_naoLidos);
            this.panel2.Controls.Add(this.btn_todosMangas);
            this.panel2.Location = new System.Drawing.Point(43, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 89);
            this.panel2.TabIndex = 5;
            // 
            // btn_lido
            // 
            this.btn_lido.BackColor = System.Drawing.Color.White;
            this.btn_lido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_lido.ForeColor = System.Drawing.Color.Black;
            this.btn_lido.Location = new System.Drawing.Point(672, 13);
            this.btn_lido.Name = "btn_lido";
            this.btn_lido.Size = new System.Drawing.Size(212, 62);
            this.btn_lido.TabIndex = 18;
            this.btn_lido.TabStop = false;
            this.btn_lido.Text = "Completo";
            this.btn_lido.UseVisualStyleBackColor = false;
            this.btn_lido.Click += new System.EventHandler(this.btn_lido_Click);
            // 
            // btn_lendo
            // 
            this.btn_lendo.BackColor = System.Drawing.Color.White;
            this.btn_lendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lendo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_lendo.ForeColor = System.Drawing.Color.Black;
            this.btn_lendo.Location = new System.Drawing.Point(454, 13);
            this.btn_lendo.Name = "btn_lendo";
            this.btn_lendo.Size = new System.Drawing.Size(212, 62);
            this.btn_lendo.TabIndex = 17;
            this.btn_lendo.TabStop = false;
            this.btn_lendo.Text = "Lendo";
            this.btn_lendo.UseVisualStyleBackColor = false;
            this.btn_lendo.Click += new System.EventHandler(this.btn_lendo_Click);
            // 
            // btn_naoLidos
            // 
            this.btn_naoLidos.BackColor = System.Drawing.Color.White;
            this.btn_naoLidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_naoLidos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_naoLidos.ForeColor = System.Drawing.Color.Black;
            this.btn_naoLidos.Location = new System.Drawing.Point(236, 13);
            this.btn_naoLidos.Name = "btn_naoLidos";
            this.btn_naoLidos.Size = new System.Drawing.Size(212, 62);
            this.btn_naoLidos.TabIndex = 16;
            this.btn_naoLidos.TabStop = false;
            this.btn_naoLidos.Text = "Não Lido";
            this.btn_naoLidos.UseVisualStyleBackColor = false;
            this.btn_naoLidos.Click += new System.EventHandler(this.btn_naoLidos_Click);
            // 
            // btn_todosMangas
            // 
            this.btn_todosMangas.BackColor = System.Drawing.Color.White;
            this.btn_todosMangas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todosMangas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todosMangas.ForeColor = System.Drawing.Color.Black;
            this.btn_todosMangas.Location = new System.Drawing.Point(18, 13);
            this.btn_todosMangas.Name = "btn_todosMangas";
            this.btn_todosMangas.Size = new System.Drawing.Size(212, 62);
            this.btn_todosMangas.TabIndex = 15;
            this.btn_todosMangas.TabStop = false;
            this.btn_todosMangas.Text = "Todos Mangás";
            this.btn_todosMangas.UseVisualStyleBackColor = false;
            this.btn_todosMangas.Click += new System.EventHandler(this.btn_todosMangas_Click);
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.ForeColor = System.Drawing.Color.White;
            this.lbl_lista.Location = new System.Drawing.Point(46, 181);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(278, 51);
            this.lbl_lista.TabIndex = 4;
            this.lbl_lista.Text = "Todos Mangás";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minha Lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "MANGALIST";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(62, 120);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(0, 28);
            this.lbl_usuario.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Mangalist.Properties.Resources.imgUsuarioBranco;
            this.pictureBox5.Location = new System.Drawing.Point(18, 114);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mangalist.Properties.Resources.imgPerfil;
            this.pictureBox3.Location = new System.Drawing.Point(18, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mangalist.Properties.Resources.imgManga;
            this.pictureBox2.Location = new System.Drawing.Point(18, 323);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mangalist.Properties.Resources.imgLista;
            this.pictureBox1.Location = new System.Drawing.Point(18, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Mangalist.Properties.Resources.imgSair;
            this.pictureBox4.Location = new System.Drawing.Point(18, 571);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // btn_perfil
            // 
            this.btn_perfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_perfil.FlatAppearance.BorderSize = 0;
            this.btn_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perfil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfil.ForeColor = System.Drawing.Color.White;
            this.btn_perfil.Location = new System.Drawing.Point(9, 154);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(255, 42);
            this.btn_perfil.TabIndex = 19;
            this.btn_perfil.TabStop = false;
            this.btn_perfil.Text = "MEU PERFIL";
            this.btn_perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perfil.UseVisualStyleBackColor = false;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_manga
            // 
            this.btn_manga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_manga.FlatAppearance.BorderSize = 0;
            this.btn_manga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manga.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manga.ForeColor = System.Drawing.Color.White;
            this.btn_manga.Location = new System.Drawing.Point(9, 278);
            this.btn_manga.Name = "btn_manga";
            this.btn_manga.Size = new System.Drawing.Size(255, 42);
            this.btn_manga.TabIndex = 26;
            this.btn_manga.TabStop = false;
            this.btn_manga.Text = "MANGÁ";
            this.btn_manga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manga.UseVisualStyleBackColor = false;
            this.btn_manga.Click += new System.EventHandler(this.btn_manga_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.button7.Enabled = false;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(9, 402);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 42);
            this.button7.TabIndex = 27;
            this.button7.TabStop = false;
            this.button7.Text = "MINHA LISTA";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(9, 526);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(255, 42);
            this.btn_sair.TabIndex = 28;
            this.btn_sair.TabStop = false;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // MinhaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_manga);
            this.Controls.Add(this.btn_perfil);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MinhaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANGALIST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MinhaLista_FormClosed);
            this.Load += new System.EventHandler(this.MinhaLista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_lido;
        private System.Windows.Forms.Button btn_lendo;
        private System.Windows.Forms.Button btn_naoLidos;
        private System.Windows.Forms.Button btn_todosMangas;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_manga;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_excluir;
    }
}