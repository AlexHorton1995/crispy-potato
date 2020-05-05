using System;

namespace Chapter13
{
    /// <summary>
    /// Chapter 13:  Arrays (not "A Raise")
    /// Assignment:  Palindromes. Create an array of the following words:
    ///     Anna,Civic,Kayak,Level,Madam,Mom,Noon,Racecar,Radar,Redder,Refer,
    ///     Repaper,Rotator,Rotor,Sagas,Solos,Stats,Tenet,Wow
    /// and loop through the array that displays all of the palindromes.  Display the length of each
    /// word on the screen as well during runtime.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] palindromes = new string[] { "Anna", "Civic", "Kayak", "Level", "Madam", "Mom", "Noon", "Racecar", "Radar", "Redder", "Refer", "Repaper", "Rotator", "Rotor", "Sagas", "Solos", "Stats", "Tenet", "Wow" };


            foreach (var paliLengths in palindromes)
            {
                Console.WriteLine(paliLengths + " " + paliLengths.Length);
            }
            Console.ReadLine();



        }
    }
}
