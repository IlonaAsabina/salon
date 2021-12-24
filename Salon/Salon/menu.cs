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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void service_Click(object sender, EventArgs e)
        {
            this.Hide();
            service service = new service();
            service.Show();
        }

        private void client_zayvka_Click(object sender, EventArgs e)
        {
            this.Hide();
            client_zayvka clent_zayvka = new client_zayvka();
            clent_zayvka.Show();
        }

        private void zakaz_Click(object sender, EventArgs e)
        {
            this.Hide();
            zakaz zakaz = new zakaz();
            zakaz.Show();
        }

        private void materials_Click(object sender, EventArgs e)
        {
            this.Hide();
            materials materials = new materials();
            materials.Show();
        }

        private void reviews_Click(object sender, EventArgs e)
        {
            this.Hide();
            reviews reviews = new reviews();
            reviews.Show();
        }

        private void zayvka_Click(object sender, EventArgs e)
        {
            this.Hide();
            zakaz zakaz = new zakaz();
            zakaz.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT service.id_service AS id, service.name_service AS name_serv, service.price AS price FROM service", db.getConnection());

            adapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "service");

            knopka.DataSource = dataSet.Tables["service"];
            knopka.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            history_service history_service = new history_service();
            history_service.Show();
        }
    }
}
