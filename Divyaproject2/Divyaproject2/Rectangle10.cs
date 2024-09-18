using System;

namespace ShapeRectangleDemo
{
  
    class Shape
    {
       
        public double Length { get; set; }
        public double Breadth { get; set; }

      
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

       
        public void DisplayDimensions()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

   
    class Rectangle : Shape
    {
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

     
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);

            
            Console.WriteLine("Rectangle Dimensions:");
            rectangle.DisplayDimensions();

            
            double area = rectangle.CalculateArea();
            Console.WriteLine($"Area of the Rectangle: {area}");

            Console.ReadKey();
        }*/
    }
}
