namespace Task6
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
			label1 = new Label();
			TextBox_Threads = new TextBox();
			TextBox_StartRange = new TextBox();
			label2 = new Label();
			TextBox_EndRange = new TextBox();
			label3 = new Label();
			Btn_Start = new Button();
			ListBox_Numbers = new ListBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 38);
			label1.Name = "label1";
			label1.Size = new Size(110, 15);
			label1.TabIndex = 0;
			label1.Text = "Number of threads:";
			// 
			// TextBox_Threads
			// 
			TextBox_Threads.Location = new Point(128, 35);
			TextBox_Threads.Name = "TextBox_Threads";
			TextBox_Threads.Size = new Size(131, 23);
			TextBox_Threads.TabIndex = 3;
			// 
			// TextBox_StartRange
			// 
			TextBox_StartRange.Location = new Point(128, 99);
			TextBox_StartRange.Name = "TextBox_StartRange";
			TextBox_StartRange.Size = new Size(131, 23);
			TextBox_StartRange.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 102);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 4;
			label2.Text = "Start Range";
			// 
			// TextBox_EndRange
			// 
			TextBox_EndRange.Location = new Point(128, 165);
			TextBox_EndRange.Name = "TextBox_EndRange";
			TextBox_EndRange.Size = new Size(131, 23);
			TextBox_EndRange.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 168);
			label3.Name = "label3";
			label3.Size = new Size(63, 15);
			label3.TabIndex = 6;
			label3.Text = "End Range";
			// 
			// Btn_Start
			// 
			Btn_Start.Location = new Point(77, 234);
			Btn_Start.Name = "Btn_Start";
			Btn_Start.Size = new Size(75, 23);
			Btn_Start.TabIndex = 8;
			Btn_Start.Text = "Start";
			Btn_Start.UseVisualStyleBackColor = true;
			Btn_Start.Click += Btn_Start_Click;
			// 
			// ListBox_Numbers
			// 
			ListBox_Numbers.FormattingEnabled = true;
			ListBox_Numbers.ItemHeight = 15;
			ListBox_Numbers.Location = new Point(265, 35);
			ListBox_Numbers.Name = "ListBox_Numbers";
			ListBox_Numbers.Size = new Size(369, 259);
			ListBox_Numbers.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(646, 306);
			Controls.Add(ListBox_Numbers);
			Controls.Add(Btn_Start);
			Controls.Add(TextBox_EndRange);
			Controls.Add(label3);
			Controls.Add(TextBox_StartRange);
			Controls.Add(label2);
			Controls.Add(TextBox_Threads);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TextBox_Threads;
		private TextBox TextBox_StartRange;
		private Label label2;
		private TextBox TextBox_EndRange;
		private Label label3;
		private Button Btn_Start;
		private ListBox ListBox_Numbers;
	}
}