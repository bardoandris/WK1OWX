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
			TimeCost_SumLabel.Text = TotalTimeCost.ToString()+"ft";
			MaterialCost_SumLabel.Text = TotalMaterialCost.ToString() + "ft";
			SumTotal_SumLabel.Text = TotalMaterialCost.ToString()+"ft";

		}
	}
}
