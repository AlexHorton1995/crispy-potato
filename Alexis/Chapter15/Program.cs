using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace Chapter15
{
    /// <summary>
    /// Chapter 15:  Methods
    /// NOTE:  THIS CHAPTER IS EXTREMELY IMPORTANT TO UNDERSTAND!
    /// 
    /// Assignment:  Create the following three methods to manipulate an array (see page 97)
    ///     GenerateNumbers()
    ///     PrintNumbers()
    ///     Reverse()
    /// 
    /// Create a method and call it Fibonacci() (see page 101).
    /// 
    /// </summary>
    class Program
    {
        enum fibSeq 
        { fib1 = 1, fib2 = 1, fib3 = 2, fib4 = 3, fib5 = 5, 
          fib6 = 8, fib7 = 13, fib8 = 21, fib9 = 34, fib10 = 55};
        static void Main(string[] args)
        {
            /*
            var gNumbers = GenerateNumbers(3);
            Reverse(gNumbers);
            PrintNumbers(gNumbers);
            
            Console.ReadLine();
            */


        }
        /*
        static int[] GenerateNumbers(byte num)
        {
            List<int> retArray2 = new List<int>() 
            {
                45, 87, 6, 96, 2, 62, 30, 48, 7, 1
            };

            return retArray2.GetRange(0, num).ToArray();


        }

        static void PrintNumbers(int[] nums)
        {
            string prtStr = string.Empty;
            foreach (var num in nums)
            {
                prtStr += num.ToString() + ", ";
            }
            Console.WriteLine(@"Numbers from Array: " + prtStr.Remove(prtStr.Length - 2, 2));

        }

        static void Reverse(int[] nums)
        {
            string prtStr = string.Empty;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                prtStr += nums[i].ToString() + ", ";
            }
            Console.WriteLine(@"Reversed numbers in array: " + prtStr.Remove(prtStr.Length - 2, 2));
        }
        */

        static void Fibonacci()
        {
            switch (fibSeq)
            {
                case 1:
                    break;
                case fib2:
                    break;
                case fibSeq.fib3:
                    break;
                case fibSeq.fib4:
                    break;
                case fibSeq.fib5:
                    break;
                case fibSeq.fib6:
                    break;
                case fibSeq.fib7:
                    break;
                case fibSeq.fib8:
                    break;
                case fibSeq.fib9:
                    break;
                case fibSeq.fib10:
                    break;
                default:
                    break;
            }
        }











    }


}
