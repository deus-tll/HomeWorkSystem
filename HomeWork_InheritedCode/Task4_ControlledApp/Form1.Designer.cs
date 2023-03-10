namespace Task4_ControlledApp
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
			MyTextBox = new TextBox();
			MyPictureBox = new PictureBox();
			((System.ComponentModel.ISupportInitialize)MyPictureBox).BeginInit();
			SuspendLayout();
			// 
			// MyTextBox
			// 
			MyTextBox.Location = new Point(73, 186);
			MyTextBox.Name = "MyTextBox";
			MyTextBox.Size = new Size(100, 23);
			MyTextBox.TabIndex = 1;
			// 
			// MyPictureBox
			// 
			MyPictureBox.Location = new Point(295, 109);
			MyPictureBox.Name = "MyPictureBox";
			MyPictureBox.Size = new Size(223, 179);
			MyPictureBox.TabIndex = 2;
			MyPictureBox.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 437);
			Controls.Add(MyPictureBox);
			Controls.Add(MyTextBox);
			MaximumSize = new Size(600, 476);
			MinimumSize = new Size(600, 476);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Controlled Application";
			((System.ComponentModel.ISupportInitialize)MyPictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox MyTextBox;
		private PictureBox MyPictureBox;
	}
}