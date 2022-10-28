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
				if (MessageBox.Show("Biztosan szeretné mentés nélkül bezárni ezt az ablakot?", "Figyelmeztetés", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
			var instance = ApplicationState.ApplicationStateInstance;
			foreach (var item in instance.WorkOptionList)
			{
				var work = new WorkControl(item);
				work.SelectionChanged += SelectedBox_CheckedChanged;
				WorkTable.Controls.Add(work, 0, row++);
			}

		}

		private void SelectedBox_CheckedChanged(WorkControl work, bool isChecked)
		{

			if (isChecked)
			{
				ShopOrder.AddItem(work.Work);
				WorkCostNumberLabel.Text = ShopOrder.TotalTimeCost
				.ToString() + "ft";
				MaterialCostNumberLabel.Text = ShopOrder.TotalMaterialCost
					.ToString() + "ft";
			}
			else
			{
				ShopOrder.DeleteItem(work.Work);
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
