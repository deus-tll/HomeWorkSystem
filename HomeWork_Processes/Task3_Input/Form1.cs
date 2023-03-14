using System.Diagnostics;

namespace Task3_Input
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_Calculate_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(TextBox_FirstNumber.Text, out int first)) return;
			if (!int.TryParse(TextBox_SecondNumber.Text, out int second)) return;

			string _operator = "";

			if (TextBox_Operator.Text is "/" ||
			   TextBox_Operator.Text is "+" ||
			   TextBox_Operator.Text is "-" ||
			   TextBox_Operator.Text is "*" ||
			   TextBox_Operator.Text is "%")
			_operator = TextBox_Operator.Text;

			if (string.IsNullOrEmpty(_operator)) return;

			Process process = new();

			process.StartInfo.FileName = "Task3_Output.exe";

			process.StartInfo.Arguments = $"{first} {second} {_operator}";

			process.Start();
		}
	}
}