﻿using MySql.Data.MySqlClient;
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
    public partial class history_service : Form
    {
        public history_service()
        {
            InitializeComponent();
        }

        private void history_service_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT techtable.idtechtable AS id, techtable.in_number AS Инвентарный_№, techtable.name_tech AS Информация_о_технике_и_характерристика, techtable.date_buy AS Дата_покупки, techtable.cost AS Цена, techtable.status AS Статус, techtable.date_write_off AS Дата_списания,  cabinet.number_cab AS Кабинет, view.name_view AS Вид, person.surname AS Фамилия  FROM techtable, cabinet, view, person WHERE techtable.idview = view.idview AND techtable.idcabinet = cabinet.idcabinet AND techtable.idperson = person.idperson", db.getConnection());
                adapter.SelectCommand = command;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "techtable");
                                             
                dataGridView1.DataSource = dataSet.Tables["techtable"];
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
