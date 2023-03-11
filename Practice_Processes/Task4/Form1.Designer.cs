namespace Task4
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
			Btn_Notepad = new Button();
			Btn_Calc = new Button();
			Btn_Paint = new Button();
			Btn_UserOption = new Button();
			SuspendLayout();
			// 
			// Btn_Notepad
			// 
			Btn_Notepad.Location = new Point(126, 33);
			Btn_Notepad.Name = "Btn_Notepad";
			Btn_Notepad.Size = new Size(159, 52);
			Btn_Notepad.TabIndex = 0;
			Btn_Notepad.Text = "Запустити блокнот";
			Btn_Notepad.UseVisualStyleBackColor = true;
			Btn_Notepad.Click += Btn_Notepad_Click;
			// 
			// Btn_Calc
			// 
			Btn_Calc.Location = new Point(126, 121);
			Btn_Calc.Name = "Btn_Calc";
			Btn_Calc.Size = new Size(159, 52);
			Btn_Calc.TabIndex = 1;
			Btn_Calc.Text = "Запустити калькулятор";
			Btn_Calc.UseVisualStyleBackColor = true;
			Btn_Calc.Click += Btn_Calc_Click;
			// 
			// Btn_Paint
			// 
			Btn_Paint.Location = new Point(126, 207);
			Btn_Paint.Name = "Btn_Paint";
			Btn_Paint.Size = new Size(159, 52);
			Btn_Paint.TabIndex = 2;
			Btn_Paint.Text = "Запустити Paint";
			Btn_Paint.UseVisualStyleBackColor = true;
			Btn_Paint.Click += Btn_Paint_Click;
			// 
			// Btn_UserOption
			// 
			Btn_UserOption.Location = new Point(126, 292);
			Btn_UserOption.Name = "Btn_UserOption";
			Btn_UserOption.Size = new Size(159, 52);
			Btn_UserOption.TabIndex = 3;
			Btn_UserOption.Text = "Вибрати власноруч";
			Btn_UserOption.UseVisualStyleBackColor = true;
			Btn_UserOption.Click += Btn_UserOption_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(404, 379);
			Controls.Add(Btn_UserOption);
			Controls.Add(Btn_Paint);
			Controls.Add(Btn_Calc);
			Controls.Add(Btn_Notepad);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button Btn_Notepad;
		private Button Btn_Calc;
		private Button Btn_Paint;
		private Button Btn_UserOption;
	}
}