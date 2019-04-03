using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzles
{

    // problem definition @ https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    class CountingValleys
    {
        // sample test cases for the problem
        readonly int testInt1 = 8;
        readonly int testInt2 = 12;
        readonly string testString1 = "UDDDUDUU";
        readonly string testString2 = "DDUUDDUDUUUD";

        public void Solution(int n, string s, int drawnPath)
        {
            int count = 0;
            int seaLevel = 0;
            bool isValley = false;

            Console.WriteLine("Inputs | Number of steps: {0} | Path: {1}",n,s);

            if (drawnPath == 1)
            {
                Console.WriteLine("Drawn Path:");
                Console.WriteLine("_/\\      _");
                Console.WriteLine("   \\    /");
                Console.WriteLine("    \\/\\/");
            }

            if(drawnPath == 2)
            {
                Console.WriteLine("Drawn Path:");
                Console.WriteLine("_    _      _/\\_");
                Console.WriteLine(" \\  / \\    /");
                Console.WriteLine("  \\/   \\/\\/");
            }

                for (int i = 0; i < n; i++)
                {
                
                if (s[i] == 'U')
                {
                    seaLevel++;                  
                }
                else
                {
                    seaLevel--;                             
                }

                if (!isValley && seaLevel < 0)
                {
                    isValley = true;
                }
                if (isValley && seaLevel == 0)
                {
                    isValley = false;
                    count++;
                }

            }
            Console.WriteLine("Number of valleys walked through: {0}", count);
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

        public string GetTestString(int test)
        {
            if (test == 1)
            {
                return testString1;
            }
            else
            {
                return testString2;
            }
        }

    }
}
