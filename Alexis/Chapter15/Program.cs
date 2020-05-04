using System;
using System.Collections.Generic;
using System.Linq;

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
        static void Main(string[] args)
        {
            var gNumbers = GenerateNumbers(3);
            Reverse(gNumbers);
            PrintNumbers(gNumbers);
            
            Console.ReadLine();
        }

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
    }
}
