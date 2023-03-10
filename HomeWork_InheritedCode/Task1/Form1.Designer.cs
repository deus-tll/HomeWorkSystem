namespace Task1
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
			Btn_PIB = new Button();
			Btn_Age = new Button();
			Btn_Gender = new Button();
			SuspendLayout();
			// 
			// Btn_PIB
			// 
			Btn_PIB.Location = new Point(50, 127);
			Btn_PIB.Name = "Btn_PIB";
			Btn_PIB.Size = new Size(75, 23);
			Btn_PIB.TabIndex = 0;
			Btn_PIB.Text = "ПІБ";
			Btn_PIB.UseVisualStyleBackColor = true;
			Btn_PIB.Click += Btn_PIB_Click;
			// 
			// Btn_Age
			// 
			Btn_Age.Location = new Point(214, 127);
			Btn_Age.Name = "Btn_Age";
			Btn_Age.Size = new Size(75, 23);
			Btn_Age.TabIndex = 1;
			Btn_Age.Text = "Вік";
			Btn_Age.UseVisualStyleBackColor = true;
			Btn_Age.Click += Btn_Age_Click;
			// 
			// Btn_Gender
			// 
			Btn_Gender.Location = new Point(376, 127);
			Btn_Gender.Name = "Btn_Gender";
			Btn_Gender.Size = new Size(75, 23);
			Btn_Gender.TabIndex = 2;
			Btn_Gender.Text = "Стать";
			Btn_Gender.UseVisualStyleBackColor = true;
			Btn_Gender.Click += Btn_Gender_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(511, 256);
			Controls.Add(Btn_Gender);
			Controls.Add(Btn_Age);
			Controls.Add(Btn_PIB);
			MaximumSize = new Size(527, 295);
			MinimumSize = new Size(527, 295);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Task 1";
			ResumeLayout(false);
		}

		#endregion

		private Button Btn_PIB;
		private Button Btn_Age;
		private Button Btn_Gender;
	}
}