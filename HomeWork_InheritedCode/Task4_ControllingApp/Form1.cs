namespace Task4_ControllingApp
{
	public partial class Form1 : Form
	{
		//трошки не встиг, сьогодні ж вже дороблю

		ColorItemList ColorItemList = new ColorItemList();
		public Form1()
		{
			InitializeComponent();
			ComboBox_TextBoxBackgroundColor.DataSource = ColorItemList.Colors;
			ComboBox_TextBoxBackgroundColor.SelectedItem = ComboBox_TextBoxBackgroundColor.Items[0];

			ComboBox_TextBoxTextColor.DataSource = ColorItemList.Colors;
			ComboBox_TextBoxTextColor.SelectedItem = ComboBox_TextBoxTextColor.Items[0];

			ComboBox_SetFontTextBox.Items.Add("Arial,12,regular");
			ComboBox_SetFontTextBox.Items.Add("Times New Roman,14,bold");
			ComboBox_SetFontTextBox.Items.Add("Verdana,10,italic");
			ComboBox_SetFontTextBox.SelectedItem = ComboBox_SetFontTextBox.Items[0];
		}

		private void SetColorsToTextBox(int wMsg, Color _color)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr textBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Edit.app.0.33c0d9d_r3_ad1", "MyTextBox");
			if (textBoxHandle == IntPtr.Zero) return;

			Color color = _color;
			IntPtr brushHandle = Extension.CreateSolidBrush(color.ToArgb());

			_ = Extension.SendMessage(textBoxHandle, wMsg, 0, brushHandle);
		}

		private void Btn_SetReadOnlyTB_Click(object sender, EventArgs e)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr textBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Edit.app.0.33c0d9d_r3_ad1", "MyTextBox");
			if (textBoxHandle == IntPtr.Zero) return;

			if (CheckBox_ReadOnlyTB.Checked)
				_ = Extension.SendMessage(textBoxHandle, Extension.EM_SETREADONLY, 1, 0);
			else
				_ = Extension.SendMessage(textBoxHandle, Extension.EM_SETREADONLY, 0, 0);
		}

		private void Btn_SetTextBoxBackColor_Click(object sender, EventArgs e)
		{
			SetColorsToTextBox(Extension.EM_SETBKGNDCOLOR, ((ColorItem)ComboBox_TextBoxBackgroundColor.SelectedItem).Value);
		}

		private void Btn_SetTextBoxTextColor_Click(object sender, EventArgs e)
		{
			SetColorsToTextBox(Extension.EM_SETTEXTCOLOR, ((ColorItem)ComboBox_TextBoxTextColor.SelectedItem).Value);
		}
	}
}