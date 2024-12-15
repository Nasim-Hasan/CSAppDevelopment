using System;

namespace ExceptionHandlingDemo{
    
class Program
{
  static void Main()
  {
     try{
           int[] myNumbers = {1, 2, 3};
           Console.WriteLine(myNumbers[10]);
     }
     catch (Exception ex)
     {
         Console.WriteLine("Exception Occurred");
         
     }
     finally{
         int[] myNumbers = {1, 2, 3};
         Console.WriteLine(myNumbers[0]);
     }
  }
}

    
}














