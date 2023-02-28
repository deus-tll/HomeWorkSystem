using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CloseNotepad();
			Console.WriteLine("press key...");
			Console.ReadKey();
		}

		static void CloseNotepad()
		{
			IntPtr hWnd = Extension.FindWindow("Notepad", null);
			if (hWnd == IntPtr.Zero)
			{
				Console.WriteLine("Notepad window not found!");
				return;
			}

			Extension.SendMessage(hWnd, Extension.WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
		}
	}
}
