
namespace Mangalist
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 538);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_cadastrar);
            this.panel2.Controls.Add(this.btn_entrar);
            this.panel2.Controls.Add(this.txt_senha);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(48, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 484);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mangalist.Properties.Resources.imgSenha;
            this.pictureBox3.Location = new System.Drawing.Point(25, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mangalist.Properties.Resources.imgUsuario;
            this.pictureBox2.Location = new System.Drawing.Point(25, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(144, 386);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(212, 71);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.TabStop = false;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(144, 309);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(212, 71);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.TabStop = false;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txt_senha.Location = new System.Drawing.Point(81, 241);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(364, 38);
            this.txt_senha.TabIndex = 2;
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(81, 147);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(364, 38);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(169, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANGALIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mangalist.Properties.Resources.imgManga;
            this.pictureBox1.Location = new System.Drawing.Point(415, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(13)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(582, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANGALIST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

