

using WK1OWX.Model;

namespace WK1OWX
{
	public partial class Form1 : Form
	{
		bool ConfirmClose = false;
		List<Work> Works;
		public Form1()
		{
			Works = new List<Work>();
			InitializeComponent();
			FormClosing += kilépésToolStripMenuItem_Click;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void fájlMegnyitásaToolStripMenuItem_Click(object sender, EventArgs e)
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
					fizetésToolStripMenuItem.Enabled = false;	//if Loading in new data fails, These Buttons
					munkalapToolStripMenuItem.Enabled = false;	//will stay disabled this way

					Works = new Loader<Work>().LoadFromFile(ofd.FileName, Parser.Parse);
					ApplicationState.ApplicationStateInstance.Reset(Works);
					
					fizetésToolStripMenuItem.Enabled = true;	//enable if everything goes okay
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
					MessageBox.Show("Rossz formátumú fájl!\n"+ ex.ToString());
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
			new ShopOrderPage().Show();
		}

		private void fizetésToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new PayForm().Show();
		}

		private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutForm().Show();
		}

		private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!ConfirmClose )
			{
				if (MessageBox.Show("Biztosan szeretné bezárni ezt az ablakot?", "Figyelmeztetés", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					ConfirmClose = true;
					Application.Exit();
				}
			
			}
		}
	}
}