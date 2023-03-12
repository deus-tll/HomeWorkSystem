using System.Threading;

namespace Task1
{
	internal class Program_Task1
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Main thread start");

			Thread thread = new(ShowNumbers);

			thread.Start();

			Console.WriteLine("Main thread end");
        }

		private static void ShowNumbers()
		{
			Console.WriteLine("ShowNumbers function start");

			for (int i = 0; i <= 50; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(10);
			}

			Console.WriteLine("ShowNumbers function end");
		}
	}
}