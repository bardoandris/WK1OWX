using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WK1OWX
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private async void AboutForm_Load(object sender, EventArgs e)
		{
			while (true)
			{
				TimeLabel.Text = "Jelenlegi idő: " + DateTime.Now; 
				await Task.Delay(1000);
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
