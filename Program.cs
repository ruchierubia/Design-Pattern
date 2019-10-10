using System;
using System.Threading.Tasks;

namespace Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // invoke parallel to check thread safe we create multiple instances
            Parallel.Invoke(
                    () => PrintA(),
                    () => PrintB()               
            );
        }

        private static void PrintA()
        {
            //method 1
            Singleton sg = Singleton.GetInstance;
            sg.PrintDetails(sg.GetHashCode().ToString());
        }

        private static void PrintB()
        {
            // method 2
            Singleton sg2 = Singleton.GetInstance;
            sg2.PrintDetails(sg2.GetHashCode().ToString());

        }
    }
}
