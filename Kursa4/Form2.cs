using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration.Provider;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Kursa4
{
    public partial class Menu : Form
    {

        public Menu()
        {

            InitializeComponent();
            welcome_lbl.Text += Form1.name;
            otkuda.Text = "Казань";
			kuda.Text = "куда";
			dateTime_kogda.Text = "Когда";
			dateTime_obratno.Text = "Обратно";
            Class1 class1 = new Class1();

			MySqlCommand command = new MySqlCommand("SELECT kuda FROM trip", class1.getConn());

            AutoCompleteStringCollection source_kuda = new AutoCompleteStringCollection();

			class1.openConnection();
			MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                
                source_kuda.Add(DR[0].ToString());

			}
			class1.closeConnection();
            
            kuda.AutoCompleteCustomSource = source_kuda;
			kuda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			kuda.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

        int counter = 4;
        static public int id_passager;
        static public int selected_id=0;
        string kuda_txt;

        private void Menu_Load(object sender, EventArgs e)
        {
			
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        private void kuda_Enter(object sender, EventArgs e)
        {
           
        }

        private void search_Click(object sender, EventArgs e)
        {
            
            if (fio_passager == "")
            {
                MessageBox.Show("Выберите или зарегистрируйте пассажира");
                return;
            }
            else if(kuda.Text==null || dateTime_kogda.Text == null || dateTime_obratno.Text == null || kuda.Text == "куда" || dateTime_kogda.Text == "Когда" || dateTime_obratno.Text == "Обратно")
                {
                MessageBox.Show("Введите рейс правильно");
                return;
            }
            else
            {
                Class1 class1 = new Class1();
                class1.openConnection();

                MySqlCommand command = new MySqlCommand("SELECT idtrip FROM trip WHERE kuda=@kd and kogda=@kg and obratno=@ob", class1.getConn());
                command.Parameters.Add("@kd", MySqlDbType.VarChar).Value = kuda.Text;
                command.Parameters.Add("@kg", MySqlDbType.VarChar).Value = dateTime_kogda.Text;
                command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = dateTime_obratno.Text;
                
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                
                    selected_id = Convert.ToInt32(reader[0]);

                }
                reader.Close();
                if (selected_id==0) { MessageBox.Show("Нет такого рейса"); return;}

                class1.closeConnection();
            }

        }
       

        

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
            string query = "SELECT * FROM trip";
            LoadData(query);
        }


        private void search_otkuda_kuda(object sender, EventArgs e)
        {
           
			

		}

        private void ticket_Click(object sender, EventArgs e)
        {

        }

        private void kuda_Click(object sender, EventArgs e)
        {
			
		}

        private void dateTime_kogda_Click(object sender, EventArgs e)
        {
            dateTime_kogda.Clear();
			Class1 class1 = new Class1();
            kuda_txt = kuda.Text;
			class1.openConnection();
			MySqlCommand command = new MySqlCommand("SELECT kogda FROM trip WHERE kuda=@kd", class1.getConn());
            command.Parameters.Add("@kd", MySqlDbType.VarChar).Value = kuda_txt;

			AutoCompleteStringCollection source_kogda = new AutoCompleteStringCollection();

			MySqlDataReader DR = command.ExecuteReader();

			while (DR.Read())
			{
			
				source_kogda.Add(DR[0].ToString());

			}
			class1.closeConnection();

			dateTime_kogda.AutoCompleteCustomSource = source_kogda;
			dateTime_kogda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			dateTime_kogda.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

        private void dateTime_obratno_Click(object sender, EventArgs e)
        {
            dateTime_obratno.Clear();
			Class1 class1 = new Class1();
			class1.openConnection();

			MySqlCommand command = new MySqlCommand("SELECT obratno FROM trip WHERE kuda=@kd and kogda=@kg", class1.getConn());
			command.Parameters.Add("@kd", MySqlDbType.VarChar).Value = kuda_txt;
			command.Parameters.Add("@kg", MySqlDbType.VarChar).Value = dateTime_kogda.Text;
			AutoCompleteStringCollection source_obratno = new AutoCompleteStringCollection();

			MySqlDataReader DR = command.ExecuteReader();

			while (DR.Read())
			{

				source_obratno.Add(DR[0].ToString());

			}
			class1.closeConnection();

			dateTime_obratno.AutoCompleteCustomSource = source_obratno;
			dateTime_obratno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			dateTime_obratno.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void dateTime_kogda_TextChanged(object sender, EventArgs e)
		{

		}

		private void profile_Enter(object sender, EventArgs e)
		{
			string local_name = Form1.name.ToString();
			name_box_auth.Text = local_name;
			
			Class1 class1 = new Class1();
            class1.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE name = @us", class1.getConn());
            command.Parameters.Add("@us", MySqlDbType.VarChar).Value = local_name;
           

            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
				login_box_auth.Text = DR[1].ToString();
				surname_box_auth.Text = DR[4].ToString();
				phone_box_auth.Text = DR[5].ToString();
            }
            class1.closeConnection();
        }

        private void LoadData(string query)
        {
            trip_grid.Rows.Clear();
            Class1 class1 = new Class1();


            class1.openConnection();

            MySqlCommand command = new MySqlCommand(query, class1.getConn());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            class1.closeConnection();

            foreach (string[] s in data)
                trip_grid.Rows.Add(s);
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            
        }

        private void search_passager_Click(object sender, EventArgs e)
        {
        
            Class1 class1 = new Class1();
            class1.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM passager WHERE passport = @passport", class1.getConn());
            command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = pasport_pass.Text;

            if(command == null) { MessageBox.Show("Пользователя не существует"); class1.closeConnection(); return; }

            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                id_passager = Convert.ToInt32(DR[0]);
                search_passport_pass.Text = DR[0].ToString();
                search_fio_pass.Text = DR[1].ToString();
            }
            class1.closeConnection();

            fio_passager = search_fio_pass.Text;
        }

        private void pasport_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasport_pass_Click(object sender, EventArgs e)
        {
            pasport_pass.Clear();
        }

        private void reg_fio_passager_Click(object sender, EventArgs e)
        {
            reg_fio_passager.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)//reg_passport_passager
        {
            reg_passport_passager.Clear();
        }

        static public string fio_passager = "";


        private void reg_btn_passager_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT passport FROM passager", class1.getConn());

            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                if (DR[0].ToString() == reg_passport_passager.Text) { MessageBox.Show("Пользователь уже существует"); class1.closeConnection(); return; }
            }
            MySqlCommand cmd = new MySqlCommand("INSERT INTO passager(idpassager, FIO, passport) VALUE (@id, @fio, @pass)", class1.getConn());
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = counter++;
            cmd.Parameters.Add("@fio", MySqlDbType.VarChar).Value = reg_fio_passager.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = reg_passport_passager.Text;

            DR.Close();
            

            if (cmd.ExecuteNonQuery() == 1)
            {
                fio_passager = reg_fio_passager.Text;
                MessageBox.Show("Pass create");
                
            }
            else
                MessageBox.Show("Pass not create");




            class1.closeConnection();
        }

        private void kuda_Click_1(object sender, EventArgs e)
        {
            kuda.Clear();
        }

        private void reg_passport_passager_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void trip_grid_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {

        }

        private void btn_grid_search_Click(object sender, EventArgs e)
        {
            trip_grid.Rows.Clear();
            Class1 class1 = new Class1();


            class1.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM trip WHERE kuda=@kd", class1.getConn());
            command.Parameters.Add("@kd", MySqlDbType.VarChar).Value = txt_grid_kuda.Text;

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            class1.closeConnection();

            foreach (string[] s in data)
                trip_grid.Rows.Add(s);
        }

        private void trip_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_grid_accept_Click(object sender, EventArgs e)
        {
            if(fio_passager == "") { MessageBox.Show("Выберите пассажира"); return; }
            selected_id = Convert.ToInt16(trip_grid[0, trip_grid.CurrentCell.RowIndex].Value);
            if (selected_id == 0) { MessageBox.Show("Выберите рейс"); return; }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Выбран рейс номер: " + selected_id.ToString(),
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);


                if (result == DialogResult.Yes)
                {
                    count_bag ecemp2 = new count_bag();
                    ecemp2.Show();

                }
            }
        }
    }
}

