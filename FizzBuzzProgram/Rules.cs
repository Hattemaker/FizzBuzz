using System.Collections.Generic;

namespace FizzBuzzProgram
{
    public class Rules : IFizzBuzzGame
    {
        //dictionary of rules
        public static Dictionary<int, string> rule = new Dictionary<int, string>();

        //add method for dictionary
        public static void Add(int multiplier, string word)
        {
            rule.Add(multiplier, word);
        }

        //clear method for dictionary
        public static void Clear()
        {
            rule.Clear();
        }

        //creates a variable to store outcome of operations in
        private string defaultMultiple = null;

        public string MultipleRules(int currentNumber)
        {
            var tempMultiple = defaultMultiple;

            foreach (KeyValuePair<int, string> kvp in rule)
            {
                if (currentNumber % kvp.Key == 0)
                {
                    tempMultiple += kvp.Value;
                }
            }
            return tempMultiple ?? currentNumber.ToString();
        }
    }
}