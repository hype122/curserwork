

namespace Kursa4
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.search_page = new System.Windows.Forms.TabPage();
            this.dateTime_obratno = new System.Windows.Forms.TextBox();
            this.dateTime_kogda = new System.Windows.Forms.TextBox();
            this.kuda = new System.Windows.Forms.TextBox();
            this.otkuda = new System.Windows.Forms.TextBox();
            this.profile_page = new System.Windows.Forms.TabPage();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.surname_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.log_lbl = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.user_anim = new System.Windows.Forms.PictureBox();
            this.phone_box_auth = new System.Windows.Forms.TextBox();
            this.name_box_auth = new System.Windows.Forms.TextBox();
            this.login_box_auth = new System.Windows.Forms.TextBox();
            this.surname_box_auth = new System.Windows.Forms.TextBox();
            this.trip_page = new System.Windows.Forms.TabPage();
            this.trip_grid = new System.Windows.Forms.DataGridView();
            this.id_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otkuda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obratno_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timekogda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_obratno_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passagers = new System.Windows.Forms.TabPage();
            this.reg_pass_panel = new System.Windows.Forms.Panel();
            this.reg_btn_passager = new System.Windows.Forms.Button();
            this.reg_passport_passager = new System.Windows.Forms.TextBox();
            this.reg_fio_passager = new System.Windows.Forms.TextBox();
            this.reg_pass_lbl = new System.Windows.Forms.Label();
            this.search_pass_panel = new System.Windows.Forms.Panel();
            this.seacrh_pass_lbl = new System.Windows.Forms.Label();
            this.search_fio_pass = new System.Windows.Forms.TextBox();
            this.search_passager = new System.Windows.Forms.Button();
            this.search_passport_pass = new System.Windows.Forms.TextBox();
            this.pasport_pass = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.search_page.SuspendLayout();
            this.profile_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_anim)).BeginInit();
            this.trip_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trip_grid)).BeginInit();
            this.passagers.SuspendLayout();
            this.reg_pass_panel.SuspendLayout();
            this.search_pass_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gainsboro;
            this.search.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(632, 109);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(101, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Buy ticket";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.search_page);
            this.tabControl1.Controls.Add(this.profile_page);
            this.tabControl1.Controls.Add(this.trip_page);
            this.tabControl1.Controls.Add(this.passagers);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 430);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // search_page
            // 
            this.search_page.Controls.Add(this.dateTime_obratno);
            this.search_page.Controls.Add(this.dateTime_kogda);
            this.search_page.Controls.Add(this.kuda);
            this.search_page.Controls.Add(this.otkuda);
            this.search_page.Controls.Add(this.search);
            this.search_page.Location = new System.Drawing.Point(4, 24);
            this.search_page.Name = "search_page";
            this.search_page.Padding = new System.Windows.Forms.Padding(3);
            this.search_page.Size = new System.Drawing.Size(768, 402);
            this.search_page.TabIndex = 0;
            this.search_page.Text = "Поиск";
            this.search_page.UseVisualStyleBackColor = true;
            this.search_page.Click += new System.EventHandler(this.ticket_Click);
            // 
            // dateTime_obratno
            // 
            this.dateTime_obratno.Location = new System.Drawing.Point(476, 110);
            this.dateTime_obratno.Name = "dateTime_obratno";
            this.dateTime_obratno.Size = new System.Drawing.Size(100, 23);
            this.dateTime_obratno.TabIndex = 13;
            this.dateTime_obratno.Click += new System.EventHandler(this.dateTime_obratno_Click);
            // 
            // dateTime_kogda
            // 
            this.dateTime_kogda.Location = new System.Drawing.Point(332, 109);
            this.dateTime_kogda.Name = "dateTime_kogda";
            this.dateTime_kogda.Size = new System.Drawing.Size(100, 23);
            this.dateTime_kogda.TabIndex = 12;
            this.dateTime_kogda.Click += new System.EventHandler(this.dateTime_kogda_Click);
            this.dateTime_kogda.TextChanged += new System.EventHandler(this.dateTime_kogda_TextChanged);
            // 
            // kuda
            // 
            this.kuda.Location = new System.Drawing.Point(197, 109);
            this.kuda.Name = "kuda";
            this.kuda.Size = new System.Drawing.Size(100, 23);
            this.kuda.TabIndex = 11;
            this.kuda.Click += new System.EventHandler(this.kuda_Click_1);
            // 
            // otkuda
            // 
            this.otkuda.Location = new System.Drawing.Point(66, 109);
            this.otkuda.Name = "otkuda";
            this.otkuda.Size = new System.Drawing.Size(100, 23);
            this.otkuda.TabIndex = 10;
            // 
            // profile_page
            // 
            this.profile_page.Controls.Add(this.phone_lbl);
            this.profile_page.Controls.Add(this.surname_lbl);
            this.profile_page.Controls.Add(this.name_lbl);
            this.profile_page.Controls.Add(this.log_lbl);
            this.profile_page.Controls.Add(this.welcome_lbl);
            this.profile_page.Controls.Add(this.user_anim);
            this.profile_page.Controls.Add(this.phone_box_auth);
            this.profile_page.Controls.Add(this.name_box_auth);
            this.profile_page.Controls.Add(this.login_box_auth);
            this.profile_page.Controls.Add(this.surname_box_auth);
            this.profile_page.Location = new System.Drawing.Point(4, 24);
            this.profile_page.Name = "profile_page";
            this.profile_page.Padding = new System.Windows.Forms.Padding(3);
            this.profile_page.Size = new System.Drawing.Size(768, 402);
            this.profile_page.TabIndex = 1;
            this.profile_page.Text = "Профиль";
            this.profile_page.UseVisualStyleBackColor = true;
            this.profile_page.Enter += new System.EventHandler(this.profile_Enter);
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_lbl.Location = new System.Drawing.Point(299, 178);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(55, 15);
            this.phone_lbl.TabIndex = 11;
            this.phone_lbl.Text = "Телефон";
            // 
            // surname_lbl
            // 
            this.surname_lbl.AutoSize = true;
            this.surname_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.surname_lbl.Location = new System.Drawing.Point(299, 146);
            this.surname_lbl.Name = "surname_lbl";
            this.surname_lbl.Size = new System.Drawing.Size(58, 15);
            this.surname_lbl.TabIndex = 10;
            this.surname_lbl.Text = "Фамилия";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_lbl.Location = new System.Drawing.Point(299, 117);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(31, 15);
            this.name_lbl.TabIndex = 9;
            this.name_lbl.Text = "Имя";
            // 
            // log_lbl
            // 
            this.log_lbl.AutoSize = true;
            this.log_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log_lbl.Location = new System.Drawing.Point(299, 88);
            this.log_lbl.Name = "log_lbl";
            this.log_lbl.Size = new System.Drawing.Size(41, 15);
            this.log_lbl.TabIndex = 7;
            this.log_lbl.Text = "Логин";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome_lbl.Location = new System.Drawing.Point(275, 21);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(238, 32);
            this.welcome_lbl.TabIndex = 6;
            this.welcome_lbl.Text = "Добро пожаловать, ";
            // 
            // user_anim
            // 
            this.user_anim.Image = ((System.Drawing.Image)(resources.GetObject("user_anim.Image")));
            this.user_anim.Location = new System.Drawing.Point(38, 21);
            this.user_anim.Name = "user_anim";
            this.user_anim.Size = new System.Drawing.Size(192, 167);
            this.user_anim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_anim.TabIndex = 5;
            this.user_anim.TabStop = false;
            // 
            // phone_box_auth
            // 
            this.phone_box_auth.Location = new System.Drawing.Point(413, 175);
            this.phone_box_auth.Name = "phone_box_auth";
            this.phone_box_auth.Size = new System.Drawing.Size(100, 23);
            this.phone_box_auth.TabIndex = 4;
            // 
            // name_box_auth
            // 
            this.name_box_auth.Location = new System.Drawing.Point(413, 114);
            this.name_box_auth.Name = "name_box_auth";
            this.name_box_auth.Size = new System.Drawing.Size(100, 23);
            this.name_box_auth.TabIndex = 3;
            // 
            // login_box_auth
            // 
            this.login_box_auth.Location = new System.Drawing.Point(413, 85);
            this.login_box_auth.Name = "login_box_auth";
            this.login_box_auth.Size = new System.Drawing.Size(100, 23);
            this.login_box_auth.TabIndex = 1;
            // 
            // surname_box_auth
            // 
            this.surname_box_auth.Location = new System.Drawing.Point(413, 143);
            this.surname_box_auth.Name = "surname_box_auth";
            this.surname_box_auth.Size = new System.Drawing.Size(100, 23);
            this.surname_box_auth.TabIndex = 0;
            // 
            // trip_page
            // 
            this.trip_page.Controls.Add(this.trip_grid);
            this.trip_page.Location = new System.Drawing.Point(4, 24);
            this.trip_page.Name = "trip_page";
            this.trip_page.Size = new System.Drawing.Size(768, 402);
            this.trip_page.TabIndex = 2;
            this.trip_page.Text = "Рейсы";
            this.trip_page.UseVisualStyleBackColor = true;
            // 
            // trip_grid
            // 
            this.trip_grid.AllowUserToDeleteRows = false;
            this.trip_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.trip_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trip_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grid,
            this.otkuda_grid,
            this.kuda_grid,
            this.kogda_grid,
            this.obratno_grid,
            this.timekogda_grid,
            this.time_obratno_grid});
            this.trip_grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.trip_grid.Location = new System.Drawing.Point(3, 3);
            this.trip_grid.Name = "trip_grid";
            this.trip_grid.ReadOnly = true;
            this.trip_grid.RowTemplate.Height = 25;
            this.trip_grid.Size = new System.Drawing.Size(762, 396);
            this.trip_grid.TabIndex = 0;
            // 
            // id_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.id_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_grid.HeaderText = "id";
            this.id_grid.Name = "id_grid";
            this.id_grid.ReadOnly = true;
            // 
            // otkuda_grid
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.otkuda_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.otkuda_grid.HeaderText = "Откуда";
            this.otkuda_grid.Name = "otkuda_grid";
            this.otkuda_grid.ReadOnly = true;
            // 
            // kuda_grid
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.kuda_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.kuda_grid.HeaderText = "Куда";
            this.kuda_grid.Name = "kuda_grid";
            this.kuda_grid.ReadOnly = true;
            // 
            // kogda_grid
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.kogda_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.kogda_grid.HeaderText = "Когда";
            this.kogda_grid.Name = "kogda_grid";
            this.kogda_grid.ReadOnly = true;
            // 
            // obratno_grid
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.obratno_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.obratno_grid.HeaderText = "Обратно";
            this.obratno_grid.Name = "obratno_grid";
            this.obratno_grid.ReadOnly = true;
            // 
            // timekogda_grid
            // 
            this.timekogda_grid.HeaderText = "Время";
            this.timekogda_grid.Name = "timekogda_grid";
            this.timekogda_grid.ReadOnly = true;
            // 
            // time_obratno_grid
            // 
            this.time_obratno_grid.HeaderText = "Время";
            this.time_obratno_grid.Name = "time_obratno_grid";
            this.time_obratno_grid.ReadOnly = true;
            // 
            // passagers
            // 
            this.passagers.Controls.Add(this.reg_pass_panel);
            this.passagers.Controls.Add(this.search_pass_panel);
            this.passagers.Location = new System.Drawing.Point(4, 24);
            this.passagers.Name = "passagers";
            this.passagers.Size = new System.Drawing.Size(768, 402);
            this.passagers.TabIndex = 3;
            this.passagers.Text = "Пассажир";
            this.passagers.UseVisualStyleBackColor = true;
            // 
            // reg_pass_panel
            // 
            this.reg_pass_panel.Controls.Add(this.reg_btn_passager);
            this.reg_pass_panel.Controls.Add(this.reg_passport_passager);
            this.reg_pass_panel.Controls.Add(this.reg_fio_passager);
            this.reg_pass_panel.Controls.Add(this.reg_pass_lbl);
            this.reg_pass_panel.Location = new System.Drawing.Point(388, 18);
            this.reg_pass_panel.Name = "reg_pass_panel";
            this.reg_pass_panel.Size = new System.Drawing.Size(377, 369);
            this.reg_pass_panel.TabIndex = 5;
            // 
            // reg_btn_passager
            // 
            this.reg_btn_passager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_btn_passager.Location = new System.Drawing.Point(154, 205);
            this.reg_btn_passager.Name = "reg_btn_passager";
            this.reg_btn_passager.Size = new System.Drawing.Size(75, 23);
            this.reg_btn_passager.TabIndex = 3;
            this.reg_btn_passager.Text = "Добавить";
            this.reg_btn_passager.UseVisualStyleBackColor = true;
            this.reg_btn_passager.Click += new System.EventHandler(this.reg_btn_passager_Click);
            // 
            // reg_passport_passager
            // 
            this.reg_passport_passager.Location = new System.Drawing.Point(106, 97);
            this.reg_passport_passager.Name = "reg_passport_passager";
            this.reg_passport_passager.Size = new System.Drawing.Size(174, 23);
            this.reg_passport_passager.TabIndex = 2;
            this.reg_passport_passager.Text = "Серию и номер паспорта";
            this.reg_passport_passager.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // reg_fio_passager
            // 
            this.reg_fio_passager.Location = new System.Drawing.Point(106, 126);
            this.reg_fio_passager.Name = "reg_fio_passager";
            this.reg_fio_passager.Size = new System.Drawing.Size(174, 23);
            this.reg_fio_passager.TabIndex = 1;
            this.reg_fio_passager.Text = "Введите ФИО";
            this.reg_fio_passager.Click += new System.EventHandler(this.reg_fio_passager_Click);
            // 
            // reg_pass_lbl
            // 
            this.reg_pass_lbl.AutoSize = true;
            this.reg_pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_pass_lbl.Location = new System.Drawing.Point(123, 39);
            this.reg_pass_lbl.Name = "reg_pass_lbl";
            this.reg_pass_lbl.Size = new System.Drawing.Size(139, 15);
            this.reg_pass_lbl.TabIndex = 0;
            this.reg_pass_lbl.Text = "Регистрация пассажира";
            // 
            // search_pass_panel
            // 
            this.search_pass_panel.Controls.Add(this.seacrh_pass_lbl);
            this.search_pass_panel.Controls.Add(this.search_fio_pass);
            this.search_pass_panel.Controls.Add(this.search_passager);
            this.search_pass_panel.Controls.Add(this.search_passport_pass);
            this.search_pass_panel.Controls.Add(this.pasport_pass);
            this.search_pass_panel.Location = new System.Drawing.Point(16, 18);
            this.search_pass_panel.Name = "search_pass_panel";
            this.search_pass_panel.Size = new System.Drawing.Size(366, 369);
            this.search_pass_panel.TabIndex = 4;
            // 
            // seacrh_pass_lbl
            // 
            this.seacrh_pass_lbl.AutoSize = true;
            this.seacrh_pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seacrh_pass_lbl.Location = new System.Drawing.Point(111, 39);
            this.seacrh_pass_lbl.Name = "seacrh_pass_lbl";
            this.seacrh_pass_lbl.Size = new System.Drawing.Size(105, 15);
            this.seacrh_pass_lbl.TabIndex = 4;
            this.seacrh_pass_lbl.Text = "Поиск пассажира";
            // 
            // search_fio_pass
            // 
            this.search_fio_pass.Location = new System.Drawing.Point(91, 205);
            this.search_fio_pass.Name = "search_fio_pass";
            this.search_fio_pass.Size = new System.Drawing.Size(151, 23);
            this.search_fio_pass.TabIndex = 3;
            // 
            // search_passager
            // 
            this.search_passager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_passager.Location = new System.Drawing.Point(224, 97);
            this.search_passager.Name = "search_passager";
            this.search_passager.Size = new System.Drawing.Size(75, 23);
            this.search_passager.TabIndex = 1;
            this.search_passager.Text = "Поиск";
            this.search_passager.UseVisualStyleBackColor = true;
            this.search_passager.Click += new System.EventHandler(this.search_passager_Click);
            // 
            // search_passport_pass
            // 
            this.search_passport_pass.Location = new System.Drawing.Point(91, 176);
            this.search_passport_pass.Name = "search_passport_pass";
            this.search_passport_pass.Size = new System.Drawing.Size(151, 23);
            this.search_passport_pass.TabIndex = 2;
            // 
            // pasport_pass
            // 
            this.pasport_pass.Location = new System.Drawing.Point(16, 98);
            this.pasport_pass.Name = "pasport_pass";
            this.pasport_pass.Size = new System.Drawing.Size(139, 23);
            this.pasport_pass.TabIndex = 0;
            this.pasport_pass.Text = "Пример: 9213-236543";
            this.pasport_pass.Click += new System.EventHandler(this.pasport_pass_Click);
            this.pasport_pass.TextChanged += new System.EventHandler(this.pasport_pass_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.search_page.ResumeLayout(false);
            this.search_page.PerformLayout();
            this.profile_page.ResumeLayout(false);
            this.profile_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_anim)).EndInit();
            this.trip_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trip_grid)).EndInit();
            this.passagers.ResumeLayout(false);
            this.reg_pass_panel.ResumeLayout(false);
            this.reg_pass_panel.PerformLayout();
            this.search_pass_panel.ResumeLayout(false);
            this.search_pass_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button search;
        private TabControl tabControl1;
        private TabPage search_page;
        private TabPage profile_page;
        private TextBox surname_box_auth;
        private TextBox name_box_auth;
        private TextBox login_box_auth;
        private TextBox phone_box_auth;
		private TabPage trip_page;
		private TextBox otkuda;
		private TextBox dateTime_obratno;
		private TextBox dateTime_kogda;
		private TextBox kuda;
        private PictureBox user_anim;
        private Label welcome_lbl;
        private Label phone_lbl;
        private Label surname_lbl;
        private Label name_lbl;
        private Label log_lbl;
        private DataGridView trip_grid;
        private TabPage passagers;
        private Button search_passager;
        private TextBox pasport_pass;
        private Panel reg_pass_panel;
        private Label reg_pass_lbl;
        private Panel search_pass_panel;
        private Label seacrh_pass_lbl;
        private TextBox search_fio_pass;
        private TextBox search_passport_pass;
        private TextBox reg_passport_passager;
        private TextBox reg_fio_passager;
        private Button reg_btn_passager;
        private DataGridViewTextBoxColumn id_grid;
        private DataGridViewTextBoxColumn otkuda_grid;
        private DataGridViewTextBoxColumn kuda_grid;
        private DataGridViewTextBoxColumn kogda_grid;
        private DataGridViewTextBoxColumn obratno_grid;
        private DataGridViewTextBoxColumn timekogda_grid;
        private DataGridViewTextBoxColumn time_obratno_grid;
    }
}