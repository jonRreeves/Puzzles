using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzles
{

    // problem definition @ https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    class JumpingOnTheClouds
    {

        // sample test cases for JumpingOnTheClouds
        readonly int[] jcArr1 = { 0, 0, 1, 0, 0, 1, 0 };
        readonly int[] jcArr2 = { 0, 0, 0, 1, 0, 0 };

        public void Solution(int[] c)
        {
            Console.Write("Input Array contents: ");
            c.ToList().ForEach(j => Console.Write(j.ToString() + " "));

            int jumpCount = 0;
            int i = 0;

            while (i < c.Length - 1)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i = i + 2;
                    jumpCount++;
                }
                else
                {
                    i++;
                    jumpCount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The minimum number of jumps is: " +  jumpCount);
            Console.ReadKey();           
        }

        public int[] GetTestArray(int test)
        {
            if (test == 1)
            {
                return jcArr1;
            }
            else
            {
                return jcArr2;
            }
            
        }

    }
}
