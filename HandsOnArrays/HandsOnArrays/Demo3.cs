using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo3
    {
        static void Main()
        {
            int[] numbers = { 12, 23, 34, 45, 56, 67, 78, 89 };
            Console.WriteLine("Count: " + numbers.Length);
            Array.Reverse(numbers);
            foreach (int n in numbers)
                Console.WriteLine(n);
            int[] b = new int[4];
            Array.Copy(numbers, b, 4);
            foreach (int n in b)
                Console.WriteLine(n);
        }
    }
}
