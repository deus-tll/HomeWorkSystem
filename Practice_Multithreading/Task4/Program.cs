
namespace Task4
{
	internal class Program
	{
		private static object lockObject = new object();
		private static List<int> list = new();
		private 
		static void Main(string[] args)
		{
			Console.WriteLine("Main thread start");

			Thread threadGenerate = new(GenerateNumbers);
			threadGenerate.Priority = ThreadPriority.Highest;
			threadGenerate.Start();

			Thread threadMax = new(FindMax);
			Thread threadMin = new(FindMin);
			Thread threadAvg = new(FindAvg);
			Thread fileThread = new(SaveIntoFile);

			Console.WriteLine("Wait Result...");

			threadMax.Start();
			threadMax.Join();

			threadMin.Start();
			threadMin.Join();

			threadAvg.Start();
			threadAvg.Join();

			//TASK 5
			fileThread.Start();
			fileThread.Join();

			Console.WriteLine("Main thread end");
		}

		private static void GenerateNumbers()
		{
			lock (lockObject)
			{
				Random random = new();

				for (int i = 0; i < 10000; i++)
				{
					list.Add(random.Next(0, 501));
				}
			}
		}

		private static void FindMax()
		{
            Console.WriteLine($"Max = {list.Max()}");
		}

		private static void FindMin()
		{
			Console.WriteLine($"Min = {list.Min()}");
		}

		private static void FindAvg()
		{
			Console.WriteLine($"Avg = {list.Average()}");
		}

		private static void SaveIntoFile()
		{
			Console.WriteLine("Saving into file...");

			using (StreamWriter writer = new("NumbersAndResults.txt"))
			{
				for (int i = 0; i < list.Count;)
				{
					for (int j = 0; j < 40; j++, i++)
					{
						writer.Write($" {list[i]}");
					}
					writer.WriteLine("\n");
				}

				writer.WriteLine($"Maximum value: {list.Max()}");
				writer.WriteLine($"Minimum value: {list.Min()}");
				writer.WriteLine($"Average value: {list.Average()}");
			}

			Console.WriteLine("Saving into file is ended...");
		}
	}
}