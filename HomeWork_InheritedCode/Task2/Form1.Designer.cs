namespace Task2
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
			groupBox1 = new GroupBox();
			Btn_HideWindow = new Button();
			label4 = new Label();
			Btn_CloseWindow = new Button();
			label3 = new Label();
			TextBox = new TextBox();
			Btn_ChangeTitle = new Button();
			label2 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(Btn_HideWindow);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(Btn_CloseWindow);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(TextBox);
			groupBox1.Controls.Add(Btn_ChangeTitle);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(492, 198);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Дії";
			// 
			// Btn_HideWindow
			// 
			Btn_HideWindow.Location = new Point(319, 38);
			Btn_HideWindow.Name = "Btn_HideWindow";
			Btn_HideWindow.Size = new Size(75, 23);
			Btn_HideWindow.TabIndex = 8;
			Btn_HideWindow.Text = "ОК";
			Btn_HideWindow.UseVisualStyleBackColor = true;
			Btn_HideWindow.Click += Btn_HideWindow_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(246, 19);
			label4.Name = "label4";
			label4.Size = new Size(225, 15);
			label4.TabIndex = 7;
			label4.Text = "Сховати/показати вікно додатку Task2_1";
			// 
			// Btn_CloseWindow
			// 
			Btn_CloseWindow.Location = new Point(60, 141);
			Btn_CloseWindow.Name = "Btn_CloseWindow";
			Btn_CloseWindow.Size = new Size(75, 23);
			Btn_CloseWindow.TabIndex = 6;
			Btn_CloseWindow.Text = "Закрити";
			Btn_CloseWindow.UseVisualStyleBackColor = true;
			Btn_CloseWindow.Click += Btn_CloseWindow_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(15, 123);
			label3.Name = "label3";
			label3.Size = new Size(171, 15);
			label3.TabIndex = 5;
			label3.Text = "Закрити вікно додатку Task2_1";
			// 
			// TextBox
			// 
			TextBox.Location = new Point(6, 38);
			TextBox.Name = "TextBox";
			TextBox.Size = new Size(204, 23);
			TextBox.TabIndex = 4;
			// 
			// Btn_ChangeTitle
			// 
			Btn_ChangeTitle.Location = new Point(60, 67);
			Btn_ChangeTitle.Name = "Btn_ChangeTitle";
			Btn_ChangeTitle.Size = new Size(75, 22);
			Btn_ChangeTitle.TabIndex = 3;
			Btn_ChangeTitle.Text = "ОК";
			Btn_ChangeTitle.UseVisualStyleBackColor = true;
			Btn_ChangeTitle.Click += Btn_ChangeTitle_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 19);
			label2.Name = "label2";
			label2.Size = new Size(184, 15);
			label2.TabIndex = 2;
			label2.Text = "Змінити заголовок вікна Task2_1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(516, 222);
			Controls.Add(groupBox1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main Window";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox groupBox1;
		private Button Btn_CloseWindow;
		private Label label3;
		private TextBox TextBox;
		private Button Btn_ChangeTitle;
		private Label label2;
		private Button Btn_HideWindow;
		private Label label4;
	}
}