using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

        int seats_plane = 0;
        int plane = 0;
        int id_tickets = 0;

        private void ticket_Load(object sender, EventArgs e)
        {
            name_tic_txt.Text = Menu.fio_passager;
            name_tic_lbl.BackColor = Color.Transparent; name_tic_lbl.ForeColor = Color.Transparent;
            lbl_aviacompany.BackColor = Color.Transparent; lbl_aviacompany.ForeColor = Color.Transparent;
            lbl_gate.BackColor = Color.Transparent; lbl_gate.ForeColor = Color.Transparent;
            lbl_seat.BackColor = Color.Transparent; lbl_seat.ForeColor = Color.Transparent;
            kuda_tic_lbl.BackColor = Color.Transparent; kuda_tic_lbl.ForeColor= Color.Transparent;
            obratno_tic_lbl.BackColor = Color.Transparent; obratno_tic_lbl.ForeColor = Color.Transparent;
            otkuda_tic_lbl.BackColor = Color.Transparent; otkuda_tic_lbl.ForeColor = Color.Transparent;
            Когда.BackColor = Color.Transparent; Когда.ForeColor = Color.Transparent;


			trip_data();// получаемя данные рейса
            plane_avia_and_seatsCount();// получаем данные авиакопаний и места
            choice_seat();// выбираем место и в форму заносим
            choice_id();
            
        }

        private void txt_seat_tic_TextChanged(object sender, EventArgs e)
        {

        }



        // название авиакомпаний и число мест в самолете
        private void plane_avia_and_seatsCount()
        {
            Class1 class1 = new Class1();

            class1.openConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT aviacompany.name, plane.seats FROM plane INNER JOIN aviacompany ON plane.idplane = aviacompany.idaviacompany WHERE plane.idplane = @plid", class1.getConn());
            cmd.Parameters.Add("@plid", MySqlDbType.Int64).Value = plane;

            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                txt_aviacompany_tic.Text = DR[0].ToString();
                seats_plane = Convert.ToInt32(DR[1]);
            }

            DR.Close();

            class1.closeConnection();
        }

        // Данные рейса заносятся в форму
        private void trip_data()
        {

            Class1 class1 = new Class1();

            class1.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM trip WHERE idtrip = @id ", class1.getConn());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = Menu.selected_id;

            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                plane = Convert.ToInt16(reader[5]);
                txt_otkuda_tic.Text = reader[1].ToString();
                txt_kuda_tic.Text = reader[2].ToString();
                txt_kogda_tic.Text = reader[3].ToString();
                txt_obratno_tic.Text = reader[4].ToString();
                txt_gate_tic.Text = reader[6].ToString();
                txt_users_tic.Text = Form1.id_user.ToString();
            }
            reader.Close();

            class1.closeConnection();
        }


        // выбор места в форму
        private void choice_seat()
        {
            Class1 class1 = new Class1();

            class1.openConnection();

            MySqlCommand command_seat = new MySqlCommand("SELECT COUNT(seat) FROM ticket WHERE trip = @id ", class1.getConn());
            command_seat.Parameters.Add("@id", MySqlDbType.Int64).Value = Menu.selected_id;

            MySqlDataReader reader_seat = command_seat.ExecuteReader();

            while (reader_seat.Read())
            {

                txt_seat_tic.Text = (Convert.ToInt32(reader_seat[0])+1).ToString();
            }

            reader_seat.Close();

            class1.closeConnection();

        }

        // выбрать айди тикета
        private void choice_id()
        {
            Class1 class1 = new Class1();

            class1.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(id_tic) FROM ticket ", class1.getConn());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                id_tickets = Convert.ToInt16(reader[0])+1;
            }

            reader.Close();

            class1.closeConnection();
        }


        /// Заносим тикет в бд
        private void ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thanks");
            Menu.fio_passager = "";
            Menu.selected_id = 0;
        }


        //заносим в таблицу тикет
        private void insert_ticket()
        {
            if (Menu.fio_passager=="" || Menu.selected_id == 0) { MessageBox.Show("Неверные данне");return; }

            Class1 class1 = new Class1();



            MySqlCommand command = new MySqlCommand("INSERT INTO ticket (id_tic, passager, user, trip, seat) VALUES (@id, @passager, @user,@trip,@seat)", class1.getConn());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id_tickets;
            command.Parameters.Add("@passager", MySqlDbType.Int32).Value = Menu.id_passager;
            command.Parameters.Add("@user", MySqlDbType.Int32).Value = Form1.id_user;
            command.Parameters.Add("@trip", MySqlDbType.Int32).Value = Menu.selected_id;
            command.Parameters.Add("@seat", MySqlDbType.Int32).Value = txt_seat_tic.Text;

            class1.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Билет занесен в БД");
            }
            else
                MessageBox.Show("Error Не занесен");

            class1.closeConnection();
        }

        private void name_tic_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_otmena_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show(
					"Вы уверены что хотите отменить",
					"Сообщение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);


			if (result == DialogResult.Yes)
			{
				plane = 0;
                seats_plane = 0;
				txt_otkuda_tic.Clear();
				txt_kuda_tic.Clear();
				txt_kogda_tic.Clear();
				txt_obratno_tic.Clear();
				txt_gate_tic.Clear();
				txt_users_tic.Clear();
                name_tic_txt.Clear();
                txt_seat_tic.Clear();
                txt_users_tic.Clear();
                txt_aviacompany_tic.Clear();
			}
		}

        private void btn_send_email_Click(object sender, EventArgs e)
        {
            insert_ticket();
			
			var ctrl = this;
			Bitmap bmp = new Bitmap(ctrl.Width, ctrl.Height);
			ctrl.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
			

				// отправитель - устанавливаем адрес и отображаемое в письме имя
				MailAddress from = new MailAddress("alfred5655565556@gmail.com", "Tom");
				// кому отправляем
				MailAddress to = new MailAddress("sosupenis2010@gmail.com");
				// создаем объект сообщения
				MailMessage m = new MailMessage(from, to);
			// тема письма
			    m.Attachments.Add(new Attachment("D://temlog.txt"));
			    m.Subject = "";
				// текст письма
				m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
				// письмо представляет код html
				m.IsBodyHtml = true;
				// адрес smtp-сервера и порт, с которого будем отправлять письмо
				SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
				// логин и пароль
				smtp.Credentials = new NetworkCredential("sosupenis@gmail.com", "Alfred2003");
				smtp.EnableSsl = true;
				smtp.Send(m);
				Console.Read();


		}
    }
}
