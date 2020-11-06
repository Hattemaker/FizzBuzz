using System;

namespace TaskOne
{
    public class TaskOne
    {
        static public void Main(String[] args)
        {
            FizzBuzz(100);
        }

        static void FizzBuzz(int max)
        {
            for (var i = 1; i <= max; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}
/**TODO**¨
 * Fungerer som den skal + teknisk kvalitet på koden
 * Navngivning
 * Organisering
 * SOLID-prinsipper
 * Moderne features
 * Testing (XUnit)
 * 
 * DEL 1
 *  -   Print tallene 1-100
 *  -   Erstatt tall som går opp i 3 med "Fizz"
 *  -   Erstatt tall som går opp i 5 med "Buzz"
 *  -   Dersom tallet går opp i både 3 og 5; erstatt eksisterende tall med "FizzBuzz"
 * 
 * */