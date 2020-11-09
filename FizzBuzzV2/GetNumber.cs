namespace FizzBuzz
{
    public class GetNumber : IFizzBuzz
    {
        public string GetNewNumber(int currentNumber)
        {
            //creates a variable to store outcome of operations in
            string multiple = null;

            if ((currentNumber % 5 == 0) && (currentNumber % 3 == 0))
            {
                multiple += "FizzBuzz";
            }
            else if (currentNumber % 3 == 0)
            {
                multiple += "Fizz";
            }
            else if (currentNumber % 5 == 0)
            {
                multiple += "Buzz";
            }
            //returns multiple if statement is hit or the actual number if not
            return multiple ?? currentNumber.ToString();
        }
    }
}
