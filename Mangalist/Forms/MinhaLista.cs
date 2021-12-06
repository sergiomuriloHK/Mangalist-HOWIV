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
    public partial class MinhaLista : Form
    {
        Manga manga = new Manga();
        private string mangaId;

        public MinhaLista(string NomeUsuario)
        {
            InitializeComponent();
            lbl_usuario.Text = NomeUsuario;
        }

        private void MinhaLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //
        // Clique botão sair
        //
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //
        // Clique botão manga
        //
        private void btn_manga_Click(object sender, EventArgs e)
        {
            MangaCRUD manga = new MangaCRUD(lbl_usuario.Text);
            manga.Show();
            this.Hide();
        }

        //
        // Clique botão perfil
        //
        private void btn_perfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(lbl_usuario.Text);
            perfil.Show();
            this.Hide();
        }

        private void MinhaLista_Load(object sender, EventArgs e)
        {
            btn_todosMangas.PerformClick();
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[2].Width = 85;
            dataGridView.Columns[3].Width = 60;
            dataGridView.Columns[4].Width = 100;
        }

        //
        // Clique botão Todos Mangás
        //
        private void btn_todosMangas_Click(object sender, EventArgs e)
        {
            lbl_lista.Text = "Todos Mangás";
            manga.User = lbl_usuario.Text;
            //
            // Chama método atualizar Lista e passa informações para o data GridView
            //
            dataGridView.DataSource = manga.AtualizarLista("SELECT mangaID, mangaTitulo, mangaPontuacao," +
                "mangaCapitulos, mangaStatus FROM manga WHERE mangaUsuario = @usuario ORDER BY mangaTitulo");
        }

        //
        // Clique botão não lidos
        //
        private void btn_naoLidos_Click(object sender, EventArgs e)
        {
            lbl_lista.Text = "Não Lido";
            manga.Status = btn_naoLidos.Text;
            manga.User = lbl_usuario.Text;
            dataGridView.DataSource = manga.AtualizarLista("SELECT mangaID, mangaTitulo, mangaPontuacao," +
                "mangaCapitulos, mangaStatus FROM manga WHERE mangaUsuario = @usuario and mangaStatus = @status ORDER BY mangaTitulo");
        }

        //
        // Clique botão lendo
        //
        private void btn_lendo_Click(object sender, EventArgs e)
        {
            lbl_lista.Text = "Lendo";
            manga.Status = btn_lendo.Text;
            manga.User = lbl_usuario.Text;
            dataGridView.DataSource = manga.AtualizarLista("SELECT mangaID, mangaTitulo, mangaPontuacao," +
                "mangaCapitulos, mangaStatus FROM manga WHERE mangaUsuario = @usuario and mangaStatus = @status ORDER BY mangaTitulo");
        }

        //
        // Clique botão completos
        //
        private void btn_lido_Click(object sender, EventArgs e)
        {
            lbl_lista.Text = "Completo";
            manga.Status = btn_lido.Text;
            manga.User = lbl_usuario.Text;
            dataGridView.DataSource = manga.AtualizarLista("SELECT mangaID, mangaTitulo, mangaPontuacao," +
                "mangaCapitulos, mangaStatus FROM manga WHERE mangaUsuario = @usuario and mangaStatus = @status ORDER BY mangaTitulo");
        }

        //
        // Quando usuario digitar no campo de pesquisa, será chamado AtualizarLista utilizando operador SQL LIKE
        // Será feito uma busca no banco de dados na coluna de titulos de mangás
        // informações encontradas no banco de dados serão passadas ao data grid view
        //
        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            lbl_lista.Text = "Todos Mangás";
            manga.Titulo = txt_pesquisa.Text;
            manga.User = lbl_usuario.Text;
            dataGridView.DataSource = manga.AtualizarLista("SELECT mangaID, mangaTitulo, mangaPontuacao," +
                "mangaCapitulos, mangaStatus FROM manga WHERE mangaUsuario = @usuario and mangaTitulo LIKE '%' @titulo '%' ORDER BY mangaTitulo");
        }

        //
        // Usuario seleciona o mangá através do data grid view
        //
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;
                mangaId = dataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            }
        }

        //
        // Exclui o mangá através de seu ID chamando o método ExcluirManga
        //
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (mangaId != null)
            {
                manga.Id = Convert.ToInt32(mangaId);
                if (manga.ExcluirManga())
                {
                    btn_todosMangas.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha!", "ATENÇÃO");
            }
        }

        //
        // Formulário MangaCRUD é chamado, passando ID do mangá para informações serem visualizadas
        //
        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (mangaId != null)
            {
                MangaCRUD manga = new MangaCRUD(lbl_usuario.Text, mangaId);
                manga.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!", "ATENÇÃO");
            }   
        }
    }
}
