using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Factorial(double number)
            {
                if (number <= 1)
                    return 1;
                else
                    return number * Factorial(number - 1);
            }

            void Main()
            {
                for (int i = 1; i < 101; i++)
                {
                    Console.WriteLine("{0}! = {1}", i, Factorial(i));
                }
                Console.ReadLine();
            }
        }
    }
}
