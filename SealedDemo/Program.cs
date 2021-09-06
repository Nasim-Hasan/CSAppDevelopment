using System;

namespace SealedDemo
{   
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());
        }
    }

    // Sealed class  
    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

    }


    }
