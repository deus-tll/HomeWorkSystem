namespace Task3_Input
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
			Btn_Calculate = new Button();
			label1 = new Label();
			TextBox_FirstNumber = new TextBox();
			TextBox_SecondNumber = new TextBox();
			label2 = new Label();
			TextBox_Operator = new TextBox();
			label3 = new Label();
			SuspendLayout();
			// 
			// Btn_Calculate
			// 
			Btn_Calculate.Location = new Point(217, 185);
			Btn_Calculate.Name = "Btn_Calculate";
			Btn_Calculate.Size = new Size(94, 23);
			Btn_Calculate.TabIndex = 0;
			Btn_Calculate.Text = "Обчислити";
			Btn_Calculate.UseVisualStyleBackColor = true;
			Btn_Calculate.Click += Btn_Calculate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(50, 87);
			label1.Name = "label1";
			label1.Size = new Size(83, 15);
			label1.TabIndex = 1;
			label1.Text = "Перше число";
			// 
			// TextBox_FirstNumber
			// 
			TextBox_FirstNumber.Location = new Point(29, 114);
			TextBox_FirstNumber.Name = "TextBox_FirstNumber";
			TextBox_FirstNumber.Size = new Size(125, 23);
			TextBox_FirstNumber.TabIndex = 2;
			// 
			// TextBox_SecondNumber
			// 
			TextBox_SecondNumber.Location = new Point(201, 114);
			TextBox_SecondNumber.Name = "TextBox_SecondNumber";
			TextBox_SecondNumber.Size = new Size(125, 23);
			TextBox_SecondNumber.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(226, 87);
			label2.Name = "label2";
			label2.Size = new Size(76, 15);
			label2.TabIndex = 3;
			label2.Text = "Друге число";
			// 
			// TextBox_Operator
			// 
			TextBox_Operator.Location = new Point(362, 114);
			TextBox_Operator.Name = "TextBox_Operator";
			TextBox_Operator.Size = new Size(125, 23);
			TextBox_Operator.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(397, 87);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 5;
			label3.Text = "Оператор";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(536, 272);
			Controls.Add(TextBox_Operator);
			Controls.Add(label3);
			Controls.Add(TextBox_SecondNumber);
			Controls.Add(label2);
			Controls.Add(TextBox_FirstNumber);
			Controls.Add(label1);
			Controls.Add(Btn_Calculate);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button Btn_Calculate;
		private Label label1;
		private TextBox TextBox_FirstNumber;
		private TextBox TextBox_SecondNumber;
		private Label label2;
		private TextBox TextBox_Operator;
		private Label label3;
	}
}