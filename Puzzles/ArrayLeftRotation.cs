using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzles
{
    class ArrayLeftRotation
    {

        // sample test cases for the problem
        readonly int[] testArray1 = { 1, 2, 3, 4, 5 };
        readonly int testInt1 = 4;
        readonly int[] testArray2 = { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
        readonly int testInt2 = 10;


        public int[] Solution(int[] a, int d)
        {

            int[] b = new int[a.Length];

            int place;
            int index;
            int len = a.Length;

            for (int i = 0; i < len; i++)
            {

                index = i - d;
                place = len + index;

                if (index >= 0)
                {
                    b[index] = a[i];
                }
                else
                {
                    b[place] = a[i];
                }

            }

            Console.WriteLine("Original Array: ");
            a.ToList().ForEach(k => Console.Write(k.ToString() + " "));
            Console.WriteLine();
            Console.WriteLine("New array, rotated by {0} left rotations",d);
            b.ToList().ForEach(j => Console.Write(j.ToString() + " "));
            Console.WriteLine();
            return b;
            

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
