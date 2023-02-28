using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ShowMessage();
			Console.WriteLine("press key...");
			Console.ReadKey();
		}

		static void ShowMessage()
		{
			Extension.MessageBox(IntPtr.Zero, "Hello World!", "Message",
				Extension.MB_OK | Extension.MB_ICONINFORMATION);
		}
	}
}
