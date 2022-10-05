using System.Diagnostics;

namespace WK1OWX.Model
{
    internal class Parser<T>
    {
        private readonly Func<string, string, string, T> factoryFunc;

        public Parser(Func<string, string, string, T> factoryFunc)
        {
            this.factoryFunc = factoryFunc;
        }
        public T Parse(string name, string time, string cost)
        {
            return factoryFunc.Invoke(name, cost, time);
        }
    }
}
