namespace FizzBuzz
{
    public class Rules : IFizzBuzzProgram
    {
        //creates a variable to store outcome of operations in
        public string defaultMultiple = null;

        //creates variables for replacement words
        public static string multipleReplacement1 = "Fizz";
        public static string multipleReplacement2 = "Buzz";

        //creates variables for the multiples
        public static int multipleInt1 = 3;
        public static int multipleInt2 = 5;

        public string MultipleRules(int currentNumber)
        {
            var tempMultiple = defaultMultiple; 

            if ((currentNumber % multipleInt2 == 0) && (currentNumber % multipleInt1 == 0))
            {
                tempMultiple += multipleReplacement1 + multipleReplacement2;
            }
            else if (currentNumber % multipleInt1 == 0)
            {
                tempMultiple += multipleReplacement1;
            }
            else if (currentNumber % multipleInt2 == 0)
            {
                tempMultiple += multipleReplacement2;
            }
            //returns multiple if statement is hit or the actual number if not
            return tempMultiple ?? currentNumber.ToString();
        }

        public static void SetMultiple(string newWord1, string newWord2, int newInt1, int newInt2)
        {
            multipleReplacement1 = newWord1;
            multipleReplacement2 = newWord2;
            multipleInt1 = newInt1;
            multipleInt2 = newInt2;
        }
    }
}
