using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	public class Range
	{
		private int _start;
		private int _end;

		public Range(int start, int end)
		{
			_start = start;
			_end = end;
		}

		public void ShowNumbers()
		{
			Console.WriteLine("ShowNumbers function start");

			if (_end > _start)
			{
				for (int i = _start; i <= _end; i++)
				{
					Console.WriteLine(i);
					Thread.Sleep(50);
				}
			}
			else
			{
				for (int i = _end; i <= _start; i++)
				{
					Console.WriteLine(i);
					Thread.Sleep(1);
				}
			}

			Console.WriteLine("ShowNumbers function end");
		}
	}
}
