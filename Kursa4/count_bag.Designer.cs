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
            this.accept_btn = new System.Windows.Forms.Button();
            this.kg_baggage = new System.Windows.Forms.NumericUpDown();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.price_bag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kg_baggage)).BeginInit();
            this.SuspendLayout();
            // 
            // accept_btn
            // 
            this.accept_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.accept_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accept_btn.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.accept_btn.Location = new System.Drawing.Point(48, 122);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(95, 30);
            this.accept_btn.TabIndex = 3;
            this.accept_btn.Text = "Принять";
            this.accept_btn.UseVisualStyleBackColor = false;
            this.accept_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kg_baggage
            // 
            this.kg_baggage.Location = new System.Drawing.Point(48, 64);
            this.kg_baggage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.kg_baggage.Name = "kg_baggage";
            this.kg_baggage.Size = new System.Drawing.Size(95, 23);
            this.kg_baggage.TabIndex = 4;
            this.kg_baggage.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.kg_baggage.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.kg_baggage.ValueChanged += new System.EventHandler(this.kg_baggage_ValueChanged);
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(39, 29);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(116, 15);
            this.lbl_kg.TabIndex = 5;
            this.lbl_kg.Text = "Введите вес багажа:";
            // 
            // price_bag
            // 
            this.price_bag.Location = new System.Drawing.Point(48, 93);
            this.price_bag.Name = "price_bag";
            this.price_bag.ReadOnly = true;
            this.price_bag.Size = new System.Drawing.Size(95, 23);
            this.price_bag.TabIndex = 6;
            // 
            // count_bag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(198, 181);
            this.Controls.Add(this.price_bag);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.kg_baggage);
            this.Controls.Add(this.accept_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "count_bag";
            this.ShowIcon = false;
            this.Text = "Вес багажа";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.kg_baggage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Button accept_btn;
        private NumericUpDown kg_baggage;
        private Label lbl_kg;
        private TextBox price_bag;
    }
}
