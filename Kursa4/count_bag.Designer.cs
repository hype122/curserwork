namespace Kursa4
{
	partial class count_bag
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
            this.kg_baggage = new System.Windows.Forms.TextBox();
            this.accept_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kg_baggage
            // 
            this.kg_baggage.Location = new System.Drawing.Point(159, 126);
            this.kg_baggage.Name = "kg_baggage";
            this.kg_baggage.Size = new System.Drawing.Size(120, 23);
            this.kg_baggage.TabIndex = 1;
            this.kg_baggage.Text = "Кг багажа";
            // 
            // accept_btn
            // 
            this.accept_btn.Location = new System.Drawing.Point(188, 190);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(75, 23);
            this.accept_btn.TabIndex = 3;
            this.accept_btn.Text = "Accept";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // count_bag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 372);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.kg_baggage);
            this.Name = "count_bag";
            this.Text = "count_bag";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TextBox kg_baggage;
		private Button accept_btn;
	}
}