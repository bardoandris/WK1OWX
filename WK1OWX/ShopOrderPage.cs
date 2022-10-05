using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK1OWX.Model;

namespace WK1OWX
{
	public partial class ShopOrderPage : Form
	{
		List<Work> workOptions;
		public ShopOrderPage(List<Work> workOptions)
		{
			InitializeComponent();
			this.workOptions = workOptions;
			FillWorks();
		}

		private void FillWorks()
		{
			
			WorkTable.RowCount = workOptions.Count;
			
			for (int i = 0; i < WorkTable.RowStyles.Count; i++)
			{
				WorkTable.RowStyles[i].Height = 50;
				WorkTable.RowStyles[i].SizeType = SizeType.Absolute;
			}
			WorkTable.Refresh();
			int row = 0;
			
			foreach (Work work in workOptions)
			{
				Label NameLabel = new();
				NameLabel.Text = work.Name;
				NameLabel.AutoSize = false;
				WorkTable.Controls.Add(NameLabel, 0,row++);
				WorkTable.Refresh();
			}

		}

	}
}
