//Calculating factorial in for loop and recursion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n value: ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Facotrial of {n} is {ForLoop(n)} using ForLoop ");
            Console.WriteLine($" Facotrial of {n} is {Recursion(n)} using Recursion ");
        }

        private static int ForLoop(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }


        private static int Recursion(int n)
        {
            if (n == 1)
                return 1;

            return n * Recursion(n - 1);
        }
    }
}
