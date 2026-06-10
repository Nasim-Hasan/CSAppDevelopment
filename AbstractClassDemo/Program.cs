// File: Program.cs
using System;
using System.Collections.Generic;

namespace AbstractClassDemo
{
       // 1) Abstract base class: cannot be instantiated, defines a contract
    public abstract class Shape
    {
        protected string Name { get; }  // Accessible by derived types

        protected Shape(string name)     // Base constructor
        {
            Name = name;
        }

        // Virtual members enable polymorphism
        public virtual double Area() => 0;

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing {Name}...");
        }

        public override string ToString() => $"{Name} (Area = {Area():F2})";
    }

    // 2) Derived class: overrides virtual members, calls 'base' where useful
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;

        public override void Draw()
        {
            base.Draw(); // Optionally reuse base behavior
            Console.WriteLine($" -> Rect {Width} x {Height}");
        }
    }

    // 3) Another derived class
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Radius * Radius;

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($" -> Circle r = {Radius}");
        }
    }

    // 4) Sealed class: cannot be further inherited
    public sealed class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
        // Inherits Area() and Draw() from Rectangle
    }

    class Program
    {
        static void Main()
        {
            // Upcasting: store all derived objects as their base type (Shape)
            List<Shape> shapes = new()
            {
                new Rectangle(3, 4),
                new Circle(5),
                new Square(2)
            };

            // Polymorphism: correct override chosen at runtime
            foreach (var s in shapes)
            {
                s.Draw();
                Console.WriteLine(s);
                Console.WriteLine();
            }

            // Safe downcasting with pattern matching
            Shape maybeRect = new Rectangle(10, 2);
            if (maybeRect is Rectangle rect)
            {
                Console.WriteLine($"Downcast succeeded. Width={rect.Width}, Height={rect.Height}");
            }

            // The following would be illegal because Square is sealed:
            // class FancySquare : Square { }  // <- compile-time error
        }
    }
}