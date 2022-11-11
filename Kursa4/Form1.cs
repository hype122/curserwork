using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Kursa4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			
			InitializeComponent();
			
        }
		static public string name;

		public static bool flag = false;
		private void enter_btn_Click(object sender, EventArgs e)
		{

			string logUser = login_textbox.Text;
			string passUser = password_textbox.Text;

			Class1 class1 = new Class1();

            class1.openConnection();
			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand comand = new MySqlCommand("SELECT * FROM users WHERE login = @LU AND password = @PU", class1.getConn());
				comand.Parameters.Add("@LU", MySqlDbType.VarChar).Value = logUser;
				comand.Parameters.Add("@PU", MySqlDbType.VarChar).Value = passUser;

			adapter.SelectCommand = comand;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				flag = true;
				MySqlCommand cmd = new MySqlCommand("SELECT name FROM users WHERE login = @lu", class1.getConn());
				cmd.Parameters.Add("@lu", MySqlDbType.VarChar).Value = logUser;
				MySqlDataReader DR = cmd.ExecuteReader();
				while (DR.Read()) { 
				
					name = DR[0].ToString();
				}
				class1.closeConnection();
                this.Close();
			}

			else
				MessageBox.Show("Invalid data");

		}

		private void login_textbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{


			if (login_textbox.Text.Length < 5)
			{
				errorProvider1.SetError(login_textbox, "This login not valid");
			}
			else { errorProvider1.Clear(); }
		}

		private void password_textbox_Validating(object sender, System.ComponentModel.CancelEventArgs e) { 

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}


		private void reg_btn_Click(object sender, EventArgs e)
		{
			Reg_form reg = new Reg_form();
			reg.Show();
			if (flag == true)
			{
				this.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}


	
	}

