using System;

namespace OverridingDemo
{
    class X
    {
        protected virtual void Fun1()
        {
            Console.WriteLine("X.Fun1()");
        }

        protected virtual void Fun2()
        {
            Console.WriteLine("X.Fun2()");
        }

    }

    class Y:X
    {
        protected override void Fun1()
        {
            Console.WriteLine("Y.Fun1()");
        }

        protected override void Fun2()
        {
            Console.WriteLine("Y.Fun2()");
        }

    }


    class Program : Y
    {
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.Fun1();
            objProgram.Fun2();
        }
    }
}
