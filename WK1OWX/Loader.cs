using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK1OWX
{
	internal class Loader<T>
	{
		List<T> values = new();
		internal List<T> ParseLines(string[] lines, Func<string, T> parserFunc)
		{
			bool iterBool = true;
			T? temp = default(T);
			values = new List<T>();
			for (int i = 0 ; i < lines.Length && iterBool ; i++)
			{
				iterBool = Parser.TryParseString(lines[i], parserFunc, out temp);
			}
			if (!iterBool)
			{
				throw new Exception();
			}
			return values;
			
		}
	}
}
