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
    public partial class Reg_form : Form
    {
        public Reg_form()
        {
            InitializeComponent();
        }

        private void send_data_btn_Click(object sender, EventArgs e)
        {
            if(login_box.Text.Length < 5 || pass_box.Text.Length < 6 || name_box.Text.Length < 2 || surname_box.Text.Length<5 || phone_box.Text.Length < 10)
            {
                MessageBox.Show("Incorrect data");
                return;
            }

            if (checkUser()) { return;}

            Class1 class1 = new Class1();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, password, name, surname, phone) VALUES (@lg, @pass, @name,@surname,@phone)", class1.getConn());
       
            command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = login_box.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass_box.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_box.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_box.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_box.Text;

            class1.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                Form1.flag = true;
                MessageBox.Show("Acc create");
                this.Close();
            }
            else
                MessageBox.Show("Acc not create");

            class1.closeConnection();
        }

        public bool checkUser()
        {
            string logUser = login_box.Text;

			Class1 class1 = new Class1();

			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                MySqlCommand comand = new MySqlCommand("SELECT * FROM users WHERE login = @LU", class1.getConn());
                comand.Parameters.Add("@LU", MySqlDbType.VarChar).Value = logUser;

                adapter.SelectCommand = comand;
                adapter.Fill(table);
				if (table.Rows.Count > 0)
				{
					MessageBox.Show("Такой логин существует");
					return true;
				}
			}
            catch
            {
                if (table.Rows.Count < 0)
                {

                    return false;
                }
            }
            return false;
        }
    }
}
