using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TextBox_Number.Text, out int number))
			{
				ComputerGues(number);
			}
		}

		private void ComputerGues(int number)
		{
			Random random = new Random();
			int r = random.Next(100);


			int result = Extension.MessageBox(IntPtr.Zero, $"Це ваше число - {r}?", "Message",
											  Extension.MB_YESNO | Extension.MB_ICONQUESTION);

			if (result == 6)
			{
				Extension.MessageBox(IntPtr.Zero, $"Вгадав!", "Message",
											  Extension.MB_YESNO | Extension.MB_ICONQUESTION);
			}
			else
			{
				Extension.MessageBox(IntPtr.Zero, $"Не вгадав(", "Message",
											  Extension.MB_OK | Extension.MB_ICONINFORMATION);
			}
		}
	}
}
