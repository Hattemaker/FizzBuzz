using System;

namespace TaskTwo
{
    public class TaskTwo
    {
        public static void Main()
        {
            FizzBuzz(1, 100);
            JazzFuzz(100, 1);
        }

        static void FizzBuzz(int min, int max)
        {
            //loops from min to max
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

        static void JazzFuzz(int max, int min)
        {
            //loops from max to min
            for (var i = max; i >= min; i--)
            {
                //set the multiple rules for this program
                var x = (i % 4 == 0) && (i % 9 == 0);
                var y = i % 9 == 0;
                var z = i % 4 == 0;

                //checks and replaces if conditions are met
                if (x) Console.WriteLine("JazzFuzz");
                else if (y) Console.WriteLine("Jazz");
                else if (z) Console.WriteLine("Fuzz");
                else Console.WriteLine(i);
            }
        }
    }
}