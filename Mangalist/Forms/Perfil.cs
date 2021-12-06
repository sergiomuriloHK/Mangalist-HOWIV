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
    public partial class Perfil : Form
    {
        Usuario usuario = new Usuario();
        public Perfil(string NomeUsuario)
        {
            InitializeComponent();
            lbl_usuario.Text = NomeUsuario;
        }

        private void Perfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //
        // Clique botão atualizar informações do perfil
        //
        private void btn_att_perfil_Click(object sender, EventArgs e)
        {
            //
            // verifica se todos os campos estão preenchidos
            //
            if (txt_nome.Text == "" || txt_sobrenome.Text == "" || txt_sexo.Text == "" || txt_nascimento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!");
            }
            else
            {
                usuario.User = lbl_usuario.Text;
                usuario.Nome = txt_nome.Text;
                usuario.Sobrenome = txt_sobrenome.Text;
                usuario.Sexo = txt_sexo.Text;
                usuario.Nascimento = txt_nascimento.Text;
                //
                // Atualiza informações do usuario no banco de dados chamando metodo AtualizarDados
                //
                usuario.AtualizarDados();
                AtualizarForm();
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            AtualizarForm();
        }

        //
        // Função AtualizarForm chama metodo SelecionarUsuario para que informações do usuario aparecam no formulário
        //
        private void AtualizarForm()
        {
            usuario.User = lbl_usuario.Text;
            usuario.SelecionarUsuario();
            txt_nome.Text = usuario.Nome;
            txt_sobrenome.Text = usuario.Sobrenome;
            txt_sexo.Text = usuario.Sexo;
            txt_nascimento.Text = usuario.Nascimento;
            txt_senha_atual.Clear();
            txt_nova_senha.Clear();
            txt_confirmar_senha.Clear();
            txt_nome.Focus();
        }

        //
        // Clique botão atualizar senha
        //
        private void btn_att_senha_Click(object sender, EventArgs e)
        {
            //
            // Verifica se todos os campos estão preenchidos
            //
            if (txt_senha_atual.Text == "" || txt_nova_senha.Text == "" || txt_confirmar_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!");
            }
            //
            // Verifica se senhas digitadas coincidem
            //
            else if (txt_nova_senha.Text != txt_confirmar_senha.Text)
            {
                MessageBox.Show("Senhas digitadas não coincidem", "ATENÇÃO!");
                AtualizarForm();
            }
            else
            {
                //
                // Verifica se o campos senha atual foi preenchido corretamente com a senha do usuario
                //
                usuario.Senha = txt_senha_atual.Text;
                if (usuario.VerificaSenha())
                {
                    //
                    // se metodo VerificaSenha retornar true, senha será atualizada
                    //
                    usuario.User = lbl_usuario.Text;
                    usuario.Senha = txt_nova_senha.Text;
                    usuario.AtualizarSenha();
                    AtualizarForm();
                }
                else
                {
                    AtualizarForm();
                }
            }
        }

        //
        // Limita número de caracteres da TextBox nome para 25
        //
        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_nome.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres da TextBox sobrenome para 25
        //
        private void txt_sobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_sobrenome.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres da TextBox senha atual para 25
        //
        private void txt_senha_atual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_senha_atual.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres da TextBox nova senha para 25
        //
        private void txt_nova_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_nova_senha.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Limita número de caracteres da TextBox confirmar senha para 25
        //
        private void txt_confirmar_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_confirmar_senha.Text.Length > 24 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Chama formulario mangaCRUD
        //
        private void btn_manga_Click(object sender, EventArgs e)
        {
            MangaCRUD manga = new MangaCRUD(lbl_usuario.Text);
            manga.Show();
            this.Hide();
        }

        //
        // Chama formulario MinhaLista
        //
        private void bnt_minha_lista_Click(object sender, EventArgs e)
        {
            MinhaLista minhalista = new MinhaLista(lbl_usuario.Text);
            minhalista.Show();
            this.Hide();
        }

        //
        // Leva a tela de login
        //
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
