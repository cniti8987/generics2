using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Mygenericlist<string> strlist = new Mygenericlist<string>();
            strlist.add("rsdhakrisna");

            Mygenericlist<int> intlist = new Mygenericlist<int>();
            intlist.add(1);


            Console.WriteLine(strlist.Get());
            Console.WriteLine(intlist.Get());
            Mygenericlist<customer> cuslist = new Mygenericlist<customer>();

        }
    }
    public class customer
    {
        public string Name { get; set; }
    }
    public class Mygenericlist<T>
    {
        private T[] _stringarray;
        private int _addposition = 0;
        private int _getposition = 0;

        public Mygenericlist()
        {
            _stringarray = new T[1000];

        }

        public void add(T item)
        {
            _stringarray[_addposition] = item;
            _addposition++;
        }
        public T Get()
        {
            T item = _stringarray[_getposition];
            _getposition++;
            return item;
        }
    }
}
