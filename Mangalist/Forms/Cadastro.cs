using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mangalist.Classes;

namespace Mangalist
{
    public partial class Cadastro : Form
    {
        Usuario usuario = new Usuario();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //
        // Clique no botão cadastrar
        //
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //
            // verifica se todos os campos estão preenchidos
            //
            if (txt_usuario.Text == "" || txt_nome.Text == "" || txt_sobrenome.Text == "" ||
                txt_nascimento.Text == "" || txt_sexo.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!");
            }
            else
            {
                //
                // Passa informações das TextBox para atributos da classe usuario
                //
                usuario.User = txt_usuario.Text;
                usuario.Nome = txt_nome.Text;
                usuario.Sobrenome = txt_sobrenome.Text;
                usuario.Nascimento = txt_nascimento.Text;
                usuario.Sexo = txt_sexo.Text;
                usuario.Senha = txt_senha.Text;
                //
                // Chama método VerificaUsuario para verificar se nome de usuario já não está sendo utilizado
                //
                if (usuario.VerificaUsuario())
                {
                    //
                    // Se VerificaUsuario retornar true, usuario será cadastrado
                    //
                    usuario.CadatrarUsuario();
                    btn_cancelar.PerformClick();
                }
            }
        }

        //
        // Clique botão cancelar
        //
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //
            // Retorna para formulário de Login
            //
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //
        // Limita número de caracteres para 25 no campo de usuario
        //
        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_usuario.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres para 25 no campo nome
        //
        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_nome.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres para 25 no campo sobrenome
        //
        private void txt_sobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_sobrenome.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres para 25 no campo senha
        //
        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_senha.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
