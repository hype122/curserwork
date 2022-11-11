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
	public partial class count_bag : Form
	{
		public count_bag()
		{
			InitializeComponent();
		}

		static public int trip_seat = 0;

		
		private void button1_Click(object sender, EventArgs e)
		{
			
				trip_seat++;
				ticket pen = new ticket();
				pen.Show();
			
			this.Close();
		}

		
		
		
		
	}
}
