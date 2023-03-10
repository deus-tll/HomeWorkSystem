using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Text;
using System.Drawing;

namespace Task2
{
	public partial class Form1 : Form
	{
		private IntPtr hWnd = IntPtr.Zero;
		private bool IsHide = false;
		public Form1()
		{
			InitializeComponent();
		}

		private bool FindWindow()
		{
			hWnd = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", null);
			if (hWnd == IntPtr.Zero)
			{
				MessageBox.Show("Вікно не було знайдено!");
				return false;
			}

			return true;
		}

		private void Btn_ChangeTitle_Click(object sender, EventArgs e)
		{
			string text = TextBox.Text;

			if (string.IsNullOrEmpty(text)) return;

			if (!FindWindow()) return;

			IntPtr len = new(text.Length);
			StringBuilder sb = new(text);

			_ = Extension.SendMessage(hWnd, Extension.WM_SETTEXT, len, sb);
		}

		private void Btn_CloseWindow_Click(object sender, EventArgs e)
		{
			if (!FindWindow()) return;

			_ = Extension.SendMessage(hWnd, Extension.WM_SETTEXT, IntPtr.Zero, null);
		}

		private void Btn_HideWindow_Click(object sender, EventArgs e)
		{
			if (!FindWindow()) return;

			if (!IsHide)
			{
				_ = Extension.ShowWindow(hWnd, Extension.SW_HIDE);
				IsHide = true;
			}
			else
			{
				_ = Extension.ShowWindow(hWnd, Extension.SW_SHOW);
				IsHide = false;
			}
		}
	}
}