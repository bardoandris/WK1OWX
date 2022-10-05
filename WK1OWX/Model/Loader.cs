namespace WK1OWX.Model
{
    internal class Loader<T>
    {
        List<T> list = new();
        public List<T> LoadFromFile(string filename, Func<string, string, string, T> parseFunc)
        {
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var temp = reader.ReadLine().Split(';');
                    Parser<T> parser = new Parser<T>(parseFunc);
                    list.Add(parser.Parse(temp[0], temp[1], temp[2]));
                }


            }
            return list;
        }

    }
}
