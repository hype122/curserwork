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

namespace Kursa4
{
    public partial class Form_for_manager : Form
    {
        public Form_for_manager()
        {
            InitializeComponent();
            AutoCompleteStringCollection source_plane = new AutoCompleteStringCollection();
            Class1 class1 = new Class1();

            MySqlCommand command = new MySqlCommand("SELECT idplane FROM plane", class1.getConn());


            class1.openConnection();
            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {

                source_plane.Add(DR[0].ToString());

            }
            class1.closeConnection();

            plane_trip.AutoCompleteCustomSource = source_plane;
            plane_trip.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            plane_trip.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        int selected_id = 0;
        
        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            selected_id = Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value);
            if (selected_id == 0) { MessageBox.Show("Выберите рейс"); return; }
            DialogResult result = MessageBox.Show(
                    "Выбран рейс номер: " + selected_id.ToString(),
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);


            if (result == DialogResult.Yes)
            {
                Class1 class1 = new Class1();


                class1.openConnection();

                MySqlCommand command = new MySqlCommand("DELETE FROM trip WHERE idtrip = @id", class1.getConn());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = selected_id;

                if(command.ExecuteNonQuery() == 1)
                {
                    LoadData();
                    MessageBox.Show("Рейс удален");
                   
                }

                class1.closeConnection();

            }
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            Class1 class1 = new Class1();


            class1.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM trip", class1.getConn());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            class1.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void all_search_trip_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (kuda_trip.Text == null || kogda_trip == null || obratno.Text == null || plane_trip == null || gate_trip.Text == null || plane_trip.Text == null)
            {
                MessageBox.Show("Введите все поля");
                return;
            }

            
           

            Class1 class1 = new Class1();
            class1.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT kuda, otkuda, kogda, obratno, plane,gate, price FROM trip", class1.getConn());

            if(command.ExecuteNonQuery() == 1) { MessageBox.Show("Рейс существует"); return; }

            

            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO trip VALUE (@id, @otkuda, @kuda, @kogda, @obratno, @plane, @gate, @price)", class1.getConn());
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = dataGridView1.RowCount;
            cmd.Parameters.Add("@otkuda", MySqlDbType.VarChar).Value = "Казань";
            cmd.Parameters.Add("@kuda", MySqlDbType.VarChar).Value = kuda_trip.Text;
            cmd.Parameters.Add("@kogda", MySqlDbType.VarChar).Value = kogda_trip.Text;
            cmd.Parameters.Add("@obratno", MySqlDbType.VarChar).Value = obratno.Text;
            cmd.Parameters.Add("@plane", MySqlDbType.Int64).Value = Convert.ToInt64(plane_trip.Text);
            cmd.Parameters.Add("@gate", MySqlDbType.VarChar).Value = gate_trip.Text;
            cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = Convert.ToDecimal(price_trip.Text);




            if (cmd.ExecuteNonQuery() == 1)
            {

                LoadData();
                MessageBox.Show("Рейс создан");
            }
            else
            { MessageBox.Show("Рейс не создан"); LoadData(); }




            class1.closeConnection();
        }

        private void Form_for_manager_Load(object sender, EventArgs e)
        {
            
        }
    }
}
