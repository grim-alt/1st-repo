using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Last element: " + numbers[4]);

            Console.WriteLine("All elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
