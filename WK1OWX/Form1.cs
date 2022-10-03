

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
				var lines =File.ReadAllLines(ofd.FileName);
				Works = new Loader<Work>().ParseLines(lines, Work.ParseWork);
				return;
			}
		}
	}
}