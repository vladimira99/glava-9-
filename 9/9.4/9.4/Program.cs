using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountNumber(int number, int[] arr)
            {
                int counter = 0;

                for (int i = 0; i < arr.Length; i++) if (number == arr[i]) counter++;

                return counter;
            }

            void Main()
            {
                Console.Write("Enter array length: ");
                int length = Int32.Parse(Console.ReadLine());

                int[] arr = new int[length];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Enter {0} element: ", i);
                    arr[i] = Int32.Parse(Console.ReadLine());
                }

                Console.Write("Enter number: ");
                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine("{0} was found {1} times.", number, CountNumber(number, arr));
            }
        }
    }
}
