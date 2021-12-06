using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mangalist.Classes
{
    class Database
    {
        public MySqlConnection conexaoDB;

        public Database()
        {
            //
            // Realiza conexão com a banco de dados
            //
            string server = "sql10.freemysqlhosting.net";
            string database = "sql10455402";
            string user = "sql10455402";
            string password = "jryqs4hIM3";
            string conexao = "Server = " + server + "; Database =" + database + "; UserID =" + user + "; Password =" + password + "; SslMode=none";
            conexaoDB = new MySqlConnection(conexao);
        }
    }
}
