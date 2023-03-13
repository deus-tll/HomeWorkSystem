namespace Task7
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Btn_Start = new Button();
			TextBox_Avg = new TextBox();
			label3 = new Label();
			TextBox_Min = new TextBox();
			label2 = new Label();
			TextBox_Max = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// Btn_Start
			// 
			Btn_Start.Location = new Point(94, 231);
			Btn_Start.Name = "Btn_Start";
			Btn_Start.Size = new Size(75, 23);
			Btn_Start.TabIndex = 15;
			Btn_Start.Text = "Start";
			Btn_Start.UseVisualStyleBackColor = true;
			Btn_Start.Click += Btn_Start_Click;
			// 
			// TextBox_Avg
			// 
			TextBox_Avg.Location = new Point(128, 160);
			TextBox_Avg.Name = "TextBox_Avg";
			TextBox_Avg.ReadOnly = true;
			TextBox_Avg.Size = new Size(131, 23);
			TextBox_Avg.TabIndex = 14;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 163);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 13;
			label3.Text = "Avg:";
			// 
			// TextBox_Min
			// 
			TextBox_Min.Location = new Point(128, 94);
			TextBox_Min.Name = "TextBox_Min";
			TextBox_Min.ReadOnly = true;
			TextBox_Min.Size = new Size(131, 23);
			TextBox_Min.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 97);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 11;
			label2.Text = "Min:";
			// 
			// TextBox_Max
			// 
			TextBox_Max.Location = new Point(128, 30);
			TextBox_Max.Name = "TextBox_Max";
			TextBox_Max.ReadOnly = true;
			TextBox_Max.Size = new Size(131, 23);
			TextBox_Max.TabIndex = 10;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 33);
			label1.Name = "label1";
			label1.Size = new Size(33, 15);
			label1.TabIndex = 9;
			label1.Text = "Max:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(281, 285);
			Controls.Add(Btn_Start);
			Controls.Add(TextBox_Avg);
			Controls.Add(label3);
			Controls.Add(TextBox_Min);
			Controls.Add(label2);
			Controls.Add(TextBox_Max);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button Btn_Start;
		private TextBox TextBox_Avg;
		private Label label3;
		private TextBox TextBox_Min;
		private Label label2;
		private TextBox TextBox_Max;
		private Label label1;
	}
}