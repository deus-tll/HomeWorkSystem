using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task4_ControllingApp
{
	public partial class Form1 : Form
	{
		//Я НЕ ЗНАЮ, ЧИ ТО ЗНОВУ ТІЛЬКИ В МЕНЕ ТАК ЧИ ЩО, АЛЕ ЧОМУСЬ УСЕ ОКРІМ EM_SETREADONLY ПРАЦЮВАТИ НЕ ХОЧЕ. ХОЧА ЧИСТО ЛОГІЧНО НІБИ ЯК КОД ПРАВИЛЬНИЙ
		//SETWINDOWLONG\GETWINDOWLONG ТЕЖ ВИКОРИСТОВУВАВ І ВСЕ ОДНО НЕ ПРАЦЮЄ
		public Form1()
		{
			InitializeComponent();
			ComboBox_TextBoxBackgroundColor.DataSource = (new ColorItemList()).Colors;
			ComboBox_TextBoxBackgroundColor.SelectedItem = ComboBox_TextBoxBackgroundColor.Items[0];

			ComboBox_TextBoxTextColor.DataSource = (new ColorItemList()).Colors;
			ComboBox_TextBoxTextColor.SelectedItem = ComboBox_TextBoxTextColor.Items[0];

			ComboBox_SetFontTextBox.Items.Add("Arial,12,regular");
			ComboBox_SetFontTextBox.Items.Add("Times New Roman,14,bold");
			ComboBox_SetFontTextBox.Items.Add("Verdana,10,italic");
			ComboBox_SetFontTextBox.SelectedItem = ComboBox_SetFontTextBox.Items[0];
		}

		private void SetColorsToTextBox(int wMsg, Color color)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr textBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Edit.app.0.33c0d9d_r3_ad1", null);
			if (textBoxHandle == IntPtr.Zero) return;

			IntPtr hDC = Extension.GetDC(textBoxHandle);
			IntPtr brushHandle = Extension.CreateSolidBrush(ColorTranslator.ToWin32(color));

			_ = Extension.SendMessage(textBoxHandle, wMsg, hDC, brushHandle);
			_ = Extension.SendMessage(mainWindowHandle, Extension.WM_PAINT, IntPtr.Zero, IntPtr.Zero);
		}

		private void Btn_SetReadOnlyTB_Click(object sender, EventArgs e)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", null);
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr textBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Edit.app.0.33c0d9d_r3_ad1", null);
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

		private void Btn_SetTextBoxFont_Click(object sender, EventArgs e)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr textBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Edit.app.0.33c0d9d_r3_ad1", null);
			if (textBoxHandle == IntPtr.Zero) return;

			IntPtr hFont = IntPtr.Zero;

			switch (ComboBox_SetFontTextBox.SelectedItem.ToString())
			{
				case "Arial,12,regular":
					hFont = Extension.CreateFont(12, 0, 0, 0, 400, 0, 0, 0, 0, 0, 0, 0, 0, "Arial");
					break;

				case "Times New Roman,14,bold":
					hFont = Extension.CreateFont(14, 0, 0, 0, 700, 0, 0, 0, 0, 0, 0, 0, 0, "Times New Roman");
					break;

				case "Verdana,10,italic":
					hFont = Extension.CreateFont(10, 0, 0, 0, 400, 1, 0, 0, 0, 0, 0, 0, 0, "Verdana");
					break;
			}

			if (hFont == IntPtr.Zero) return;

			_ = Extension.SendMessage(textBoxHandle, Extension.EM_SETFONT, hFont, 1);
			_ = Extension.SendMessage(mainWindowHandle, Extension.WM_PAINT, IntPtr.Zero, IntPtr.Zero);
		}

		private void Btn_SetSizePictureBox_Click(object sender, EventArgs e)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr pictureBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", null);
			if (pictureBoxHandle == IntPtr.Zero) return;

			if (string.IsNullOrEmpty(TextBox_SetWidth.Text) || string.IsNullOrEmpty(TextBox_SetHeight.Text)) return;

			if (!int.TryParse(TextBox_SetWidth.Text, out int width)) return;
			if (!int.TryParse(TextBox_SetHeight.Text, out int height)) return;

			_ = Extension.SendMessage(pictureBoxHandle, Extension.WM_SIZE, IntPtr.Zero, new IntPtr(width << 16 | height));
			_ = Extension.SendMessage(mainWindowHandle, Extension.WM_PAINT, IntPtr.Zero, IntPtr.Zero);
		}

		private void Btn_ChooseImage_Click(object sender, EventArgs e)
		{
			IntPtr mainWindowHandle = Extension.FindWindow("WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", "Controlled Application");
			if (mainWindowHandle == IntPtr.Zero) return;

			IntPtr pictureBoxHandle = Extension.FindWindowEx(mainWindowHandle, IntPtr.Zero, "WindowsForms10.Window.8.app.0.33c0d9d_r3_ad1", null);
			if (pictureBoxHandle == IntPtr.Zero) return;

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select an image";
			openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Image image = Image.FromFile(openFileDialog.FileName);

				if (image != null)
				{
					Bitmap bitmap = new(image);

					IntPtr hBitmap = bitmap.GetHbitmap();

					_ = Extension.SendMessage(pictureBoxHandle, Extension.STM_SETIMAGE, new IntPtr(Extension.IMAGE_BITMAP), hBitmap);
					_ = Extension.SendMessage(mainWindowHandle, Extension.WM_PAINT, IntPtr.Zero, IntPtr.Zero);
				}

			}
		}
	}
}