using System;
using System.Collections.Generic;
using System.Text;

namespace Design
{
    public sealed class Singleton // sealed keyword is need to avoid nested derived class that can create multiple instances
    {
        public static readonly Lazy<Singleton> instance = new Lazy<Singleton>(
          () => new Singleton()  
        );// To make it lazy loading Lazy object are thread safe
       // private static readonly object obj = new object(); // use as lock object to wrap instance creatio
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
                //if (instance == null) //double checked locking
                //{
                //    lock (obj) // lock to make sure only on thread can enter the code block at any given time
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                //    }
                //}

                return instance.Value;

            }
        }

        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }



        /*
         * Lazy loading vs eager loading
         * 
         * 
         * 
         * Static vs singleton
         * static only provide methods singleton is object
         * 
         * singleton uses realworld
         * 
         * logging
         * manage connection to database
         * printer pooling
         * file management
         * configuration
         * cache
         * session base shopping cart
         */
    }
}
