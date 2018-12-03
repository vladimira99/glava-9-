﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6
{
    class Program
    {
        static void Main(string[] args)
        {
          int number = int.MinValue;

            void CompareNumber(int[] arr)
            {
                for (int i = 1; i < arr.Length - 1; i++)
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        number = arr[i];
                        break;
                    }
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

                CompareNumber(arr);

                if (number == int.MinValue) Console.WriteLine("-1");
                else Console.WriteLine("{0} is bigger than it's neighbours", number);
            }
        }
    }
}
