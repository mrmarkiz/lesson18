using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    internal class Task3
    {
        public static void Run()
        {
            List<int> array = new List<int>()
            {
                2,3,7,7,4,6,8,12,6,8,7,4,2
            };
            Console.WriteLine("Array:");
            Task1.Show(array);
            List<int> distincts = array.Distinct().ToList();
            Console.WriteLine("\nRepeats of each element:");
            foreach (int i in distincts)
            {
                Console.WriteLine($"{i}: {array.Count(el => el == i)} reps");
            }

            Console.WriteLine("\nRepeats of odd elements:");
            foreach (int i in distincts.Where(el => el % 2 == 0))
            {
                Console.WriteLine($"{i}: {array.Count(el => el == i)} reps");
            }

            Console.WriteLine($"\nTotal repeats of odd elements: {array.Count(el => el % 2 == 0)}, " +
                $"total repeats of even elements: {array.Count(el => el % 2 == 1)}");
            
        }
    }
}
