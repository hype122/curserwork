using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursa4
{
	public partial class count_bag : Form
	{
		public count_bag()
		{
			InitializeComponent();
            this.Activate();
		}

		static public string price_baggage;
		static public int choised_id_baggage;

		
		private void button1_Click(object sender, EventArgs e)
		{
			
			if(kg_baggage.Value<0) { MessageBox.Show("Введите вес багажа"); return; }
			add_baggage();
				
			ticket pen = new ticket();
			pen.Show();
			
			this.Close();
		}

		private void add_baggage()
		{
			choise_id_baggage();

			Class1 class1 = new Class1();
			class1.openConnection();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO baggage VALUE (@id, @kg)", class1.getConn());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = choised_id_baggage;
            cmd.Parameters.Add("@kg", MySqlDbType.Int32).Value = kg_baggage.Value;
            


            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Багаж занесен в БД");

            }
			else { 
                MessageBox.Show("Банаж не занесен в БД");
				return;
			}

            class1.closeConnection();

			
		}
		
		private void choise_id_baggage()
		{
            Class1 class1 = new Class1();
            class1.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(idbaggage) FROM baggage", class1.getConn());

            MySqlDataReader DR = command.ExecuteReader();

            while (DR.Read())
            {
                 choised_id_baggage = Convert.ToInt32(DR[0]) + 1;
            }


            DR.Close();

            class1.closeConnection();
        }

		private void kg_baggage_ValueChanged(object sender, EventArgs e)
		{
            if (kg_baggage.Value >= 5) { price_baggage = " + 500"; }
            if (kg_baggage.Value >= 10) { price_baggage = " + 1000"; }
            if (kg_baggage.Value >= 15) { price_baggage = " + 1500"; }
            if (kg_baggage.Value >= 20) { price_baggage = " + 2500"; }
            price_bag.Text = price_baggage;
        }
	}
}
