namespace ElephantApp
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.lblFinalPrice = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTaxes = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter price, count of items, state";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 263);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Final price: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Count:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(175, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Price:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(299, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "State:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(429, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "Price:";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(479, 75);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(16, 17);
			this.lblPrice.TabIndex = 8;
			this.lblPrice.Text = "0";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(100, 70);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(69, 22);
			this.txtCount.TabIndex = 9;
			this.txtCount.Text = "0";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(225, 70);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(68, 22);
			this.txtPrice.TabIndex = 10;
			this.txtPrice.Text = "0";
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(350, 70);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(48, 22);
			this.txtState.TabIndex = 11;
			// 
			// lblFinalPrice
			// 
			this.lblFinalPrice.AutoSize = true;
			this.lblFinalPrice.Location = new System.Drawing.Point(152, 263);
			this.lblFinalPrice.Name = "lblFinalPrice";
			this.lblFinalPrice.Size = new System.Drawing.Size(16, 17);
			this.lblFinalPrice.TabIndex = 12;
			this.lblFinalPrice.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(543, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 25);
			this.button1.TabIndex = 13;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// lblTaxes
			// 
			this.lblTaxes.AutoSize = true;
			this.lblTaxes.Location = new System.Drawing.Point(152, 236);
			this.lblTaxes.Name = "lblTaxes";
			this.lblTaxes.Size = new System.Drawing.Size(16, 17);
			this.lblTaxes.TabIndex = 15;
			this.lblTaxes.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(45, 236);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Taxes: ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(543, 239);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 52);
			this.button2.TabIndex = 16;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 314);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lblTaxes);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblFinalPrice);
			this.Controls.Add(this.txtState);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Retail calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label lblFinalPrice;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblTaxes;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button2;
	}
}

