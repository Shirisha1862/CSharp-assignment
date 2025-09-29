using System;

namespace FloatBinaryAdder
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter first float: ");
            float first = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter second float: ");
            float second = Convert.ToSingle(Console.ReadLine());

            var calculator = new BinaryFloatCalculator();

            string binaryFirst = calculator.FloatToBinary(first);
            string binarySecond = calculator.FloatToBinary(second);

            Console.WriteLine("Binary of first: " + binaryFirst);
            Console.WriteLine("Binary of second: " + binarySecond);

            // add them
            float floatSum = first + second;

            string binarySum = calculator.FloatToBinary(floatSum);

            Console.WriteLine("Binary Sum: " + binarySum);
            Console.WriteLine("Float Result: " + floatSum);
        }
    }
}
