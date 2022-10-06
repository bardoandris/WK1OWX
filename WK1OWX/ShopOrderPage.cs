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
			WorkTable.RowStyles.Clear();
			WorkTable.RowCount = workOptions.Count;
			for (int i = 0; i < WorkTable.RowStyles.Count; i++)
			{
				WorkTable.RowStyles[i].SizeType = SizeType.Absolute;
				WorkTable.RowStyles[i].Height = 200;
			}
			WorkTable.Refresh();
			int row = 0;
			
			foreach (Work work in workOptions)
			{
				Label NameLabel = new();
				NameLabel.Text = work.Name;
				NameLabel.Width = (int)WorkTable.ColumnStyles[0].Width * WorkTable.Width - 20;
				WorkTable.Controls.Add(NameLabel, 0,row);
				Label materialCost = new();
				materialCost.Text = work.MaterialCost.ToString();
				WorkTable.Controls.Add(materialCost, 1, row);
				CheckBox SelectedBox = new CheckBox() { Checked = false };
				WorkTable.Controls.Add(SelectedBox, 2, row);
				Label TimeCost
				WorkTable.Refresh();
			}

		}

		private void RogzitesGomb_Click(object sender, EventArgs e)
		{

		}
	}
}
