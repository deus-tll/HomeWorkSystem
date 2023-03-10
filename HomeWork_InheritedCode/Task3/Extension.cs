using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Extension
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool Beep(uint dwFreq, uint dwDuration);

		public const int MB_ICONASTERISK = 0x00000040;
		public const int MB_ICONERROR = 0x00000010;

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MessageBeep(uint uType);
	}
}
