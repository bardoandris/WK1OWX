namespace WK1OWX
{
	public partial class AboutForm : Form
	{
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		CancellationToken CancellationToken;
		public AboutForm()
		{
			InitializeComponent();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			CancellationToken = cancellationTokenSource.Token;
			Task.Run(() => UpdateClock(CancellationToken));
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
			this.Close();
		}
		private void UpdateClock(CancellationToken token)
		{
			while (!CancellationToken.IsCancellationRequested)
			{
				try
				{
					//néha nem frissül a cancellation időben, így érvénytelenül próbál módosítani a labelen 
					TimeLabel.Invoke(() => TimeLabel.Text = "Jelenlegi idő: " + DateTime.Now);
				}
				catch (InvalidOperationException e)
				{
					Console.WriteLine(e.ToString());
				}
				Thread.Sleep(1000);

			}
		}
	}
}
