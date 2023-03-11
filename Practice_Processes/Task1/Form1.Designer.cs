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
			components = new System.ComponentModel.Container();
			TimerUpdate = new System.Windows.Forms.Timer(components);
			ListBox_Processes = new ListBox();
			NUD_Interval = new NumericUpDown();
			label1 = new Label();
			Btn_AcceptInterval = new Button();
			label2 = new Label();
			TextBox_id = new TextBox();
			TextBox_StartTime = new TextBox();
			label3 = new Label();
			TextBox_TotalProcessTime = new TextBox();
			label4 = new Label();
			TextBox_Threads = new TextBox();
			label5 = new Label();
			TextBox_CountInstances = new TextBox();
			label6 = new Label();
			Btn_TerminateProcess = new Button();
			Btn_Update = new Button();
			((System.ComponentModel.ISupportInitialize)NUD_Interval).BeginInit();
			SuspendLayout();
			// 
			// TimerUpdate
			// 
			TimerUpdate.Enabled = true;
			TimerUpdate.Interval = 100000;
			TimerUpdate.Tick += TimerUpdate_Tick;
			// 
			// ListBox_Processes
			// 
			ListBox_Processes.FormattingEnabled = true;
			ListBox_Processes.ItemHeight = 15;
			ListBox_Processes.Location = new Point(12, 12);
			ListBox_Processes.Name = "ListBox_Processes";
			ListBox_Processes.Size = new Size(322, 454);
			ListBox_Processes.TabIndex = 0;
			ListBox_Processes.SelectedIndexChanged += ListBox_Processes_SelectedIndexChanged;
			// 
			// NUD_Interval
			// 
			NUD_Interval.Location = new Point(374, 29);
			NUD_Interval.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			NUD_Interval.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
			NUD_Interval.Name = "NUD_Interval";
			NUD_Interval.Size = new Size(120, 23);
			NUD_Interval.TabIndex = 1;
			NUD_Interval.Value = new decimal(new int[] { 100000, 0, 0, 0 });
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(374, 9);
			label1.Name = "label1";
			label1.Size = new Size(54, 15);
			label1.TabIndex = 2;
			label1.Text = "Інтервал";
			// 
			// Btn_AcceptInterval
			// 
			Btn_AcceptInterval.Location = new Point(392, 58);
			Btn_AcceptInterval.Name = "Btn_AcceptInterval";
			Btn_AcceptInterval.Size = new Size(85, 23);
			Btn_AcceptInterval.TabIndex = 3;
			Btn_AcceptInterval.Text = "Застосувати";
			Btn_AcceptInterval.UseVisualStyleBackColor = true;
			Btn_AcceptInterval.Click += Btn_AcceptInterval_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(344, 118);
			label2.Name = "label2";
			label2.Size = new Size(136, 15);
			label2.TabIndex = 4;
			label2.Text = "Ідентифікатор процесу:";
			// 
			// TextBox_id
			// 
			TextBox_id.Location = new Point(344, 149);
			TextBox_id.Name = "TextBox_id";
			TextBox_id.ReadOnly = true;
			TextBox_id.Size = new Size(181, 23);
			TextBox_id.TabIndex = 5;
			// 
			// TextBox_StartTime
			// 
			TextBox_StartTime.Location = new Point(344, 215);
			TextBox_StartTime.Name = "TextBox_StartTime";
			TextBox_StartTime.ReadOnly = true;
			TextBox_StartTime.Size = new Size(181, 23);
			TextBox_StartTime.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(344, 184);
			label3.Name = "label3";
			label3.Size = new Size(68, 15);
			label3.TabIndex = 6;
			label3.Text = "Час старту:";
			// 
			// TextBox_TotalProcessTime
			// 
			TextBox_TotalProcessTime.Location = new Point(344, 283);
			TextBox_TotalProcessTime.Name = "TextBox_TotalProcessTime";
			TextBox_TotalProcessTime.ReadOnly = true;
			TextBox_TotalProcessTime.Size = new Size(181, 23);
			TextBox_TotalProcessTime.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(344, 252);
			label4.Name = "label4";
			label4.Size = new Size(222, 15);
			label4.TabIndex = 8;
			label4.Text = "Загальна кількість процесорного часу:";
			// 
			// TextBox_Threads
			// 
			TextBox_Threads.Location = new Point(344, 350);
			TextBox_Threads.Name = "TextBox_Threads";
			TextBox_Threads.ReadOnly = true;
			TextBox_Threads.Size = new Size(181, 23);
			TextBox_Threads.TabIndex = 11;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(344, 319);
			label5.Name = "label5";
			label5.Size = new Size(103, 15);
			label5.TabIndex = 10;
			label5.Text = "Кількість потоків:";
			// 
			// TextBox_CountInstances
			// 
			TextBox_CountInstances.Location = new Point(344, 421);
			TextBox_CountInstances.Name = "TextBox_CountInstances";
			TextBox_CountInstances.ReadOnly = true;
			TextBox_CountInstances.Size = new Size(181, 23);
			TextBox_CountInstances.TabIndex = 13;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(344, 390);
			label6.Name = "label6";
			label6.Size = new Size(208, 15);
			label6.TabIndex = 12;
			label6.Text = "Кількість копій процесу такого виду:";
			// 
			// Btn_TerminateProcess
			// 
			Btn_TerminateProcess.Location = new Point(12, 492);
			Btn_TerminateProcess.Name = "Btn_TerminateProcess";
			Btn_TerminateProcess.Size = new Size(91, 23);
			Btn_TerminateProcess.TabIndex = 14;
			Btn_TerminateProcess.Text = "Завершити";
			Btn_TerminateProcess.UseVisualStyleBackColor = true;
			Btn_TerminateProcess.Click += Btn_TerminateProcess_Click;
			// 
			// Btn_Update
			// 
			Btn_Update.Location = new Point(122, 492);
			Btn_Update.Name = "Btn_Update";
			Btn_Update.Size = new Size(75, 23);
			Btn_Update.TabIndex = 15;
			Btn_Update.Text = "Оновити";
			Btn_Update.UseVisualStyleBackColor = true;
			Btn_Update.Click += Btn_Update_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(568, 527);
			Controls.Add(Btn_Update);
			Controls.Add(Btn_TerminateProcess);
			Controls.Add(TextBox_CountInstances);
			Controls.Add(label6);
			Controls.Add(TextBox_Threads);
			Controls.Add(label5);
			Controls.Add(TextBox_TotalProcessTime);
			Controls.Add(label4);
			Controls.Add(TextBox_StartTime);
			Controls.Add(label3);
			Controls.Add(TextBox_id);
			Controls.Add(label2);
			Controls.Add(Btn_AcceptInterval);
			Controls.Add(label1);
			Controls.Add(NUD_Interval);
			Controls.Add(ListBox_Processes);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Main Form Task 1 - 3";
			((System.ComponentModel.ISupportInitialize)NUD_Interval).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer TimerUpdate;
		private ListBox ListBox_Processes;
		private NumericUpDown NUD_Interval;
		private Label label1;
		private Button Btn_AcceptInterval;
		private Label label2;
		private TextBox TextBox_id;
		private TextBox TextBox_StartTime;
		private Label label3;
		private TextBox TextBox_TotalProcessTime;
		private Label label4;
		private TextBox TextBox_Threads;
		private Label label5;
		private TextBox TextBox_CountInstances;
		private Label label6;
		private Button Btn_TerminateProcess;
		private Button Btn_Update;
	}
}