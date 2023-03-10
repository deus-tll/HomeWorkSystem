namespace Task4_ControllingApp
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
			GroupBox_TextBox = new GroupBox();
			groupBox4 = new GroupBox();
			Btn_SetTextBoxFont = new Button();
			label4 = new Label();
			groupBox3 = new GroupBox();
			ComboBox_TextBoxTextColor = new ComboBox();
			Btn_SetTextBoxTextColor = new Button();
			label3 = new Label();
			groupBox2 = new GroupBox();
			Btn_SetTextBoxBackColor = new Button();
			ComboBox_TextBoxBackgroundColor = new ComboBox();
			label2 = new Label();
			groupBox1 = new GroupBox();
			Btn_SetReadOnlyTB = new Button();
			CheckBox_ReadOnlyTB = new CheckBox();
			label1 = new Label();
			GroupBox_PictureBox = new GroupBox();
			ComboBox_SetFontTextBox = new ComboBox();
			GroupBox_TextBox.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// GroupBox_TextBox
			// 
			GroupBox_TextBox.Controls.Add(groupBox4);
			GroupBox_TextBox.Controls.Add(groupBox3);
			GroupBox_TextBox.Controls.Add(groupBox2);
			GroupBox_TextBox.Controls.Add(groupBox1);
			GroupBox_TextBox.Location = new Point(12, 12);
			GroupBox_TextBox.Name = "GroupBox_TextBox";
			GroupBox_TextBox.Size = new Size(308, 311);
			GroupBox_TextBox.TabIndex = 0;
			GroupBox_TextBox.TabStop = false;
			GroupBox_TextBox.Text = "Change MyTextBox";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(ComboBox_SetFontTextBox);
			groupBox4.Controls.Add(Btn_SetTextBoxFont);
			groupBox4.Controls.Add(label4);
			groupBox4.Location = new Point(6, 224);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(296, 69);
			groupBox4.TabIndex = 4;
			groupBox4.TabStop = false;
			// 
			// Btn_SetTextBoxFont
			// 
			Btn_SetTextBoxFont.Location = new Point(215, 15);
			Btn_SetTextBoxFont.Name = "Btn_SetTextBoxFont";
			Btn_SetTextBoxFont.Size = new Size(75, 23);
			Btn_SetTextBoxFont.TabIndex = 3;
			Btn_SetTextBoxFont.Text = "OK";
			Btn_SetTextBoxFont.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 19);
			label4.Name = "label4";
			label4.Size = new Size(93, 15);
			label4.TabIndex = 1;
			label4.Text = "4.) EM_SETFONT";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(ComboBox_TextBoxTextColor);
			groupBox3.Controls.Add(Btn_SetTextBoxTextColor);
			groupBox3.Controls.Add(label3);
			groupBox3.Location = new Point(6, 150);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(296, 68);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			// 
			// ComboBox_TextBoxTextColor
			// 
			ComboBox_TextBoxTextColor.FormattingEnabled = true;
			ComboBox_TextBoxTextColor.Location = new Point(6, 39);
			ComboBox_TextBoxTextColor.Name = "ComboBox_TextBoxTextColor";
			ComboBox_TextBoxTextColor.Size = new Size(188, 23);
			ComboBox_TextBoxTextColor.TabIndex = 4;
			// 
			// Btn_SetTextBoxTextColor
			// 
			Btn_SetTextBoxTextColor.Location = new Point(215, 15);
			Btn_SetTextBoxTextColor.Name = "Btn_SetTextBoxTextColor";
			Btn_SetTextBoxTextColor.Size = new Size(75, 23);
			Btn_SetTextBoxTextColor.TabIndex = 3;
			Btn_SetTextBoxTextColor.Text = "OK";
			Btn_SetTextBoxTextColor.UseVisualStyleBackColor = true;
			Btn_SetTextBoxTextColor.Click += Btn_SetTextBoxTextColor_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 19);
			label3.Name = "label3";
			label3.Size = new Size(126, 15);
			label3.TabIndex = 1;
			label3.Text = "3.) EM_SETTEXTCOLOR";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(Btn_SetTextBoxBackColor);
			groupBox2.Controls.Add(ComboBox_TextBoxBackgroundColor);
			groupBox2.Controls.Add(label2);
			groupBox2.Location = new Point(6, 76);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(296, 68);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			// 
			// Btn_SetTextBoxBackColor
			// 
			Btn_SetTextBoxBackColor.Location = new Point(215, 15);
			Btn_SetTextBoxBackColor.Name = "Btn_SetTextBoxBackColor";
			Btn_SetTextBoxBackColor.Size = new Size(75, 23);
			Btn_SetTextBoxBackColor.TabIndex = 3;
			Btn_SetTextBoxBackColor.Text = "OK";
			Btn_SetTextBoxBackColor.UseVisualStyleBackColor = true;
			Btn_SetTextBoxBackColor.Click += Btn_SetTextBoxBackColor_Click;
			// 
			// ComboBox_TextBoxBackgroundColor
			// 
			ComboBox_TextBoxBackgroundColor.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_TextBoxBackgroundColor.FormattingEnabled = true;
			ComboBox_TextBoxBackgroundColor.Location = new Point(6, 37);
			ComboBox_TextBoxBackgroundColor.Name = "ComboBox_TextBoxBackgroundColor";
			ComboBox_TextBoxBackgroundColor.Size = new Size(188, 23);
			ComboBox_TextBoxBackgroundColor.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 19);
			label2.Name = "label2";
			label2.Size = new Size(140, 15);
			label2.TabIndex = 1;
			label2.Text = "2.) EM_SETBKGNDCOLOR";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(Btn_SetReadOnlyTB);
			groupBox1.Controls.Add(CheckBox_ReadOnlyTB);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(6, 22);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(296, 48);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			// 
			// Btn_SetReadOnlyTB
			// 
			Btn_SetReadOnlyTB.Location = new Point(215, 15);
			Btn_SetReadOnlyTB.Name = "Btn_SetReadOnlyTB";
			Btn_SetReadOnlyTB.Size = new Size(75, 23);
			Btn_SetReadOnlyTB.TabIndex = 2;
			Btn_SetReadOnlyTB.Text = "OK";
			Btn_SetReadOnlyTB.UseVisualStyleBackColor = true;
			Btn_SetReadOnlyTB.Click += Btn_SetReadOnlyTB_Click;
			// 
			// CheckBox_ReadOnlyTB
			// 
			CheckBox_ReadOnlyTB.AutoSize = true;
			CheckBox_ReadOnlyTB.Location = new Point(151, 20);
			CheckBox_ReadOnlyTB.Name = "CheckBox_ReadOnlyTB";
			CheckBox_ReadOnlyTB.Size = new Size(15, 14);
			CheckBox_ReadOnlyTB.TabIndex = 1;
			CheckBox_ReadOnlyTB.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(122, 15);
			label1.TabIndex = 0;
			label1.Text = "1.) EM_SETREADONLY";
			// 
			// GroupBox_PictureBox
			// 
			GroupBox_PictureBox.Location = new Point(326, 12);
			GroupBox_PictureBox.Name = "GroupBox_PictureBox";
			GroupBox_PictureBox.Size = new Size(311, 311);
			GroupBox_PictureBox.TabIndex = 1;
			GroupBox_PictureBox.TabStop = false;
			GroupBox_PictureBox.Text = "Change MyPictureBox";
			// 
			// ComboBox_SetFontTextBox
			// 
			ComboBox_SetFontTextBox.FormattingEnabled = true;
			ComboBox_SetFontTextBox.Location = new Point(6, 37);
			ComboBox_SetFontTextBox.Name = "ComboBox_SetFontTextBox";
			ComboBox_SetFontTextBox.Size = new Size(188, 23);
			ComboBox_SetFontTextBox.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(649, 335);
			Controls.Add(GroupBox_PictureBox);
			Controls.Add(GroupBox_TextBox);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Controlling Application";
			GroupBox_TextBox.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox GroupBox_TextBox;
		private GroupBox GroupBox_PictureBox;
		private GroupBox GroupBox_Button;
		private GroupBox groupBox2;
		private Label label2;
		private GroupBox groupBox1;
		private CheckBox CheckBox_ReadOnlyTB;
		private Label label1;
		private GroupBox groupBox4;
		private Label label4;
		private GroupBox groupBox3;
		private ComboBox comboBox2;
		private Label label3;
		private ComboBox ComboBox_TextBoxBackgroundColor;
		private Button Btn_SetReadOnlyTB;
		private Button Btn_SetTextBoxFont;
		private Button Btn_SetTextBoxTextColor;
		private Button Btn_SetTextBoxBackColor;
		private ComboBox ComboBox_TextBoxTextColor;
		private ComboBox ComboBox_SetFontTextBox;
	}
}