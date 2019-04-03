using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzles
{
    // problem definition @ https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    class _2dArray
    {
        // sample test cases for _2dArray
        readonly int[,] hourglassOne = {

                {1, 1, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0},
                {0, 0, 2, 4, 4, 0},
                {0, 0, 0, 2, 0, 0},
                {0, 0, 1, 2, 4, 0}
            };

        readonly int[,] hourglassTwo =
        {
                {1, 1, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0},
                {0, 9, 2,-4,-4, 0},
                {0, 0, 0,-2, 0, 0},
                {0, 0,-1,-2,-4, 0}
            };

        public void Solution(int[,] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Input array:");
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            int max = -999;
            int temp = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp = arr[i, j] + arr[i, j + 1] + arr[i, j + 2]
                                    + arr[i + 1, j + 1]
                        + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                    max = Math.Max(temp, max);
                }

            }

            Console.WriteLine("The highest valued hourglass shape is: " + max);
            Console.ReadKey();

        }

        public int[,] GetTest2dArray(int test)
        {
            if (test == 1)
            {
                return hourglassOne;
            }
            else
            {
                return hourglassTwo;
            }
        }
      

    }
}
