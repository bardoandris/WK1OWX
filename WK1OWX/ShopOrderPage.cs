using WK1OWX.Model;

namespace WK1OWX
{
	public partial class ShopOrderPage : Form
	{
		bool CommitedtoClosing = false;
		ShopOrder ShopOrder { get; set; }
		Dictionary<CheckBox, Work> workOptions;
		public ShopOrderPage()
		{
			workOptions = new();
			ShopOrder = new();
			InitializeComponent();
			FillWork();
			this.FormClosing += ShopOrderPage_FormClosing;
		}

		private void ShopOrderPage_FormClosing(object? sender, FormClosingEventArgs e)
		{
			if (!CommitedtoClosing)
			{
				if(MessageBox.Show("Biztosan szeretné mentés nélkül bezárni ezt az ablakot?", "Figyelmeztetés", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					CommitedtoClosing = true;
					this.Close();
				}
				else
				{
				e.Cancel = true;
				}
			}
		}

		private void FillWork()
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

			foreach (Work work in ApplicationState.ApplicationStateInstance.WorkOptionList)
			{
				Label NameLabel = InitLabel(work.Name);
				NameLabel.Width = (int)WorkTable.ColumnStyles[0].Width * WorkTable.Width - 20;
				WorkTable.Controls.Add(NameLabel, 0, row);
				Label materialCost = InitLabel(work.MaterialCost.ToString());
				WorkTable.Controls.Add(materialCost, 1, row);
				CheckBox SelectedBox = new CheckBox() { Checked = false };
				WorkTable.Controls.Add(SelectedBox, 3, row);
				workOptions.Add(SelectedBox, work);
				SelectedBox.CheckedChanged += SelectedBox_CheckedChanged;
				Label time = InitLabel(work.DisplayTime);
				WorkTable.Controls.Add(time, 2, row);
				WorkTable.Refresh();
				row++;
			}

		}

		private void SelectedBox_CheckedChanged(object? sender, EventArgs e)
		{
			var box = sender as CheckBox;
			if (box == null)
			{
				throw new ArgumentNullException("This is not called by the Checkbox");
			}
			if (box.Checked)
			{
				ShopOrder.AddItem(workOptions[box]);
				WorkCostNumberLabel.Text = ShopOrder.TotalTimeCost
				.ToString() + "ft";
				MaterialCostNumberLabel.Text = ShopOrder.TotalMaterialCost
					.ToString() + "ft";
			}
			else
			{
				ShopOrder.DeleteItem(workOptions[box]);
				WorkCostNumberLabel.Text = ShopOrder.TotalTimeCost
					.ToString() + "ft";
				MaterialCostNumberLabel.Text = ShopOrder.TotalMaterialCost
					.ToString() + "ft";
			}
		}

		private void RogzitesGomb_Click(object sender, EventArgs e)
		{
			ApplicationState.ApplicationStateInstance.AddShopOrder(ShopOrder);
			CommitedtoClosing = true;
			Close();

		}
		private Label InitLabel(string text)
		{
			return new Label() { Text = text };

		}

		

	}
}
