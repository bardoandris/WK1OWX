namespace WK1OWX.Model
{
    internal class Loader<T>
    {
        List<T> list = new();
        public List<T> LoadFromFile(string filename, Func<string[], T> parseFunc)
        {
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    list.Add(parseFunc(reader.ReadLine().Split(';')));
                }


            }
            return list;
        }

    }
}
