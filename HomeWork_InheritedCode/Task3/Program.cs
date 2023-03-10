namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 3; i++)
			{
				Extension.Beep(300, 222);
				Thread.Sleep(500);
			}

			Extension.Beep(100, 222);
			Thread.Sleep(350);

			for (int i = 0; i < 2; i++)
			{
				Extension.Beep(300, 222);
				Thread.Sleep(150);
			}

			Thread.Sleep(100);
			Extension.Beep(100, 222);
			Thread.Sleep(220);

			for (int i = 0; i < 2; i++)
			{
				Extension.Beep(300, 222);
				Thread.Sleep(150);
			}



			Extension.MessageBeep(Extension.MB_ICONASTERISK);
			Thread.Sleep(1000);
			Extension.MessageBeep(Extension.MB_ICONERROR);
			Thread.Sleep(1000);
			Extension.MessageBeep(Extension.MB_ICONASTERISK);
			Thread.Sleep(1000);
		}
	}
}