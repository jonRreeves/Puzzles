using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzles
{

    // problem definition @ https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

    class SockMerchant
    {
        // sample test cases for SockMerchant
        readonly int testInt1 = 9;
        readonly int[] testArray1 = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

        readonly int testInt2 = 10;
        readonly int[] testArray2 = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

        public void Solution(int n, int[] ar)
        {
            var count = 0;
            var hash = new HashSet<int>();

            Console.WriteLine("Size of array  = {0}",n);
            ar.ToList().ForEach(i => Console.Write(i.ToString() + " "));

            foreach (int a in ar)
            {
                if (!hash.Add(a))
                {
                    count++;
                    hash.Remove(a);
                }
            }
            Console.WriteLine("There are {0} pairs of socks",count);
            Console.ReadKey();
            
        }

        public int GetTestInt(int test)
        {
            if (test == 1)
            {
                return testInt1;
            }
            else
            {
                return testInt2;
            }
            
        }

        public int[] GetTestArray(int test)
        {
            if (test == 1)
            {
                return testArray1;
            }
            else
            {
                return testArray2;
            }
        }



    }
}
