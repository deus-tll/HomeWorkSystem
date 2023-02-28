namespace Task2
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
			this.Btn_Start = new System.Windows.Forms.Button();
			this.TextBox_Number = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Start
			// 
			this.Btn_Start.Location = new System.Drawing.Point(218, 190);
			this.Btn_Start.Name = "Btn_Start";
			this.Btn_Start.Size = new System.Drawing.Size(62, 23);
			this.Btn_Start.TabIndex = 5;
			this.Btn_Start.Text = "Пуск";
			this.Btn_Start.UseVisualStyleBackColor = true;
			this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
			// 
			// TextBox_Number
			// 
			this.TextBox_Number.Location = new System.Drawing.Point(163, 145);
			this.TextBox_Number.Name = "TextBox_Number";
			this.TextBox_Number.Size = new System.Drawing.Size(186, 20);
			this.TextBox_Number.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(186, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Загадайте число (0 - 100)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 329);
			this.Controls.Add(this.Btn_Start);
			this.Controls.Add(this.TextBox_Number);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_Start;
		private System.Windows.Forms.TextBox TextBox_Number;
		private System.Windows.Forms.Label label1;
	}
}

