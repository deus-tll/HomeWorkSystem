using System.Diagnostics;

namespace Task1
{
	// В Task1 ОДРАЗУ ТРИ ЗАВДАННЯ
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			RefreshProcessList();
		}

		private void RefreshProcessList()
		{
			ListBox_Processes.Items.Clear();
			Process[] processes = Process.GetProcesses();

			foreach (Process process in processes)
			{
				if (!string.IsNullOrEmpty(process.ProcessName))
				{
					ListBox_Processes.Items.Add(process.ProcessName);
				}
			}
		}

		private void TimerUpdate_Tick(object sender, EventArgs e)
		{
			RefreshProcessList();
		}

		private void Btn_AcceptInterval_Click(object sender, EventArgs e)
		{
			TimerUpdate.Stop();
			TimerUpdate.Interval = Convert.ToInt32(NUD_Interval.Value);
			TimerUpdate.Start();
			RefreshProcessList();
		}

		private void ListBox_Processes_SelectedIndexChanged(object sender, EventArgs e)
		{
			object? obj = ListBox_Processes.SelectedItem;
			if (obj is null) return;

			string? processName = obj.ToString();
			if (string.IsNullOrEmpty(processName)) return;

			Process[] processes = Process.GetProcessesByName(processName);
			if (processes.Length > 0)
			{
				Process process = processes[0];
				try
				{
					TextBox_id.Text = process.Id.ToString();
				}
				catch (Exception)
				{
					TextBox_id.Text = "'none'";
				}

				try
				{
					TextBox_StartTime.Text = process.StartTime.ToString();
				}
				catch (Exception)
				{
					TextBox_StartTime.Text = "'none'";
				}

				try
				{
					TextBox_TotalProcessTime.Text = process.TotalProcessorTime.ToString();
				}
				catch (Exception)
				{
					TextBox_TotalProcessTime.Text = "'none'";
				}

				try
				{
					TextBox_Threads.Text = process.Threads.Count.ToString();
				}
				catch (Exception)
				{
					TextBox_Threads.Text = "'none'";
				}

				try
				{
					TextBox_CountInstances.Text = processes.Length.ToString();
				}
				catch (Exception)
				{
					TextBox_CountInstances.Text = "'none'";
				}
			}
		}

		private void Btn_TerminateProcess_Click(object sender, EventArgs e)
		{
			object? obj = ListBox_Processes.SelectedItem;
			if (obj is null) return;

			string? processName = obj.ToString();
			if (string.IsNullOrEmpty(processName)) return;

			Process[] processes = Process.GetProcessesByName(processName);

			Process process = processes[0];

			process.Kill();
		}

		private void Btn_Update_Click(object sender, EventArgs e)
		{
			RefreshProcessList();
		}
	}
}