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
            ((System.ComponentModel.ISupportInitialize)(this.kg_baggage)).BeginInit();
            this.SuspendLayout();
            // 
            // accept_btn
            // 
            this.accept_btn.Location = new System.Drawing.Point(143, 190);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(75, 23);
            this.accept_btn.TabIndex = 3;
            this.accept_btn.Text = "Accept";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kg_baggage
            // 
            this.kg_baggage.Location = new System.Drawing.Point(143, 161);
            this.kg_baggage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.kg_baggage.Name = "kg_baggage";
            this.kg_baggage.Size = new System.Drawing.Size(75, 23);
            this.kg_baggage.TabIndex = 4;
            this.kg_baggage.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.kg_baggage.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // count_bag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 372);
            this.Controls.Add(this.kg_baggage);
            this.Controls.Add(this.accept_btn);
            this.Name = "count_bag";
            this.Text = "count_bag";
            ((System.ComponentModel.ISupportInitialize)(this.kg_baggage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Button accept_btn;
        private NumericUpDown kg_baggage;
    }
}