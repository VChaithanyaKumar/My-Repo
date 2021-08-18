using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 13, 14, 15, 16 };
            int k = n[2];
            Console.WriteLine("{0} is the required access.", k);
            foreach(int i in n)
            {
                Console.WriteLine(i);
            }

        }
    }
}
