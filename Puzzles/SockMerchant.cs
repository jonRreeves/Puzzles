using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzles
{

    // problem definition @ https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

    class SockMerchant
    {
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
    }
}
