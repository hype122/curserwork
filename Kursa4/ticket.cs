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
    public partial class ticket : Form
    {
        public ticket()
        {
            InitializeComponent();
        }

        private void ticket_Load(object sender, EventArgs e)
        {
            name_tic_txt.Text = Menu.fio_passager;
            txt_otkuda_tic.Text = Menu.trip_otkuda;
            txt_kuda_tic.Text = Menu.trip_kuda;
            txt_kogda_tic.Text = Menu.trip_kogda;
            txt_obratno_tic.Text = Menu.trip_obratno;
            txt_seat_tic.Text = Convert.ToString(count_bag.trip_seat);
        }
    }
}
