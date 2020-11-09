using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzv2
    {
        public static void Main(String[] args)
        {
            //creates a new object of getNumber
            GetNumber getNumber = new GetNumber();

            //iterates over numbers 1-100
            foreach (var number in Enumerable.Range(1,100))
            {
                Console.WriteLine(getNumber.GetNewNumber(number));
            }
        }
    }
}
