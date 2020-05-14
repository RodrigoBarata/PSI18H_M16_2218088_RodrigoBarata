using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata
{
    class DB
    {
         private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=base_de_dados/proposta;");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
