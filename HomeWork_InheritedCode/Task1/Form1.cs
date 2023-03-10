namespace Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_PIB_Click(object sender, EventArgs e)
		{
			_ = Extension.MessageBox(IntPtr.Zero, "Міллер Артем Валерійович", "ПIБ", Extension.MB_OK | Extension.MB_ICONINFORMATION);
		}

		private void Btn_Age_Click(object sender, EventArgs e)
		{
			_ = Extension.MessageBox(IntPtr.Zero, "18", "Вік", Extension.MB_OK | Extension.MB_ICONINFORMATION);
		}

		private void Btn_Gender_Click(object sender, EventArgs e)
		{
			_ = Extension.MessageBox(IntPtr.Zero, "Чоловіча", "Стать", Extension.MB_OK | Extension.MB_ICONINFORMATION);
		}
	}
}