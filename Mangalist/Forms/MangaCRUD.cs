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
    public partial class MangaCRUD : Form
    {
        Manga manga = new Manga();
        bool novo;

        public MangaCRUD(string NomeUsuario, string Id = "")
        {
            InitializeComponent();
            lbl_usuario.Text = NomeUsuario;
            txt_ID.Text = Id;
        }

        private void MangaCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //
        // Limita o número de caracteres da TextBox autor para 50
        //
        private void txt_autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_autor.Text.Length > 49 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Faz com que a TextBox capitulos só receba numeros
        //
        private void txt_capitulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //
        // Retorna ao Login
        //
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //
        // Leva a minha lista
        //
        private void btn_minha_lista_Click(object sender, EventArgs e)
        {
            MinhaLista minhalista = new MinhaLista(lbl_usuario.Text);
            minhalista.Show();
            this.Hide();
        }

        //
        // Leva ao meu perfil
        //
        private void btn_perfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(lbl_usuario.Text);
            perfil.Show();
            this.Hide();
        }

        //
        // Clique botão salvar
        //
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //
            // Verifica se todos os campos estão preenchidos
            //
            if (txt_titulo.Text == "" || txt_autor.Text == "" || txt_capitulos.Text == "" || txt_status.Text == ""
                    || txt_sinopse.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para cadastrar um novo mangá!", "ATENÇÃO");
            }
            else
            {
                //
                // Se variavel novo for true, cadatra um novo mangá no banco de dados
                //
                if (novo)
                {
                    manga.Titulo = txt_titulo.Text;
                    manga.Autor = txt_autor.Text;
                    manga.Pontuacao = txt_pontuação.Text;
                    manga.Capitulos = Convert.ToInt32(txt_capitulos.Text);
                    manga.Status = txt_status.Text;
                    manga.Sinopse = txt_sinopse.Text;
                    manga.User = lbl_usuario.Text;
                    //
                    // Chama metodo NovoManga e cadastra informações digitadas no banco de dados
                    //
                    manga.NovoManga();
                    btn_cancelar.PerformClick();
                }
                //
                // Se variavel novo for false, realiza edição das informações do mangá
                //
                else
                {
                    manga.Titulo = txt_titulo.Text;
                    manga.Autor = txt_autor.Text;
                    manga.Pontuacao = txt_pontuação.Text;
                    manga.Capitulos = Convert.ToInt32(txt_capitulos.Text);
                    manga.Status = txt_status.Text;
                    manga.Sinopse = txt_sinopse.Text;
                    manga.User = lbl_usuario.Text;
                    manga.Id = Convert.ToInt32(txt_ID.Text);
                    manga.EditarManga();
                    btn_cancelar.PerformClick();
                }
            }
        }

        //
        // Clique no botão novo
        //
        private void btn_novo_Click(object sender, EventArgs e)
        {
            //
            // Variável novo recebe true
            //
            novo = true;
            btn_salvar.Enabled = true;
            btn_novo.Enabled = false;
            btn_editar.Enabled = false;
            btn_cancelar.Enabled = true;
            txt_titulo.Enabled = true;
            txt_titulo.Enabled = true;
            txt_autor.Enabled = true;
            txt_pontuação.Enabled = true;
            txt_capitulos.Enabled = true;
            txt_status.Enabled = true;
            txt_sinopse.Enabled = true;
        }

        //
        // Clique no botão editar
        //
        private void btn_editar_Click(object sender, EventArgs e)
        {
            //
            // Variável novo recebe false
            //
            novo = false;
            txt_sinopse.ReadOnly = false;
            btn_salvar.Enabled = true;
            btn_novo.Enabled = false;
            btn_editar.Enabled = false;
            btn_cancelar.Enabled = true;
            txt_titulo.Enabled = true;
            txt_titulo.Focus();
            txt_titulo.Enabled = true;
            txt_autor.Enabled = true;
            txt_pontuação.Enabled = true;
            txt_capitulos.Enabled = true;
            txt_status.Enabled = true;
        }

        //
        // Clique botão cancelar
        //
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_titulo.Focus();
            txt_titulo.Clear();
            txt_autor.Clear();
            txt_pontuação.Text = "";
            txt_capitulos.Clear();
            txt_status.Text = "";
            txt_sinopse.Clear();
            txt_ID.Clear();
            btn_salvar.Enabled = false;
            btn_novo.Enabled = true;
            btn_editar.Enabled = false;
            btn_cancelar.Enabled = false;
            txt_titulo.Enabled = false;
            txt_titulo.Enabled = false;
            txt_autor.Enabled = false;
            txt_pontuação.Enabled = false;
            txt_capitulos.Enabled = false;
            txt_status.Enabled = false;
            txt_sinopse.Enabled = false;
        }

        //
        // Carrega as informações de um mangá através de seu ID
        //
        private void MangaCRUD_Load(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                manga.Id = Convert.ToInt32(txt_ID.Text);
                manga.User = lbl_usuario.Text;
                if (manga.CarregarDados())
                {
                    btn_salvar.Enabled = false;
                    btn_novo.Enabled = false;
                    btn_editar.Enabled = true;
                    btn_cancelar.Enabled = false;
                    txt_sinopse.Enabled = true;
                    txt_sinopse.ReadOnly = true;
                    txt_titulo.Text = manga.Titulo;
                    txt_autor.Text = manga.Autor;
                    txt_pontuação.Text = manga.Pontuacao;
                    txt_capitulos.Text = manga.Capitulos.ToString();
                    txt_status.Text = manga.Status;
                    txt_sinopse.Text = manga.Sinopse;
                }
                else
                {
                    btn_cancelar.Enabled = true;
                    btn_cancelar.PerformClick();
                }
            }
        }
    }
}
