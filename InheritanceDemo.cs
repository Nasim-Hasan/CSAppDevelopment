using System;

namespace InheritanceDemo{
    
class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main()
  {
    // Create a myCar object
    Car myCar = new Car();
    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();
  }
}

    
}














