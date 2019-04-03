using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzles
{
    /* Write a short program that prints each number from 1 to 100 on a new line. 
       For each multiple of 3, print "Fizz" instead of the number. 
       For each multiple of 5, print "Buzz" instead of the number. 
       For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
    */

    class FizzBuzz
    {

        public void Solution()
        {
            Console.WriteLine("Solution for FizzBuzz");

            for(int i=1; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 != 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            // read line to see output
            Console.ReadKey();
        }


    }
}
