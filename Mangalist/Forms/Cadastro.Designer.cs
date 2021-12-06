
namespace Mangalist
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_sexo = new System.Windows.Forms.ComboBox();
            this.txt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANGALIST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 538);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_sexo);
            this.panel2.Controls.Add(this.txt_nascimento);
            this.panel2.Controls.Add(this.txt_senha);
            this.panel2.Controls.Add(this.txt_sobrenome);
            this.panel2.Controls.Add(this.txt_nome);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_cadastrar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(48, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 484);
            this.panel2.TabIndex = 0;
            // 
            // txt_sexo
            // 
            this.txt_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sexo.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txt_sexo.FormattingEnabled = true;
            this.txt_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.txt_sexo.Location = new System.Drawing.Point(182, 281);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(277, 39);
            this.txt_sexo.TabIndex = 5;
            this.txt_sexo.TabStop = false;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txt_nascimento.Location = new System.Drawing.Point(182, 238);
            this.txt_nascimento.Mask = "00/00/0000";
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(277, 38);
            this.txt_nascimento.TabIndex = 4;
            this.txt_nascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(182, 326);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(277, 38);
            this.txt_senha.TabIndex = 6;
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress);
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sobrenome.Location = new System.Drawing.Point(182, 194);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(277, 38);
            this.txt_sobrenome.TabIndex = 3;
            this.txt_sobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sobrenome_KeyPress);
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(182, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(277, 38);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(182, 106);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(277, 38);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(247, 389);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(212, 62);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(29, 389);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(212, 62);
            this.btn_cadastrar.TabIndex = 7;
            this.btn_cadastrar.TabStop = false;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sobrenome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "CADASTRAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mangalist.Properties.Resources.imgManga;
            this.pictureBox1.Location = new System.Drawing.Point(415, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(582, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANGALIST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastro_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_nascimento;
        private System.Windows.Forms.ComboBox txt_sexo;
    }
}