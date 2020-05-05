using System;

namespace Chapter14
{
    /// <summary>
    /// Chapter 14:  Enumerators
    /// Assignment:  Complete the Try it Out assignment on page 89.
    /// </summary>
    class Program
    {
        enum MonthsofYear
        {
            January = 1, February = 2, March = 3, April = 4, May = 5, June = 6,
            July = 7, August = 8, September = 9, October = 10, November = 11, December = 12
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Put a number between 1 and 12: ");
            string givenNumber = Console.ReadLine();
            var givenNum = Convert.ToInt32(givenNumber);

            switch (givenNum)
            {
                case 1:
                    if (givenNum == Convert.ToInt32(MonthsofYear.January))
                    {

                        Console.WriteLine("Your month is " + "January");
                    }
                    break;
                case 2:
                    if (givenNum == Convert.ToInt32(MonthsofYear.February))
                    {
                        Console.WriteLine("Your month is " + "February");
                    }
                    break;
                case 3:
                    if (givenNum == Convert.ToInt32(MonthsofYear.March))
                    {
                        Console.WriteLine("Your month is " + "March");
                    }
                    break;
                case 4:
                    if (givenNum == Convert.ToInt32(MonthsofYear.April))
                    {
                        Console.WriteLine("Your month is " + "April");
                    }
                    break;
                case 5:
                    if (givenNum == Convert.ToInt32(MonthsofYear.May))
                    {
                        Console.WriteLine("Your month is " + "May");
                    }
                    break;
                case 6:
                    if (givenNum == Convert.ToInt32(MonthsofYear.June))
                    {
                        Console.WriteLine("Your month is " + "June");
                    }
                    break;
                case 7:
                    if (givenNum == Convert.ToInt32(MonthsofYear.July))
                    {
                        Console.WriteLine("Your month is " + "July");
                    }
                    break;
                case 8:
                    if (givenNum == Convert.ToInt32(MonthsofYear.August))
                    {
                        Console.WriteLine("Your month is " + "August");
                    }
                    break;
                case 9:

                    if (givenNum == Convert.ToInt32(MonthsofYear.September))
                    {
                        Console.WriteLine("Your month is " + "September");
                    }
                    break;
                case 10:
                    if (givenNum == Convert.ToInt32(MonthsofYear.October))
                    {
                        Console.WriteLine("Your month is " + "October");
                    }
                    break;
                case 11:
                    if (givenNum == Convert.ToInt32(MonthsofYear.November))
                    {
                        Console.WriteLine("Your month is " + "November");
                    }
                    break;
                case 12:
                    if (givenNum == Convert.ToInt32(MonthsofYear.December))
                    {
                        Console.WriteLine("Your month is " + "December");
                    }
                    break;
                default:
                    Console.WriteLine("A number...please!");
                    break;
            }
            Console.ReadLine();



        }
    }
}
