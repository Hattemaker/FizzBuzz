using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzProgram
{
    public class FizzBuzzGame
    {
        public static IEnumerable<int> list = Enumerable.Range(1, 100);
        public static IEnumerable<int> reversedList = list.Reverse();

        public static void Main(String[] args)
        {
            //FizzBuzz
            Rules.Add(3, "Fizz");
            Rules.Add(5, "Buzz");
            RunGame(list);
            
            //JazzFuzz
            Rules.Clear();
            Rules.Add(4, "Jazz");
            Rules.Add(9, "Fuzz");
            RunGame(reversedList);

            //Quzz
            Rules.Clear();
            Rules.Add(8, "Quzz");
            RunGame(list);
        }

        public static void RunGame(IEnumerable<int> list)
        {
            //creates a new object of Rules
            var checkRules = new Rules();

            //iterates over numbers in list
            foreach (var number in list)
            {
                Console.WriteLine(checkRules.MultipleRules(number));
            }
        }
    }
}
