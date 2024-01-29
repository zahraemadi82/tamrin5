using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Even(n);
            }
            else
            {
                Odd(n);
            }

            Console.ReadKey();
        }

        private static void Even(int n)
        {
            int sum = 0, num = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                num *= i;
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + num);
        }

        private static void Odd(int n)
        {
            int sum = 0, num = 1;

            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
                num *= i;
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + num);
        }
    }
}


