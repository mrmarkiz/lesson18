using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    internal class Task2
    {
        public static void Run()
        {
            List<int> array = new List<int>()
            {
                1,2,2100,3,27,9,24,1400
            };
            Console.WriteLine("Array:");
            Task1.Show(array);
            Console.WriteLine("Three first max els:");
            array = array.OrderByDescending(el => el).ToList();
            Task1.Show(array.Take(3).ToList());

            Console.WriteLine("Three first min els:");
            Task1.Show(array.Skip(array.Count() - 3).ToList());
        }
    }
}
