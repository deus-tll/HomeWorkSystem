namespace Task3_Output
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0) return;

			int first = Convert.ToInt32(args[0]);
			int second = Convert.ToInt32(args[1]);
			int res = 0;
			bool flag = true;

			switch (args[2])
			{
				case "/": res = first / second; break;
				case "-": res = first - second; break;
				case "*": res = first * second; break;
				case "+": res = first + second; break;
					default: flag = false; break; 
			}

			if (flag)
			{
				Console.WriteLine("First Number: " + first);
				Console.WriteLine("Second Number: " + second);
				Console.WriteLine("Operator: " + args[2]);
				Console.WriteLine("Result: " + res);
			}
			else
			{
				Console.WriteLine("First Number: " + first);
				Console.WriteLine("Second Number: " + second);
				Console.WriteLine("Operator: " + args[2]);
				Console.WriteLine("Result: " + "none");
			}

            Console.ReadKey();
        }
	}
}