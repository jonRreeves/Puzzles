using System;

namespace Puzzles
{
    // Solutions to puzzles found on HackerRank with valid sample inputs to pass test cases
    class Program
    {

        static void Main(string[] args)
        {
            // switch selector
            int selection;

            // instantiate problems
            FizzBuzz fb = new FizzBuzz();
            SockMerchant sm = new SockMerchant();
            CountingValleys cv = new CountingValleys();
            JumpingOnTheClouds jc = new JumpingOnTheClouds();
            RepeatedString rs = new RepeatedString();
            _2dArray a2d = new _2dArray();
            ArrayLeftRotation alr = new ArrayLeftRotation();

            while (true)
            {

                Console.WriteLine("Please enter a puzzle to solve: 1.FizzBuzz | 2. SockMerchant | 3. CountingValleys | 4. JumpingOnTheClouds \n" +
                                  "                                5. RepeatedString | 6. 2dArrayHourglass | 7. Arrays: Left Rotation");
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        fb.Solution();
                        Console.WriteLine();
                        break;
                    case 2:
                        sm.Solution(sm.GetTestInt(1), sm.GetTestArray(1));
                        sm.Solution(sm.GetTestInt(2), sm.GetTestArray(2));
                        Console.WriteLine();
                        break;
                    case 3:
                        cv.Solution(cv.GetTestInt(1),cv.GetTestString(1), 1);
                        cv.Solution(cv.GetTestInt(2),cv.GetTestString(2), 2);
                        Console.WriteLine();
                        break;
                    case 4:                        
                        jc.Solution(jc.GetTestArray(1));                        
                        jc.Solution(jc.GetTestArray(2));
                        Console.WriteLine();
                        break;
                    case 5:
                        rs.Solution(rs.GetTestString(1),rs.GetTestInt(1));
                        rs.Solution(rs.GetTestString(2),rs.GetTestInt(2));
                        Console.WriteLine();
                        break;
                    case 6:
                        a2d.Solution(a2d.GetTest2dArray(1));
                        a2d.Solution(a2d.GetTest2dArray(2));
                        Console.WriteLine();
                        break;
                    case 7:
                        alr.Solution(alr.GetTestArray(1), alr.GetTestInt(1));
                        Console.ReadLine();
                        alr.Solution(alr.GetTestArray(2), alr.GetTestInt(2));
                        Console.WriteLine();
                        break;
                    default:
                        return;
                }
        }
        }
    }
}
