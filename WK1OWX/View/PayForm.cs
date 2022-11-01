using System.Data;
using System.Text;
using WK1OWX.Model;

namespace WK1OWX
{
	public partial class PayForm : Form
	{
		ApplicationState AppState = ApplicationState.ApplicationStateInstance;
		public PayForm()
		{
			var TotalMaterialCost = (from Order in AppState.ShopOrderList
									 select Order.TotalMaterialCost).Sum();
			var TotalTimeCost = (from Order in AppState.ShopOrderList
								 select Order.TotalTimeCost).Sum();
			int TotalCost = TotalMaterialCost + TotalTimeCost;
			InitializeComponent();
			ShopOrder_CountLabel.Text = AppState.ShopOrderList.Count.ToString();
			TimeCost_SumLabel.Text = TotalTimeCost.ToString() + "ft";
			MaterialCost_SumLabel.Text = TotalMaterialCost.ToString() + "ft";
			SumTotal_SumLabel.Text = TotalCost.ToString() + "ft";
			TotalNumberofWork_SumLabel.Text = (from Order in AppState.ShopOrderList
											   select Order.NumberofWorks).Sum().ToString();
			var TotalMinutes = (from Order in AppState.ShopOrderList
											select Order.TotalTime_Minutes).Sum();
			StringBuilder stringBuilder = new();
			stringBuilder.Append(TotalMinutes < 60 ? "" : TotalMinutes / 60 + "ó ");
			stringBuilder.Append(TotalMinutes % 60 + "p");
			TotalTimeLabel_SumLabel.Text = stringBuilder.ToString();

		}
	}
}
