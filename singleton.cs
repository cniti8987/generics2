using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class singleton
    {

        public static void main(string[] args)
        {
            singletonclass singleto = singletonclass.getinstances();
            singleto.somemethod();

            singletonclass single2 = singletonclass.getinstances();
            single2.somemethod();

        }


    }

    public class singletonclass
    {

        private static singletonclass _instance;
        private int _count = 1;

        protected singletonclass()
        {

        } 

        public static singletonclass getinstances()
        {
            if(_instance!=null)
            {
                return _instance;
            }
            else
            {
                _instance = new singletonclass();
                return _instance;
            }
        }
        public void somemethod()
        {
            Console.WriteLine(_count);
            _count++;
        }
    }
}
