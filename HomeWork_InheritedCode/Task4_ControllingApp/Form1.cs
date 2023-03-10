namespace Task4_ControllingApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_SetReadOnlyTB_Click(object sender, EventArgs e)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr textBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Edit.app.0.33c0d9d_r3_ad1", "MyTextBox");
			if (textBoxHandle == IntPtr.Zero) return;

			if(CheckBox_ReadOnlyTB.Checked)
				Extension.SendMessage(textBoxHandle, Extension.EM_SETREADONLY, 1, 0);
			else
				Extension.SendMessage(textBoxHandle, Extension.EM_SETREADONLY, 0, 0);
		}
	}
}