using WK1OWX.Model;

namespace WK1OWX
{
	public partial class ShopOrderPage : Form
	{
		readonly ShopOrder? oldShoporder;
		readonly bool isEditing = false;
		bool CommitedtoClosing = false;
		ShopOrder ShopOrder { get; set; }

		public ShopOrderPage()
		{

			ShopOrder = new();
			InitializeComponent();
			FillWork();

			this.FormClosing += ShopOrderPage_FormClosing;
		}
		public ShopOrderPage(ShopOrder shopOrder) : this()
		{
			isEditing = true;
			ShopOrder = shopOrder.Copy();
			oldShoporder = shopOrder;
			foreach (var item in WorkTable.Controls)
			{
				if (item is WorkControl)
				{
					var castItem = item as WorkControl;
					castItem.SetCheckBox(ShopOrder.ContainsElement(castItem.Work));
				}

			}

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
			var result = MessageBox.Show("El szeretné menteni a munkalapot?", "Figyelmeztetés", MessageBoxButtons.YesNo);
			if (result != DialogResult.Yes)
			{
				return;
			}
			if (!isEditing)
			{
				ApplicationState.ApplicationStateInstance.AddShopOrder(ShopOrder);
			}
			else
			{
				ApplicationState.ApplicationStateInstance.RemoveShoporder(oldShoporder);
				ApplicationState.ApplicationStateInstance.AddShopOrder(ShopOrder);
			}
			CommitedtoClosing = true;
			Close();

		}


	}
}
