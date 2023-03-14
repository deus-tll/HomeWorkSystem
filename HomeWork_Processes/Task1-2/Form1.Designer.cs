namespace Task1_2
{
	partial class MainForm
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
			Btn_Choose = new Button();
			Btn_Start = new Button();
			Btn_Kill = new Button();
			SuspendLayout();
			// 
			// Btn_Choose
			// 
			Btn_Choose.Location = new Point(61, 54);
			Btn_Choose.Name = "Btn_Choose";
			Btn_Choose.Size = new Size(186, 40);
			Btn_Choose.TabIndex = 0;
			Btn_Choose.Text = "Вибрати дочірній додаток";
			Btn_Choose.UseVisualStyleBackColor = true;
			Btn_Choose.Click += Btn_Choose_Click;
			// 
			// Btn_Start
			// 
			Btn_Start.Location = new Point(61, 117);
			Btn_Start.Name = "Btn_Start";
			Btn_Start.Size = new Size(186, 40);
			Btn_Start.TabIndex = 1;
			Btn_Start.Text = "Запустити";
			Btn_Start.UseVisualStyleBackColor = true;
			Btn_Start.Click += Btn_Start_Click;
			// 
			// Btn_Kill
			// 
			Btn_Kill.Location = new Point(61, 178);
			Btn_Kill.Name = "Btn_Kill";
			Btn_Kill.Size = new Size(186, 40);
			Btn_Kill.TabIndex = 2;
			Btn_Kill.Text = "Закрити";
			Btn_Kill.UseVisualStyleBackColor = true;
			Btn_Kill.Click += Btn_Kill_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(337, 271);
			Controls.Add(Btn_Kill);
			Controls.Add(Btn_Start);
			Controls.Add(Btn_Choose);
			Name = "MainForm";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button Btn_Choose;
		private Button Btn_Start;
		private Button Btn_Kill;
	}
}