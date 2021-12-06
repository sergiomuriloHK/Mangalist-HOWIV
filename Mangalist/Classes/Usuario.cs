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
    class Usuario:Database
    {
        public string User { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Senha { get; set; }

        //
        // Usuario realiza login
        //
        public bool RealizaLogin()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "SELECT userUsuario, userSenha FROM usuario WHERE userUsuario = @usuario and userSenha = @senha";

                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    //
                    // Retorna true se usuario e senha corresponderem o que foi cadastrado no banco de dados
                    //
                    conexaoDB.Close();
                    return true;
                }
                else
                {
                    //
                    // Retorna false se usuario e senha forem inválidos
                    //
                    MessageBox.Show("Usuário ou senha inválidos!", "ATENÇÃO");
                    conexaoDB.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                //
                // Também retornará false se não conseguir se der algum erro e não for possivel conectar ao banco de dados
                //
                MessageBox.Show("Não foi possível acessar o banco de dados!", "ERRO");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //
        // Realiza o cadastro de um usuario
        //
        public void CadatrarUsuario()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "INSERT INTO usuario(userUsuario, userNome, userSobrenome, userNascimento, userSexo, userSenha)" +
                    "VALUES(@usuario, @nome, @sobrenome, @nascimento, @sexo, @senha)";

                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
                comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = Sobrenome;
                comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = Convert.ToDateTime(Nascimento);
                comando.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = Sexo;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;

                comando.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com sucesso!");

                conexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gravar informações no banco de dados!", "ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        //
        // Verifica se um nome de usuario já foi cadastrado anteriormente
        //
        public bool VerificaUsuario()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "SELECT userUsuario FROM usuario WHERE userUsuario = @usuario";
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    //
                    // Caso já tenha sido cadastrado, retornará false e usuario não será cadastrado
                    //
                    MessageBox.Show("Nome de usuário já existente!", "ATENÇÃO");
                    conexaoDB.Close();
                    return false;
                }
                else
                {
                    //
                    // Senão cadastro poderá ser realizado
                    //
                    conexaoDB.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!", "ERRO");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //
        // seleciona as informações do usuario logado
        //
        public void SelecionarUsuario()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "SELECT * FROM usuario WHERE userUsuario = @usuario";
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;

                
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();

                Nome = reader.GetString(2);
                Sobrenome = reader.GetString(3);
                Nascimento = reader.GetDateTime(4).ToString();
                Sexo = reader.GetString(5);
                Senha = reader.GetString(6);

                conexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!", "ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        //
        // Verifica se senha digitada pelo usuario corresponde a cadastrada no banco de dados para realizar a troca da senha
        //
        public bool VerificaSenha()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "SELECT userSenha FROM usuario WHERE userUsuario = @usuario and userSenha = @senha";
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    //
                    // Retorna true se as senhas corresponderem
                    //
                    conexaoDB.Close();
                    return true;
                }
                else
                {
                    //
                    // Senão retorna false e usuário não poderá atualizar sua senha
                    //
                    MessageBox.Show("Senha Atual está incorreta!", "ATENÇÃO");
                    conexaoDB.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alteara a senha!", "ERRO");
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }

        //
        // Atualiza senha do usuario
        //
        public void AtualizarSenha()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "UPDATE usuario SET userSenha = @senha WHERE userUsuario = @usuario";
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
                comando.ExecuteNonQuery();

                MessageBox.Show("Senha atualizada com sucesso!");

                conexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível altearar a senha!", "ERRO");
                Console.WriteLine(ex.Message);
            }
        }

        //
        // Atualiza outras informações do usuario (nome, sobrenome, data de nascimento e sexo)
        //
        public void AtualizarDados()
        {
            try
            {
                conexaoDB.Open();

                MySqlCommand comando = conexaoDB.CreateCommand();
                comando.CommandText = "UPDATE usuario SET userNome = @nome, userSobrenome = @sobrenome," +
                    "userNascimento = @nascimento, userSexo = @sexo WHERE userUsuario = @usuario";
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = User;
                comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
                comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = Sobrenome;
                comando.Parameters.Add("@nascimento", MySqlDbType.DateTime).Value = Convert.ToDateTime(Nascimento);
                comando.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = Sexo;
                comando.ExecuteNonQuery();

                MessageBox.Show("Informações atualizadas com sucesso!");

                conexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar as informações!", "ERRO");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
