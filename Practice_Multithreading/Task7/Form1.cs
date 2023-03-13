namespace Task7
{
	public partial class Form1 : Form
	{
		private static object lockObject = new object();
		private static List<int> list = new();

		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			Thread threadGenerate = new(GenerateNumbers)
			{
				Priority = ThreadPriority.Highest
			};


			threadGenerate.Start();
			threadGenerate.Join();


			Thread threadMax = new(FindMax);
			Thread threadMin = new(FindMin);
			Thread threadAvg = new(FindAvg);
			Thread fileThread = new(SaveIntoFile);


			threadMax.Start();
			threadMin.Start();
			threadAvg.Start();
			fileThread.Start();
		}

		private void GenerateNumbers()
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

		private void FindMax()
		{
			TextBox_Max.Invoke((MethodInvoker)delegate ()
			{
				TextBox_Max.Text = list.Max().ToString();
			});
		}

		private void FindMin()
		{
			TextBox_Min.Invoke((MethodInvoker)delegate ()
			{
				TextBox_Min.Text = list.Min().ToString();
			});
		}

		private void FindAvg()
		{
			TextBox_Avg.Invoke((MethodInvoker)delegate ()
			{
				TextBox_Avg.Text = list.Average().ToString();
			});
		}

		private void SaveIntoFile()
		{
			using (StreamWriter writer = new("NumbersAndResults.txt"))
			{
				for (int i = 0; i < list.Count;)
				{
					for (int j = 0; j < 40; j++, i++)
					{
						if (j == 0)
						{
							writer.Write($"{list[i]}");
						}
						else
						{
							writer.Write($" {list[i]}");

						}
					}
					writer.WriteLine("\n");
				}

				writer.WriteLine($"Maximum value: {list.Max()}");
				writer.WriteLine($"Minimum value: {list.Min()}");
				writer.WriteLine($"Average value: {list.Average()}");
			}
		}
	}
}