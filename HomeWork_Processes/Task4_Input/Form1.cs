using System.Diagnostics;

namespace Task4_Input
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_Choose_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_Word.Text)) return;

			OpenFileDialog openFileDialog = new()
			{
				Filter = "Executable files (*.txt)|*.txt",
				Title = "Select the child process to launch"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Process process = new();

				process.StartInfo.FileName = "Task4_Output.exe";

				process.StartInfo.Arguments = $"{openFileDialog.FileName} {TextBox_Word.Text}";

				process.Start();
			}
		}
	}
}