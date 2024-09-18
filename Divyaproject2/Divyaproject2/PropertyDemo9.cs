using System;

namespace PropertyTypesDemo
{
    class Product
    {
       
        public string Name { get; set; }

        private double _price;

       
        public double Price
        {
            get
            {
                return _price;
            }
        }

       
        public double Discount
        {
            set
            {
                _price -= value; 
            }
        }

       
        public double PriceAfterTax
        {
            get
            {
                return _price * 1.1;
            }
        }

        
        public Product(string name, double price)
        {
            Name = name;
            _price = price;
        }

      
        public void Display()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Price After Tax: {PriceAfterTax}");
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
           
            Product product = new Product("Laptop", 90000.00);

            
            Console.WriteLine("Initial Product Details:");
            product.Display();

            product.Discount = 100.00;
            Console.WriteLine("\nAfter Applying Discount:");
            product.Display();

            Console.ReadKey();
        }*/
    }
}
      