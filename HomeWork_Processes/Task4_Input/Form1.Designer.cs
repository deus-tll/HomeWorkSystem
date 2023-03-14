namespace Task4_Input
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
			TextBox_Word = new TextBox();
			label1 = new Label();
			Btn_Choose = new Button();
			label2 = new Label();
			SuspendLayout();
			// 
			// TextBox_Word
			// 
			TextBox_Word.Location = new Point(139, 113);
			TextBox_Word.Name = "TextBox_Word";
			TextBox_Word.Size = new Size(145, 23);
			TextBox_Word.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(155, 81);
			label1.Name = "label1";
			label1.Size = new Size(110, 15);
			label1.TabIndex = 3;
			label1.Text = "Слово для пошуку";
			// 
			// Btn_Choose
			// 
			Btn_Choose.Location = new Point(149, 193);
			Btn_Choose.Name = "Btn_Choose";
			Btn_Choose.Size = new Size(116, 23);
			Btn_Choose.TabIndex = 5;
			Btn_Choose.Text = "ОК";
			Btn_Choose.UseVisualStyleBackColor = true;
			Btn_Choose.Click += Btn_Choose_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(83, 164);
			label2.Name = "label2";
			label2.Size = new Size(257, 15);
			label2.TabIndex = 6;
			label2.Text = "Вибрати текстовий файл та запустити процес";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(419, 275);
			Controls.Add(label2);
			Controls.Add(Btn_Choose);
			Controls.Add(TextBox_Word);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TextBox_Word;
		private Label label1;
		private Button Btn_Choose;
		private Label label2;
	}
}