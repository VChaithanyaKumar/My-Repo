using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo2
    {
        static void Main()
        {
            int[] n = { 213, 43, 7564, 89 };
            char[] ch = { 'a', 'b', 'c' };
            double[] price = { 12.34, 34.45, 56.67, 78.86 };
            string[] flowers = { "Rose", "Lilly", "Tulip" };
            foreach(string s in flowers)
            {
                if (s.Length > 4)
                Console.Write(s + "\t");
            }
        }

    }
}
