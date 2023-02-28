using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Task4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ChangeTitle()
		{
			IntPtr hWnd = Extension.FindWindow("Notepad", null);
			if (hWnd == IntPtr.Zero)
			{
				MessageBox.Show("Notepad window not found!");
				return;
			}

			string time = DateTime.Now.ToString("HH:mm:ss");

			IntPtr len = new IntPtr(time.Length);
			StringBuilder sb = new StringBuilder(time);

			Extension.SendMessage(hWnd, Extension.WM_SETTEXT, len, sb);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			ChangeTitle();
		}
	}
}
