namespace WK1OWX.Model
{
	internal class Parser
	{
		public Work Parse(string[] columns)
		{
			return new Work(columns[0], int.Parse(columns[1]), int.Parse(columns[2]));
		}

	}
}
