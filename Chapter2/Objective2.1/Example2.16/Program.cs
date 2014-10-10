using System;

namespace Example2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product() { Price = 1000 };
            Calculator calc = new Calculator();
            Console.WriteLine("Discount of {0} is {1}", p.Price, calc.CalculateDiscount(p));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
