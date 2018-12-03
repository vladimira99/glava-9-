using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverse(string number)
            {
                char[] charArray = number.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

           void Main()
            {
                Console.Write("Enter number: ");
                string number = Console.ReadLine();

                Console.WriteLine(Reverse(number));
            }
        }
    }
}
