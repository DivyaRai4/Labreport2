using System;

namespace UnaryOperatorOverloading
{
    class Number
    {
        public int Value { get; set; }

        
        public Number(int value)
        {
            Value = value;
        }

        
        public static Number operator -(Number n)
        {
            return new Number(-n.Value);
        }

       
        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            Number num1 = new Number(10);
            Console.WriteLine("Original number:");
            num1.Display();

            
            Number num2 = -num1;
            Console.WriteLine("After applying unary - operator:");
            num2.Display();

            Console.ReadKey();
        }*/
    }
}
