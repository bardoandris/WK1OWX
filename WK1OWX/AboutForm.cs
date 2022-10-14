using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			UpdateClock(CancellationToken);
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			cancellationTokenSource.Cancel();
			this.Close();
		}
		private async void UpdateClock(CancellationToken token)
		{
			while (!token.IsCancellationRequested)
			{
			//	try
			//	{
					TimeLabel.Invoke(() => TimeLabel.Text = "Jelenlegi idő: " + DateTime.Now);
					await Task.Delay(1000);
				//}catch(Exception e) { break; }
			}
		}
	}
}
