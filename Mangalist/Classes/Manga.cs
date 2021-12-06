using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mangalist.Classes;
using System.Windows.Forms;

namespace Mangalist.Classes
{
    class Manga:Database
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Pontuacao { get; set; }
        public int Capitulos { get; set; }
        public string Status { get; set; }
        public string Sinopse { get; set; }
        public string User { get; set; }


        //
        // Cadastra um novo mangá
        public void NovoManga()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                //
                // Comando SQL para cadastrar informações no banco de dados
                //
                comando.CommandText = "INSERT INTO manga (mangaTitulo, mangaAutor, mangaPontuacao, mangaCapitulos," +
                    "mangaStatus, mangaSinopse, mangaUsuario) VALUES(@titulo, @autor, @pontuacao, @capitulos," +
                    "@status, @sinopse, @usuario)";

                comando.Parameters.Add("@titulo", MySqlDbType.Text).Value = Titulo;
                comando.Parameters.Add("@autor", MySqlDbType.VarChar).Value = Autor;
                comando.Parameters.Add("@pontuacao", MySqlDbType.VarChar).Value = Pontuacao;
                comando.Parameters.Add("@capitulos", MySqlDbType.Int32).Value = Capitulos;
                comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
                comando.Parameters.Add("@sinopse", MySqlDbType.VarChar).Value = Sinopse;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;

                comando.ExecuteNonQuery();

                MessageBox.Show("Mangá cadastrado com sucesso!");

                conexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar novo mangá no banco de dados", "ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        //
        // Atualiza informações de um mangá;
        public void EditarManga()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                //
                // Comando SQL para atualizar informações do mnagá no banco de dados
                //
                comando.CommandText = "UPDATE manga SET mangaTitulo = @titulo, mangaAutor = @autor," +
                    "mangaPontuacao = @pontuacao, mangaCapitulos = @capitulos, mangaStatus = @status," +
                    "mangaSinopse = @sinopse WHERE mangaUsuario = @usuario and mangaID = @id";

                comando.Parameters.Add("@titulo", MySqlDbType.Text).Value = Titulo;
                comando.Parameters.Add("@autor", MySqlDbType.VarChar).Value = Autor;
                comando.Parameters.Add("@pontuacao", MySqlDbType.VarChar).Value = Pontuacao;
                comando.Parameters.Add("@capitulos", MySqlDbType.Int32).Value = Capitulos;
                comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
                comando.Parameters.Add("@sinopse", MySqlDbType.VarChar).Value = Sinopse;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Id;

                comando.ExecuteNonQuery();

                MessageBox.Show("Informações alteradas com sucesso!");

                conexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi alterar as informações do mangá!", "ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        //
        // Realiza a exclusão de um mangá do banco de dados
        //
        public bool ExcluirManga()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                //
                // Comando SQL para deletar mangá no banco de dados
                //
                comando.CommandText = "DELETE FROM manga WHERE mangaID = @id";
                comando.Parameters.Add("@id", MySqlDbType.Text).Value = Id;

                comando.ExecuteNonQuery();

                MessageBox.Show("Mangá deletado com sucesso!");

                conexaoDB.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar o mangá selecionado!", "ERRO");
                Console.WriteLine(ex.Message);
                return true;
            }
        }

        // Passa as informações para o DataGridView
        public List<Listar> AtualizarLista(string comandoSQL)
        {
            try
            {
                //
                // Cria uma lista da classe Listar
                //
                List<Listar> listar = new List<Listar>();

                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = comandoSQL;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = Status;
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = Titulo;
                MySqlDataReader reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    Listar itens = new Listar
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Título = reader[1].ToString(),
                        Pontuação = reader[2].ToString(),
                        Capítulos = Convert.ToInt32(reader[3]),
                        Status = reader[4].ToString()
                    };

                    //
                    // Adiciona informações a lista
                    //
                    listar.Add(itens);
                }

                conexaoDB.Close();

                //
                // Retorna a lista para adicionar ao DataGridView
                return listar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar o banco de dados!", "ERRO");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //
        // Seleciona as informações de um mangá do banco de dados através de seu ID
        //
        public bool CarregarDados()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "SELECT * FROM manga WHERE mangaUsuario = @usuario and mangaID = @id";
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Id;
                MySqlDataReader reader = comando.ExecuteReader();

                reader.Read();
                Titulo = reader.GetString(1);
                Autor = reader.GetString(2);
                Pontuacao = reader.GetString(3);
                Capitulos = reader.GetInt32(4);
                Status = reader.GetString(5);
                Sinopse = reader.GetString(6);
                reader.Close();

                conexaoDB.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar o banco de dados!", "ERRO");
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
