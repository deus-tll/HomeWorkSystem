namespace Task2
{
	internal class Program_Task2
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main thread start");

            Console.Write("Enter the start of range: ");
            if (!(int.TryParse(Console.ReadLine(), out int start))) return;

			Console.Write("Enter the end of range: ");
			if (!(int.TryParse(Console.ReadLine(), out int end))) return;

			Range range = new(start, end);

			Thread thread = new(range.ShowNumbers);

			thread.Start();

			Console.WriteLine("Main thread end");
		}
	}
}