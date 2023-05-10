namespace Kursa4
{
    partial class Reg_form
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
			this.login_box = new System.Windows.Forms.TextBox();
			this.pass_box = new System.Windows.Forms.TextBox();
			this.name_box = new System.Windows.Forms.TextBox();
			this.surname_box = new System.Windows.Forms.TextBox();
			this.phone_box = new System.Windows.Forms.TextBox();
			this.send_data_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// login_box
			// 
			this.login_box.Location = new System.Drawing.Point(347, 86);
			this.login_box.Name = "login_box";
			this.login_box.Size = new System.Drawing.Size(100, 23);
			this.login_box.TabIndex = 0;
			// 
			// pass_box
			// 
			this.pass_box.Location = new System.Drawing.Point(347, 115);
			this.pass_box.Name = "pass_box";
			this.pass_box.Size = new System.Drawing.Size(100, 23);
			this.pass_box.TabIndex = 1;
			// 
			// name_box
			// 
			this.name_box.Location = new System.Drawing.Point(347, 144);
			this.name_box.Name = "name_box";
			this.name_box.Size = new System.Drawing.Size(100, 23);
			this.name_box.TabIndex = 2;
			// 
			// surname_box
			// 
			this.surname_box.Location = new System.Drawing.Point(347, 173);
			this.surname_box.Name = "surname_box";
			this.surname_box.Size = new System.Drawing.Size(100, 23);
			this.surname_box.TabIndex = 3;
			// 
			// phone_box
			// 
			this.phone_box.Location = new System.Drawing.Point(347, 202);
			this.phone_box.Name = "phone_box";
			this.phone_box.Size = new System.Drawing.Size(100, 23);
			this.phone_box.TabIndex = 4;
			// 
			// send_data_btn
			// 
			this.send_data_btn.Location = new System.Drawing.Point(328, 252);
			this.send_data_btn.Name = "send_data_btn";
			this.send_data_btn.Size = new System.Drawing.Size(141, 23);
			this.send_data_btn.TabIndex = 5;
			this.send_data_btn.Text = "Зарегистрироваться";
			this.send_data_btn.UseVisualStyleBackColor = true;
			this.send_data_btn.Click += new System.EventHandler(this.send_data_btn_Click);
			// 
			// Reg_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.send_data_btn);
			this.Controls.Add(this.phone_box);
			this.Controls.Add(this.surname_box);
			this.Controls.Add(this.name_box);
			this.Controls.Add(this.pass_box);
			this.Controls.Add(this.login_box);
			this.Name = "Reg_form";
			this.Text = "Reg_form";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TextBox login_box;
        private TextBox pass_box;
        private TextBox name_box;
        private TextBox surname_box;
        private TextBox phone_box;
        private Button send_data_btn;
    }
}