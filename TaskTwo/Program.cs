using System;

namespace TaskTwo
{
    public class TaskTwo
    {
        static public void Main(String[] args)
        {
            FizzBuzz(100);
            JazzFuzz(1);
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

        static void JazzFuzz(int min)
        {
            for (var i = 100; i >= min; i--)
            {
                if ((i % 9 == 0) && (i % 4 == 0)) Console.WriteLine("JazzFuzz");
                else if (i % 9 == 0) Console.WriteLine("Jazz");
                else if (i % 4 == 0) Console.WriteLine("Fuzz");
                else Console.WriteLine(i);
            }
        }
    }
}