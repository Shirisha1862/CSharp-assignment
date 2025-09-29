using System;


namespace GreatestProductFinder { 
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number: ");
            string input = Console.ReadLine() ?? string.Empty;

            var calculator = new ProductCalculator();
            var (product, digits) = calculator.FindGreatestProduct(input);

            if (product > 0)
            {
                Console.WriteLine($"{string.Join("*", digits.ToCharArray())} = {product}");
            }
            else
            {
                Console.WriteLine("Invalid input or number too short.");
            }
        }
    }
}

