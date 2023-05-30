using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    internal class Task1
    {
        public static void Run()
        {
            List<int> array = new List<int>()
            {
                1,2,3,9,24,27,1400,2100
            };
            Console.WriteLine("Array:");
            Show(array);
            Console.WriteLine($"Array count: {array.Count()}");
            Console.WriteLine($"Number of els multiple by 9: {array.Count(el => el % 9 == 0)}");
            Console.WriteLine($"Number of els multiple by 7 and bigger than 945: {array.Count(el => el % 7 == 0 && el > 945)}");
            Console.WriteLine($"Sum of elements of the array: {array.Sum()}");
            Console.WriteLine($"Sum of elements of even els of the array: {array.Where(el => el % 2 == 0).Sum()}");
            Console.WriteLine($"Max element: {array.Max()}");
            Console.WriteLine($"Min element: {array.Min()}");
            Console.WriteLine($"Avg value of array: {(double)array.Sum() / array.Count()}");

        }

        public static void Show(List<int> array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
