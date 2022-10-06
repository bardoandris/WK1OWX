

using WK1OWX.Model;

namespace WK1OWX
{
	public partial class Form1 : Form
	{
		List<Work> Works;
		public Form1()
		{
			Works = new List<Work>();
			InitializeComponent();
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

					Works = new Loader<Work>().LoadFromFile(ofd.FileName, Parser.Parse);
					ApplicationState.GetApplicationState.Reset();

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
			new ShopOrderPage(Works).Show();
		}
	}
}