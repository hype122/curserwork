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

		

		
		private void button1_Click(object sender, EventArgs e)
		{
			
				
				ticket pen = new ticket();
				pen.Show();
			
			this.Close();
		}

		
		
		
		
	}
}
