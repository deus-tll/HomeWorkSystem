using System;
using System.Diagnostics;

namespace Task1_2
{
	public partial class MainForm : Form
	{
		private Process _childProcess;


		public MainForm()
		{
			InitializeComponent();
		}

		private void Btn_Choose_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new()
			{
				Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*",
				Title = "Select the child process to launch"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_childProcess = new Process();
				_childProcess.StartInfo.FileName = openFileDialog.FileName;
			}
		}

		private async void Btn_Start_Click(object sender, EventArgs e)
		{
			if (_childProcess != null && _childProcess.StartInfo.FileName != null)
			{
				_childProcess.Start();
				await _childProcess.WaitForExitAsync();
				MessageBox.Show($"Child process terminated with exit code: {_childProcess.ExitCode}");
			}
		}

		private void Btn_Kill_Click(object sender, EventArgs e)
		{
			if (_childProcess != null && _childProcess.StartInfo.FileName != null)
			{
				_childProcess.Kill();
				_childProcess.Dispose();
				_childProcess = null;

				MessageBox.Show("Child process has been terminated.");
			}
		}
	}
}