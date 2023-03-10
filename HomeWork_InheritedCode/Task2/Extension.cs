using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	internal class Extension
	{
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		public const int WM_SETTEXT = 0x000C;
		public const int WM_CLOSE = 0x0010;
		public const int SW_HIDE = 0;
		public const int SW_SHOW = 5;

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, StringBuilder lParam);

		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
	}
}
