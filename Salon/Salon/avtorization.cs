using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Salon
{
    public partial class avtorization : Form
    {

        public static string logUser;

        public avtorization()
        {
            InitializeComponent();
        }

        private void vhod_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `работники` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //MessageBox.Show("passUser");


            //

            




            if (table.Rows.Count > 0)
            {
                this.Hide();
                menu menu = new menu();
                menu.Show();
                int a = table.Rows[0].Field<int>("id_worker");
                logUser = a.ToString();
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void vhod_client_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }
    }
}
