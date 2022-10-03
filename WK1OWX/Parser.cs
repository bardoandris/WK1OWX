using System.Diagnostics;

namespace WK1OWX
{
	internal class Parser
	{
		static Parser()
		{
		}
		internal static bool TryParseString<T>(string line, Func<string, T> parseFunc, out T? result)
		{
			try
			{
				result = parseFunc(line);
				return true;
			}catch(ArgumentException e )
			{
				result = default(T);
				return false;
			}catch(Exception e )
			{
				result = default(T);
				return false;
			}
		}
	}
}
