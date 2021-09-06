using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInterfacesDemo
{
    interface IFirstInterface
    {
       void text();

    }

    interface ISecondInterface
    {
        void othertext();

    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void text()
        {
            Console.WriteLine("Some Text");
        }

        public void othertext()
        {
            Console.WriteLine("Some Other Text");
        }



    }

}
