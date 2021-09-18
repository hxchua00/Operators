using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum, diff, mult, div;
            try
            {
                sum = Mathematics.Add(int.Parse(args[0]), int.Parse(args[1])).ToString();
                diff = Mathematics.Subtract(int.Parse(args[0]), int.Parse(args[1])).ToString();
                mult = Mathematics.Multiply(int.Parse(args[0]), int.Parse(args[1])).ToString();
                div = Mathematics.Divide(int.Parse(args[0]), int.Parse(args[1])).ToString();

                Console.WriteLine();
                Console.WriteLine("Sum of the 2 numbers: " + sum);
                Console.WriteLine("Difference of the 2 numbers: " + diff);
                Console.WriteLine("Multiplication of the 2 numbers: " + mult);
                Console.WriteLine("Division of the 2 numbers: " + div);
                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Cannot be divided by 0! '{e}'");
                Console.WriteLine();
            }

            sum = Mathematics.Add(int.Parse(args[0]), int.Parse(args[1])).ToString();
            diff = Mathematics.Subtract(int.Parse(args[0]), int.Parse(args[1])).ToString();
            mult = Mathematics.Multiply(int.Parse(args[0]), int.Parse(args[1])).ToString();
            div = Mathematics.Divide(int.Parse(args[0]), int.Parse(args[1])).ToString();

            Console.WriteLine();
            Console.WriteLine("Sum of the 2 numbers: " + sum);
            Console.WriteLine("Difference of the 2 numbers: " + diff);
            Console.WriteLine("Multiplication of the 2 numbers: " + mult);
            Console.WriteLine("Division of the 2 numbers: " + div);
            Console.ReadLine();
        }
    }

    class Mathematics
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            if(x > y)
            {
                return x - y;
            }
            return y - x;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
                if (x > y)
                {
                    return x / y;
                }
                return y / x;
        }
    }
}
