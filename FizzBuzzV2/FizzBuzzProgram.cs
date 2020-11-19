using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzProgram
    {
        public static IEnumerable<int> list = Enumerable.Range(1, 100);
        public static IEnumerable<int> reversedList = list.Reverse();

        public static void Main(String[] args)
        {
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
