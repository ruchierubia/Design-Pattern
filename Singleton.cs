using System;
using System.Collections.Generic;
using System.Text;

namespace Design
{
    public sealed class Singleton // sealed keyword is need to avoid nested derived class that can create multiple instances
    {
        public static Singleton instance = null;
        private Singleton()
        {

        }

        public static Singleton GetInstance
        {

            //if (instance == null)
            //    instance = new Singleton();

            //return instance;
            get 
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;

            }
        }

        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }
    }
}
