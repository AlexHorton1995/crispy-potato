using System;
using System.Data;

namespace Chapter17
{
    /// <summary>
    /// OBJECT ORIENTED PROGRAMMING
    /// It is IMPORTANT you understand this chapter as Part 3 is foundational for C#
    /// Chapter 14:  Classes and Objects
    /// Complete the Try it Out on page 116.  Do more than the minimum lines of code.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Type in number of dice to roll.
            string respon;
            bool EorQ = true;
            int randomNumber = 0;

            while (EorQ)
            {
                Console.WriteLine("How many number of dice would you like to roll: ");
                string diceNum = Console.ReadLine();

                if(!Int32.TryParse(diceNum, out int diceWanted))
                {
                    Console.WriteLine("Input was not a number!");
                    continue;
                }
                //2.  Create new random object.
                Random random = new Random();
                for (int i = 0; i < diceWanted; i++)
                {
                    randomNumber += random.Next(6) + 1;
                }

                Console.WriteLine("Would you like to exit, quit, or continue?");
                respon = Console.ReadLine().ToUpper();

                if (respon == "EXIT" || respon == "QUIT")
                {
                    EorQ = false;
                }
                Console.WriteLine(randomNumber);
            }


            Console.ReadLine();
        }
    }
}
