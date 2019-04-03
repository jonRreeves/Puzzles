using System;

namespace Puzzles
{
    // Solutions to puzzles found on HackerRank with valid sample inputs to pass test cases
    class Program
    {

        static void Main(string[] args)
        {
            int selection;

            FizzBuzz fb = new FizzBuzz();
            SockMerchant sm = new SockMerchant();
            CountingValleys cv = new CountingValleys();
            JumpingOnTheClouds jc = new JumpingOnTheClouds();
            RepeatedString rs = new RepeatedString();

            while (true)
            {

                Console.WriteLine("Please enter a puzzle to solve: 1.FizzBuzz | 2. SockMerchant | 3. CountingValleys | 4. JumpingOnTheClouds \n" +
                                  "                                5. RepeatedString");
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        fb.Solution();
                        break;
                    case 2:
                        int n = 9;
                        int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
                        sm.Solution(n, ar);
                        n = 10;
                        int[] ar2 = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
                        sm.Solution(n, ar2);                       
                        break;
                    case 3:
                        cv.Solution(8, "UDDDUDUU", 1);
                        cv.Solution(12, "DDUUDDUDUUUD", 2);                       
                        break;
                    case 4:
                        int[] ar3 = { 0, 0, 1, 0, 0, 1, 0 };
                        jc.Solution(ar3);
                        int[] ar4 = { 0, 0, 0, 1, 0, 0 };
                        jc.Solution(ar4);                       
                        break;
                    case 5:
                        rs.Solution("aba",10);
                        rs.Solution("a", 1000);                        
                        break;
                    default:
                        return;
                }
        }
        }
    }
}
