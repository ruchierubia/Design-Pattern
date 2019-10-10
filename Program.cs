using System;

namespace Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton sg = Singleton.GetInstance;
            sg.PrintDetails(sg.GetHashCode().ToString());
            Singleton sg2 = Singleton.GetInstance;
            sg.PrintDetails(sg.GetHashCode().ToString());
        }
    }
}
