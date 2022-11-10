using System.Linq.Expressions;

namespace WK1OWX.Model
{
	internal class Loader<T>
	{
		List<T> list = new();
		public List<T> LoadFromFile(string filename, Func<string[], T> parseFunc)
		{
			using (var reader = new StreamReader(filename))
			{
				try
				{
					while (!reader.EndOfStream && reader != null)
					{
						list.Add(parseFunc(reader.ReadLine().Split(';')));
					}
				}
				catch (NullReferenceException ex)
				{
					Console.WriteLine(ex.Message);
					MessageBox.Show(ex.StackTrace);
				}

				catch (IOException ex)
				{
					Console.WriteLine(ex.Message);
					MessageBox.Show(ex.StackTrace);
				}


			}
			return list;
		}

	}
}
