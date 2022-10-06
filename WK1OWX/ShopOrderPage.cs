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
		Dictionary<Work, CheckBox?> workOptions;
		public ShopOrderPage(List<Work> workOptions)
		{
			this.workOptions = new();
			InitializeComponent();
			foreach (var work in workOptions)
			{
				this.workOptions.Add(work, null); //Dictionary talán??
			}
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
			
			foreach (Work work in workOptions.Keys)
			{
				Label NameLabel = InitLabel(work.Name);
					NameLabel.Width = (int)WorkTable.ColumnStyles[0].Width * WorkTable.Width - 20;
					WorkTable.Controls.Add(NameLabel, 0,row);
				Label materialCost = InitLabel(work.MaterialCost.ToString());
					WorkTable.Controls.Add(materialCost, 1, row);
				CheckBox SelectedBox = new CheckBox() { Checked = false };
					WorkTable.Controls.Add(SelectedBox, 3, row);
					workOptions.
				Label time = InitLabel(work.DisplayTime);
					WorkTable.Controls.Add(time, 2, row);
				WorkTable.Refresh();
				row++;
			}

		}

		private void RogzitesGomb_Click(object sender, EventArgs e)
		{

		}
		private Label InitLabel(string text)
		{
			return new Label() { Text = text };
			}
		private void LinkCheckBox(Work work, CheckBox check)
		{
			
		}
	}
}
