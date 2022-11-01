

using WK1OWX.Model;

namespace WK1OWX
{
	public partial class MainForm : Form
	{
		ApplicationState Appstate = ApplicationState.ApplicationStateInstance;
		bool ConfirmClose = false;
		List<Work> Works;
		public MainForm()
		{
			Works = new List<Work>();
			InitializeComponent();
			FormClosing += kil�p�sToolStripMenuItem_Click;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void f�jlMegnyit�saToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog
			{
				Multiselect = false,
				InitialDirectory = Application.StartupPath
			};

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					fizet�sToolStripMenuItem.Enabled = false;   //if Loading in new data fails, These Buttons
					munkalapToolStripMenuItem.Enabled = false;  //will stay disabled this way

					Works = new Loader<Work>().LoadFromFile(ofd.FileName, new Parser().Parse);
					ApplicationState.ApplicationStateInstance.Reset(Works);
					EditToolstripMenu.Enabled = false;

					fizet�sToolStripMenuItem.Enabled = true;    //enable if everything goes okay
					munkalapToolStripMenuItem.Enabled = true;

				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.ToString());
				}
				catch (NullReferenceException ex)
				{
					MessageBox.Show(ex.ToString());
				}
				catch (IndexOutOfRangeException ex)
				{
					MessageBox.Show("Rossz form�tum� f�jl!\n" + ex.ToString());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				return;
			}
		}

		private void munkalapToolStripMenuItem_Click(object sender, EventArgs e)
		{

			new ShopOrderPage().ShowDialog();
			UpdateEditComboBox();

		}

		private void fizet�sToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new PayForm().ShowDialog();
		}

		private void n�vjegyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutForm().Show();
		}

		private void kil�p�sToolStripMenuItem_Click(object? sender, EventArgs e)
		{
			if (!ConfirmClose)
			{
				if (MessageBox.Show("Biztosan szeretn� bez�rni ezt az ablakot?", "Figyelmeztet�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					ConfirmClose = true;
					Application.Exit();
				}

			}
		}

		private void UpdateEditComboBox()
		{
			if (Appstate.ShopOrderList.Count > 0)
			{
				EditToolstripMenu.Enabled = true;

			}
			List<ShopOrder> currentOrders = Appstate.ShopOrderList;
			EditToolstripMenu.DropDownItems.Clear();
			for (int i = 0; i < currentOrders.Count; i++)
			{
				var item = new ToolStripMenuItem("Order " + i, null, OnDropDownClick);
				EditToolstripMenu.DropDownItems.Add(item);
			}
		}
		private void OnDropDownClick(object? sender, EventArgs e)
		{
			int index = EditToolstripMenu.DropDownItems.IndexOf(sender as ToolStripMenuItem);
			ShopOrderPage shopOrderPage = new(Appstate.ShopOrderList[index]);
			shopOrderPage.ShowDialog();
		}
	}
}