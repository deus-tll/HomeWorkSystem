using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task4_ControllingApp
{
	internal class Extension
	{
		public const int EM_SETREADONLY = 0xCF;
		public const int EM_SETBKGNDCOLOR = 0x152;
		public const int EM_SETTEXTCOLOR = 0x00C1;
		public const int WM_SETFONT = 0x0030;
		public const int EM_SETFONT = 0x00C3;
		public const int WM_SIZE = 0x0005;
		public const int IMAGE_BITMAP = 0;
		public const int STM_SETIMAGE = 0x0172;
		public const int WM_CTLCOLORSTATIC = 0x0138;
		public const int GWL_EXSTYLE = -20;
		public const int WS_EX_TRANSPARENT = 0x20;
		public const int WM_PAINT = 0x000F;

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateSolidBrush(int color);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);


		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern IntPtr CreateFont( int nHeight,
												int nWidth,
												int nEscapement,
												int nOrientation,
												int fnWeight,
												uint fdwItalic,
												uint fdwUnderline,
												uint fdwStrikeOut,
												uint fdwCharSet,
												uint fdwOutputPrecision,
												uint fdwClipPrecision,
												uint fdwQuality,
												uint fdwPitchAndFamily,
												string lpszFace);
	}
}
