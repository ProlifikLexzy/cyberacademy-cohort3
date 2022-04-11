using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {

            var data = new Data();
            data.Add(1);
            data.Add(true);
            data.Add('\n');
        }
    }

    public interface IData
    {
        void Add<D>(D item);
    }

    public class Data : IData
    {
        private object[] _data;
        private int _index;

        public Data()
        {
            _data = new object[10];
        }

        public void Add<D>(D item)
        {
            _data[_index++] = item; 
        }
    }


}