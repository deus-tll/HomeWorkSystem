using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Task4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_Notepad_Click(object sender, EventArgs e)
		{
			Process.Start("notepad.exe");
		}

		private void Btn_Calc_Click(object sender, EventArgs e)
		{
			Process.Start("calc.exe");
		}

		private void Btn_Paint_Click(object sender, EventArgs e)
		{
			Process.Start("mspaint.exe");
		}

		private void Btn_UserOption_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new();
			dlg.Title = "Select an executable file...";
			dlg.Filter = "Executable files (*.exe)|*.exe";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Process.Start(dlg.FileName);
			}
		}
	}
}