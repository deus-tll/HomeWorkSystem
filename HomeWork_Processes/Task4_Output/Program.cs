namespace Task4_Output
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0) return;

			int count = 0;
			string path = args[0];
			string word = args[1];

			using (StreamReader sr = new (path))
			{
				string content = sr.ReadToEnd();
				string[] words = content.Split(new char[] {' ', '\t', '\n', '\r', '.', ',', '!', '?', ':', ';'}, StringSplitOptions.RemoveEmptyEntries);
				count += words.Count(w => w == word);
			}

			Console.WriteLine($"Count of Word - {word} = {count}");

			Console.ReadKey();
		}
	}
}