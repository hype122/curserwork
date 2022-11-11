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

namespace Kursa4
{
    public partial class Menu : Form
    {

        public Menu()
        {

            InitializeComponent();
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


        private void Menu_Load(object sender, EventArgs e)
        {
			
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        static public string trip_kuda = "";
        static public string trip_otkuda = "";
        static public string trip_kogda = "";
        static public string trip_obratno = "";


        private void kuda_Enter(object sender, EventArgs e)
        {
           
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (trip_kuda == "" || trip_otkuda == "" || trip_kogda == "" || trip_obratno == "" || fio_passager == "")
            {
                MessageBox.Show("Проверьте данные полета или пассажира");
                return;
            }
            else
            {
                trip_kuda = kuda.Text;
                trip_otkuda = otkuda.Text;
                trip_kogda = dateTime_kogda.Text;
                trip_obratno = dateTime_obratno.Text;
			    MessageBox.Show("Accept");
			    count_bag men = new count_bag();
			    men.Show();
            }

		}
       

        

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            trip_grid.Rows.Clear();
            LoadData();
        }

        string kuda_txt;

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
			welcome_lbl.Text += local_name;
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

        private void LoadData()
        {
            Class1 class1 = new Class1();


            class1.openConnection();

            string query = "SELECT * FROM trip";

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
                search_passport_pass.Text = DR[0].ToString();
                search_fio_pass.Text = DR[1].ToString();
            }
            class1.closeConnection();
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
            
        }

        static public string fio_passager = "";

        private void reg_btn_passager_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM passager", class1.getConn());

            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                if (DR[0].ToString() == reg_passport_passager.Text) { MessageBox.Show("Пользователь уже существует"); class1.closeConnection(); return; }
            }
            MySqlCommand cmd = new MySqlCommand("INSERT INTO passager(idpassager, FIO, passport) VALUE (@id, @fio, @pass)", class1.getConn());
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = 4;
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
    }
}

