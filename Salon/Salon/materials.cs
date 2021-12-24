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
    public partial class materials : Form
    {
        public materials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materials_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT materials.id_materials AS id, materials.name_materials AS type, materials.number AS количество, materials.price AS цена FROM materials", db.getConnection());

            adapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "materials");
            knopka3.DataSource = dataSet.Tables["materials"];
            knopka3.AutoResizeColumns();
        }
    }
}
