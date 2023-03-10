using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
	internal class Program
	{
		private static AutoResetEvent analyzing;
		static void Main(string[] args)
		{
			analyzing = new AutoResetEvent(true);
			NumbersList number = new NumbersList(analyzing);

			Thread threadGenerateList = new Thread(number.GenerateList);
			threadGenerateList.Priority = ThreadPriority.Highest;
			threadGenerateList.Start();

			Thread threadMax = new Thread(number.FillMax);
			Thread threadMin = new Thread(number.FillMin);
			Thread threadAvg = new Thread(number.FillAvg);

			threadMax.Start();
			threadMin.Start();
			threadAvg.Start();

            Console.WriteLine("Wait Result...");

            threadMax.Join();
			threadMin.Join();
			threadAvg.Join();

			Console.WriteLine(number.ToString()); 

			Console.ReadLine();
		}
	}

	internal class NumbersList
	{
		private int max;
		private int min;
		private double avg;
		private readonly AutoResetEvent analyzing;

		public NumbersList(AutoResetEvent analyzing)
		{
			this.analyzing = analyzing;
		}

		public List<int> Numbers { get; set; } = new List<int>();

		public void FillMax()
		{
			analyzing.WaitOne();
			max = Numbers.Max();
			analyzing.Set();
		}

		public void FillMin()
		{
			analyzing.WaitOne();
			min = Numbers.Min();
			analyzing.Set();
		}

		public void FillAvg()
		{
			analyzing.WaitOne();
			avg = Numbers.Average();
			analyzing.Set();
		}

		public void GenerateList()
		{
			analyzing.WaitOne();

			Random random = new Random();

			for (int i = 0; i < 1000; ++i)
			{
				Numbers.Add(random.Next(0, 5000));
			}

			analyzing.Set();
		}

		public override string ToString()
		{
			return $"Max = {max};\n" +
				   $"Min = {min};\n" +
				   $"Avg = {avg}";
		}
	}
}
