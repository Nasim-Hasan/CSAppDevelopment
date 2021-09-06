using System;

namespace NestedClasswithInheritance
{
    
    class Base
    {
        protected static int bx = 10;

    }

    class Program:Base  //...Inheritance..//
    {
        private static int cx = 11;

        public class Derive 
        {
            public static int dx = bx + cx;

        
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("The Result is:"+Derive.dx);
        }
    }
}
