using System;

namespace TaskOne
{
    public class TaskOne
    {
        public static void Main()
        {
            FizzBuzz(1, 100);
        }

        static void FizzBuzz(int min, int max)
        {
            for (var i = min; i <= max; i++)
            {
                //set the multiple rules for this program
                var x = (i % 3 == 0) && (i % 5 == 0);
                var y = i % 3 == 0;
                var z = i % 5 == 0;

                //checks and replaces if conditions are met
                if (x) Console.WriteLine("FizzBuzz");
                else if (y) Console.WriteLine("Fizz");
                else if (z) Console.WriteLine("Buzz");
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
 * */