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
    public partial class client_zayvka : Form
    {
        public client_zayvka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            obslyjivanie obslyjivanie = new obslyjivanie();
            obslyjivanie.Show();
        }

        private void master_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void client_zayvka_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlDataAdapter adapterD = new MySqlDataAdapter();
            MySqlDataAdapter adapterC = new MySqlDataAdapter();

            MySqlCommand commandD = new MySqlCommand("SELECT name_worker FROM работники WHERE id_roles = 2", db.getConnection());
            MySqlCommand commandС = new MySqlCommand("SELECT name_service FROM service", db.getConnection());

            adapterD.SelectCommand = commandD;
            adapterC.SelectCommand = commandС;

            DataSet dataSetD = new DataSet();
            DataSet dataSetC = new DataSet();

            adapterD.Fill(dataSetD, "работники");
            adapterC.Fill(dataSetC, "service");

            for (int i = 0; i < dataSetD.Tables["работники"].Rows.Count; i++)
            {
                master.Items.Add(dataSetD.Tables["работники"].Rows[i]["name_worker"]);
            }

            for (int i = 0; i < dataSetC.Tables["service"].Rows.Count; i++)
            {
                yslyga.Items.Add(dataSetC.Tables["service"].Rows[i]["name_service"]);
            }
        }

        private void zapis_Click(object sender, EventArgs e)
        {
            string mas = master.Items[master.SelectedIndex].ToString();
            string namee = name.Text;
            string phonee = phone.Text;
            int phone1 = Convert.ToInt32(phonee);
            string yslygaa = yslyga.Items[yslyga.SelectedIndex].ToString();
            string dataa = string.Format(data.Value.ToString());

            if (dataa != "")
            {
                dataa = DateTime.Parse(dataa).ToString("yyyyMMdd");
                //date_buy.ToShortDateString();
            }
            else
            {
                data = null;
            }

            DB db = new DB();

            MySqlDataAdapter adapterY = new MySqlDataAdapter();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlDataAdapter adapterM = new MySqlDataAdapter();
            MySqlCommand commandY = new MySqlCommand("SELECT id_service FROM service where name_service = @idY", db.getConnection());
            MySqlCommand commandM = new MySqlCommand("SELECT id_worker FROM работники where name_worker = @idM", db.getConnection());
            MySqlCommand command1 = new MySqlCommand("insert `history_service` (`master`, `name`, `phone`, `client_zayvka_id_service`, `data`) VALUES (@1U, @2U, @3U, @4U, @5U)", db.getConnection());
            commandY.Parameters.Add("@idY", MySqlDbType.VarChar).Value = yslygaa;
            commandM.Parameters.Add("@idM", MySqlDbType.VarChar).Value = mas;

            adapterY.SelectCommand = commandY;
            adapterM.SelectCommand = commandM;

            DataTable tableY = new DataTable();
            DataTable tableM = new DataTable();

            adapterM.Fill(tableM);
            adapterY.Fill(tableY);

            int mas_id = tableM.Rows[0].Field<int>("id_worker");
            int ysl_id = tableY.Rows[0].Field<int>("id_service");

            command1.Parameters.Add("@1U", MySqlDbType.VarChar).Value = mas_id;
            command1.Parameters.Add("@2U", MySqlDbType.VarChar).Value = namee;
            command1.Parameters.Add("@3U", MySqlDbType.VarChar).Value = phone1;
            command1.Parameters.Add("@4U", MySqlDbType.VarChar).Value = ysl_id;
            command1.Parameters.Add("@5U", MySqlDbType.VarChar).Value = dataa;
            
            adapter1.SelectCommand = command1;
            DataSet dataSet = new DataSet();
            adapter1.Fill(dataSet);
        }
    }
}
