using System.Threading;

namespace Task3
{
	internal class Program_Task3
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main thread start");

			Console.Write("Enter the count of threads: ");
			if (!(int.TryParse(Console.ReadLine(), out int numThreads))) return;

			Console.Write("Enter the start of range: ");
			if (!(int.TryParse(Console.ReadLine(), out int start))) return;

			Console.Write("Enter the end of range: ");
			if (!(int.TryParse(Console.ReadLine(), out int end))) return;

			for (int i = 0; i < numThreads; i++)
			{
				int threadStartNum = start + ((end - start + 1) / numThreads) * i;
				int threadEndNum = threadStartNum + (end - start + 1) / numThreads - 1;

				if (i == numThreads - 1)
				{
					threadEndNum = end;
				}

				Thread thread = new(() => ShowNumbers(threadStartNum, threadEndNum));
				thread.Start();
				thread.Join();
			}

			Console.WriteLine("Main thread end");
		}

		public static void ShowNumbers(int start, int end)
		{
            Console.WriteLine($"Start thread with ID - {Environment.CurrentManagedThreadId}");

			for (int i = start; i <= end; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(1);
			}

			Console.WriteLine($"End thread with ID - {Environment.CurrentManagedThreadId}");
		}
	}
}