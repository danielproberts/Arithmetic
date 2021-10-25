using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1, val2;
            int num1, num2;
            Console.Write("Input the first number: ");
            val1 = Console.ReadLine();
            num1 = Convert.ToInt32(val1);
            Console.Write("Input the second number: ");
            val2 = Console.ReadLine();
            num2 = Convert.ToInt32(val2);

            Console.WriteLine();
            Console.WriteLine("Addition");
            Console.WriteLine(val1 + " + " + val2 + " = " + (num1 + num2));

            Console.WriteLine();
            Console.WriteLine("Subtraction");
            Console.WriteLine(val1 + " - " + val2 + " = " + (num1 - num2));

            Console.WriteLine();
            Console.WriteLine("Multiplication");
            Console.WriteLine(val1 + " * " + val2 + " = " + (num1 * num2));

            Console.WriteLine();
            Console.WriteLine("Division");
            Console.WriteLine(val1 + " / " + val2 + " = " + ((float)num1 / (float)num2));

            Console.WriteLine();
            Console.WriteLine("Modulus");
            Console.WriteLine(val1 + " mod " + val2 + " = " + (num1 % num2));

            Console.ReadKey();
        }
    }
}
