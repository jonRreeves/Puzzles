using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzles
{
    // problem definition @ https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    class RepeatedString
    {
        // sample test cases for the problem
        readonly string testString1 = "aba";
        readonly string testString2 = "a";
        readonly int testInt1 = 10;
        readonly int testInt2 = 1000;

        public void Solution(string s, long n)
        {
            Console.Write("Input string: " + s);
            Console.WriteLine(" | Number of repeitions: " + n);
            Console.Write("New string: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(s);
            }

            double r = 0;

            foreach (char c in s)
            {
                if (c == 'a')
                {
                    r++;
                }
            }

            r = (r * (n / s.Length));

            for (int j = 0; j < n % s.Length; j++)
            {
                if (s[j] == 'a')
                {
                    r++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Number of letter \"a\" in the first {0} letters of the string: {1} ", n, r);
            Console.ReadKey();

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

    }
}
