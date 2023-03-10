using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	internal class Extension
	{
		public const int MB_OK = 0x00000000;
		public const int MB_ICONINFORMATION = 0x00000040;

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto, EntryPoint = "MessageBox")]
		public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
	}
}
