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
	public partial class WorkControl : UserControl
	{
		public Work Work { get; }
		public delegate void SelectionChangedHandler(WorkControl sender, bool isChecked);
		public WorkControl(Work work)
		{
			InitializeComponent();
			WorkNameLabel.Text = work.Name;
			MaterialCostLabel.Text = work.MaterialCost.ToString();
			SelectBox.Checked = false;
			TimeLabel.Text = work.DisplayTime;
			WorkTimeCost.Text = work.TimeCost.ToString();
			WorkTimeCost.Visible = false;
			Work = work;
		}

		private void SelectBox_CheckedChanged(object sender, EventArgs e)
		{
			if (SelectBox.Checked)
			{
				WorkTimeCost.Visible = true;
			}
			else
			{
				WorkTimeCost.Visible = false;
			}
			SelectionChanged?.Invoke(this, SelectBox.Checked);
		}
		public event SelectionChangedHandler? SelectionChanged;
		public void SetCheckBox(bool state)
		{
			SelectBox.Checked = state;
		}
	}
}
