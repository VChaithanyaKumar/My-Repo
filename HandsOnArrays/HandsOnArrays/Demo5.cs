using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo5
    {
        static void Main()
        {
            int[,] twod = new int[3, 2];
            twod[0, 0] = 10;
            twod[0, 1] = 23;
            twod[1, 0] = 34;
            twod[1, 1] = 35;
            twod[2, 0] = 89;
            twod[2, 1] = 56;
            int k = twod[1, 0];
            foreach (int i in twod)
                Console.WriteLine(i);
            Console.WriteLine();
            for(int i=0;i<3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(twod[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
