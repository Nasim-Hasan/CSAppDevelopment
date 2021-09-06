using System;

namespace DelegateDemo
{
    class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void addition(int a, int b)
        {
            Console.WriteLine("Addition:" + (a + b));
        
        }

        public void subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction:" + (a-b));
        }
        
        
        static void Main(string[] args)
        {
            Program obj = new Program();

            addnum delobj1 = new addnum(obj.addition);
            subnum delobj2 = new subnum(obj.subtraction);

            delobj1(10, 40);
            delobj2(100, 50);
        }
    }
}
