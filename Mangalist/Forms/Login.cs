using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mangalist.Classes;

namespace Mangalist
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //
        // Clique no botão entrar
        //
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            //
            // Verifica se campos usuario e senha estão preenchidos
            //
            if (txt_usuario.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Preencha os campos Usuário e Senha!", "ATENÇÃO!");
            }
            else
            {
                usuario.User = txt_usuario.Text;
                usuario.Senha = txt_senha.Text;
                //
                // Chama metodo RealizaLogin e verifica se informações estão corretas
                //
                if (usuario.RealizaLogin())
                {
                    //
                    // Se retornar true formulário minha lista será aberto
                    //
                    MinhaLista minhaLista = new MinhaLista(txt_usuario.Text);
                    minhaLista.Show();
                    this.Hide();
                }
                else
                {
                    //
                    // Senão campos digitados serão limpos
                    //
                    txt_senha.Clear();
                    txt_usuario.Clear();
                    txt_usuario.Focus();
                }
            }
        }

        //
        // Clique no botão cadastrar leva ao formulário de cadastro
        //
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        //
        // Limita o número de caracteres na TextBox usuario para 25
        //
        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_usuario.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita o número de caracteres na TextBox senha para 25
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
