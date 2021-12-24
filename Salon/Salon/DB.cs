using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=salon; SslMode=none");

        public MySqlConnection Connection { get => connection; set => connection = value; }

        public void openConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }


        public void closeConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return Connection;
        }
    }
}
