using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Task6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			ListBox_Numbers.Items.Clear();

			if (!int.TryParse(TextBox_Threads.Text, out int numThreads)) return;
			if (!int.TryParse(TextBox_StartRange.Text, out int start)) return;
			if (!int.TryParse(TextBox_EndRange.Text, out int end)) return;

			int range = end - start + 1;
			int chunkSize = range / numThreads;

			int[] startNumbers = new int[numThreads];
			int[] endNumbers = new int[numThreads];

			for (int i = 0; i < numThreads; i++)
			{
				startNumbers[i] = start + i * chunkSize;
				endNumbers[i] = startNumbers[i] + chunkSize - 1;

				if (i == numThreads - 1)
				{
					endNumbers[i] = end;
				}
			}

			BackgroundWorker worker = new();
			worker.DoWork += (s, args) =>
			{
				for (int i = 0; i < numThreads; i++)
				{
					ShowNumbers(startNumbers[i], endNumbers[i]);
				}
			};
			worker.RunWorkerCompleted += (s, args) =>
			{
				Btn_Start.Enabled = true;
			};

			Btn_Start.Enabled = false;
			worker.RunWorkerAsync();
		}

		private void ShowNumbers(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Invoke((MethodInvoker)delegate ()
				{
					ListBox_Numbers.Items.Add(i.ToString());
				});

				Thread.Sleep(1);
			}
		}
	}
}