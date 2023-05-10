namespace Kursa4
{
    partial class ticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticket));
            this.name_tic_lbl = new System.Windows.Forms.Label();
            this.name_tic_txt = new System.Windows.Forms.TextBox();
            this.otkuda_tic_lbl = new System.Windows.Forms.Label();
            this.kuda_tic_lbl = new System.Windows.Forms.Label();
            this.Когда = new System.Windows.Forms.Label();
            this.obratno_tic_lbl = new System.Windows.Forms.Label();
            this.txt_otkuda_tic = new System.Windows.Forms.TextBox();
            this.txt_kuda_tic = new System.Windows.Forms.TextBox();
            this.txt_kogda_tic = new System.Windows.Forms.TextBox();
            this.txt_obratno_tic = new System.Windows.Forms.TextBox();
            this.txt_seat_tic = new System.Windows.Forms.TextBox();
            this.txt_aviacompany_tic = new System.Windows.Forms.TextBox();
            this.txt_gate_tic = new System.Windows.Forms.TextBox();
            this.lbl_seat = new System.Windows.Forms.Label();
            this.lbl_aviacompany = new System.Windows.Forms.Label();
            this.lbl_gate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_otmena = new System.Windows.Forms.Button();
            this.btn_send_email = new System.Windows.Forms.Button();
            this.lbl_price_tic = new System.Windows.Forms.Label();
            this.txt_price_tic = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_tic_lbl
            // 
            this.name_tic_lbl.AutoSize = true;
            this.name_tic_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_tic_lbl.Location = new System.Drawing.Point(42, 205);
            this.name_tic_lbl.Name = "name_tic_lbl";
            this.name_tic_lbl.Size = new System.Drawing.Size(94, 15);
            this.name_tic_lbl.TabIndex = 0;
            this.name_tic_lbl.Text = "Имя пассажира";
            this.name_tic_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_tic_txt
            // 
            this.name_tic_txt.Location = new System.Drawing.Point(142, 197);
            this.name_tic_txt.Name = "name_tic_txt";
            this.name_tic_txt.ReadOnly = true;
            this.name_tic_txt.Size = new System.Drawing.Size(170, 23);
            this.name_tic_txt.TabIndex = 5;
            this.name_tic_txt.TextChanged += new System.EventHandler(this.name_tic_txt_TextChanged);
            // 
            // otkuda_tic_lbl
            // 
            this.otkuda_tic_lbl.AutoSize = true;
            this.otkuda_tic_lbl.Location = new System.Drawing.Point(42, 280);
            this.otkuda_tic_lbl.Name = "otkuda_tic_lbl";
            this.otkuda_tic_lbl.Size = new System.Drawing.Size(45, 15);
            this.otkuda_tic_lbl.TabIndex = 6;
            this.otkuda_tic_lbl.Text = "Откуда";
            // 
            // kuda_tic_lbl
            // 
            this.kuda_tic_lbl.AutoSize = true;
            this.kuda_tic_lbl.Location = new System.Drawing.Point(42, 354);
            this.kuda_tic_lbl.Name = "kuda_tic_lbl";
            this.kuda_tic_lbl.Size = new System.Drawing.Size(32, 15);
            this.kuda_tic_lbl.TabIndex = 7;
            this.kuda_tic_lbl.Text = "Куда";
            // 
            // Когда
            // 
            this.Когда.AutoSize = true;
            this.Когда.Location = new System.Drawing.Point(333, 205);
            this.Когда.Name = "Когда";
            this.Когда.Size = new System.Drawing.Size(38, 15);
            this.Когда.TabIndex = 8;
            this.Когда.Text = "Когда";
            // 
            // obratno_tic_lbl
            // 
            this.obratno_tic_lbl.AutoSize = true;
            this.obratno_tic_lbl.Location = new System.Drawing.Point(623, 205);
            this.obratno_tic_lbl.Name = "obratno_tic_lbl";
            this.obratno_tic_lbl.Size = new System.Drawing.Size(55, 15);
            this.obratno_tic_lbl.TabIndex = 9;
            this.obratno_tic_lbl.Text = "Обратно";
            // 
            // txt_otkuda_tic
            // 
            this.txt_otkuda_tic.Location = new System.Drawing.Point(142, 277);
            this.txt_otkuda_tic.Name = "txt_otkuda_tic";
            this.txt_otkuda_tic.ReadOnly = true;
            this.txt_otkuda_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_otkuda_tic.TabIndex = 10;
            // 
            // txt_kuda_tic
            // 
            this.txt_kuda_tic.Location = new System.Drawing.Point(142, 351);
            this.txt_kuda_tic.Name = "txt_kuda_tic";
            this.txt_kuda_tic.ReadOnly = true;
            this.txt_kuda_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_kuda_tic.TabIndex = 11;
            // 
            // txt_kogda_tic
            // 
            this.txt_kogda_tic.Location = new System.Drawing.Point(441, 197);
            this.txt_kogda_tic.Name = "txt_kogda_tic";
            this.txt_kogda_tic.ReadOnly = true;
            this.txt_kogda_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_kogda_tic.TabIndex = 12;
            // 
            // txt_obratno_tic
            // 
            this.txt_obratno_tic.Location = new System.Drawing.Point(717, 197);
            this.txt_obratno_tic.Name = "txt_obratno_tic";
            this.txt_obratno_tic.ReadOnly = true;
            this.txt_obratno_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_obratno_tic.TabIndex = 13;
            // 
            // txt_seat_tic
            // 
            this.txt_seat_tic.Location = new System.Drawing.Point(441, 277);
            this.txt_seat_tic.Name = "txt_seat_tic";
            this.txt_seat_tic.ReadOnly = true;
            this.txt_seat_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_seat_tic.TabIndex = 14;
            this.txt_seat_tic.TextChanged += new System.EventHandler(this.txt_seat_tic_TextChanged);
            // 
            // txt_aviacompany_tic
            // 
            this.txt_aviacompany_tic.Location = new System.Drawing.Point(441, 351);
            this.txt_aviacompany_tic.Name = "txt_aviacompany_tic";
            this.txt_aviacompany_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_aviacompany_tic.TabIndex = 15;
            // 
            // txt_gate_tic
            // 
            this.txt_gate_tic.Location = new System.Drawing.Point(717, 272);
            this.txt_gate_tic.Name = "txt_gate_tic";
            this.txt_gate_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_gate_tic.TabIndex = 16;
            // 
            // lbl_seat
            // 
            this.lbl_seat.AutoSize = true;
            this.lbl_seat.Location = new System.Drawing.Point(333, 280);
            this.lbl_seat.Name = "lbl_seat";
            this.lbl_seat.Size = new System.Drawing.Size(42, 15);
            this.lbl_seat.TabIndex = 17;
            this.lbl_seat.Text = "Место";
            // 
            // lbl_aviacompany
            // 
            this.lbl_aviacompany.AutoSize = true;
            this.lbl_aviacompany.Location = new System.Drawing.Point(333, 354);
            this.lbl_aviacompany.Name = "lbl_aviacompany";
            this.lbl_aviacompany.Size = new System.Drawing.Size(89, 15);
            this.lbl_aviacompany.TabIndex = 18;
            this.lbl_aviacompany.Text = "Авиакомпания";
            // 
            // lbl_gate
            // 
            this.lbl_gate.AutoSize = true;
            this.lbl_gate.Location = new System.Drawing.Point(623, 280);
            this.lbl_gate.Name = "lbl_gate";
            this.lbl_gate.Size = new System.Drawing.Size(47, 15);
            this.lbl_gate.TabIndex = 19;
            this.lbl_gate.Text = "Корпус";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(56, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 68);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btn_otmena);
            this.panel2.Controls.Add(this.btn_send_email);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 36);
            this.panel2.TabIndex = 23;
            // 
            // btn_otmena
            // 
            this.btn_otmena.Location = new System.Drawing.Point(845, 10);
            this.btn_otmena.Name = "btn_otmena";
            this.btn_otmena.Size = new System.Drawing.Size(75, 23);
            this.btn_otmena.TabIndex = 1;
            this.btn_otmena.Text = "Отмена";
            this.btn_otmena.UseVisualStyleBackColor = true;
            this.btn_otmena.Click += new System.EventHandler(this.btn_otmena_Click);
            // 
            // btn_send_email
            // 
            this.btn_send_email.Location = new System.Drawing.Point(749, 10);
            this.btn_send_email.Name = "btn_send_email";
            this.btn_send_email.Size = new System.Drawing.Size(90, 23);
            this.btn_send_email.TabIndex = 0;
            this.btn_send_email.Text = "Распечатать";
            this.btn_send_email.UseVisualStyleBackColor = true;
            this.btn_send_email.Click += new System.EventHandler(this.btn_send_email_Click);
            // 
            // lbl_price_tic
            // 
            this.lbl_price_tic.AutoSize = true;
            this.lbl_price_tic.Location = new System.Drawing.Point(623, 354);
            this.lbl_price_tic.Name = "lbl_price_tic";
            this.lbl_price_tic.Size = new System.Drawing.Size(35, 15);
            this.lbl_price_tic.TabIndex = 24;
            this.lbl_price_tic.Text = "Цена";
            // 
            // txt_price_tic
            // 
            this.txt_price_tic.Location = new System.Drawing.Point(717, 346);
            this.txt_price_tic.Name = "txt_price_tic";
            this.txt_price_tic.ReadOnly = true;
            this.txt_price_tic.Size = new System.Drawing.Size(144, 23);
            this.txt_price_tic.TabIndex = 25;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ticket
            // 
            this.AcceptButton = this.btn_send_email;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btn_otmena;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.ControlBox = false;
            this.Controls.Add(this.txt_price_tic);
            this.Controls.Add(this.lbl_price_tic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_gate);
            this.Controls.Add(this.lbl_aviacompany);
            this.Controls.Add(this.lbl_seat);
            this.Controls.Add(this.txt_gate_tic);
            this.Controls.Add(this.txt_aviacompany_tic);
            this.Controls.Add(this.txt_seat_tic);
            this.Controls.Add(this.txt_obratno_tic);
            this.Controls.Add(this.txt_kogda_tic);
            this.Controls.Add(this.txt_kuda_tic);
            this.Controls.Add(this.txt_otkuda_tic);
            this.Controls.Add(this.obratno_tic_lbl);
            this.Controls.Add(this.Когда);
            this.Controls.Add(this.kuda_tic_lbl);
            this.Controls.Add(this.otkuda_tic_lbl);
            this.Controls.Add(this.name_tic_txt);
            this.Controls.Add(this.name_tic_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ticket";
            this.ShowInTaskbar = false;
            this.Text = "ticket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ticket_FormClosed);
            this.Load += new System.EventHandler(this.ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name_tic_lbl;
        private TextBox name_tic_txt;
        private Label otkuda_tic_lbl;
        private Label kuda_tic_lbl;
        private Label Когда;
        private Label obratno_tic_lbl;
        private TextBox txt_otkuda_tic;
        private TextBox txt_kuda_tic;
        private TextBox txt_kogda_tic;
        private TextBox txt_obratno_tic;
        private TextBox txt_seat_tic;
        private TextBox txt_aviacompany_tic;
        private TextBox txt_gate_tic;
        private Label lbl_seat;
        private Label lbl_aviacompany;
        private Label lbl_gate;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
		private Button btn_otmena;
		private Button btn_send_email;
		private Label lbl_price_tic;
		private TextBox txt_price_tic;
		private PrintDialog printDialog1;
	}
}