using Xunit;
using FizzBuzz;

namespace FizzBuzzV2Test
{
    public class FizzBuzzV2Test
    {
        GetNumber number = new GetNumber();

        [Fact]
        public void TestOne()
        {
            //Arrange
            var expected = "1";

            //Act
            string actual = number.GetNewNumber(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestThree()
        {
            //Arrange
            var expected = "Fizz";

            //Act
            string actual = number.GetNewNumber(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFive()
        {
            //Arrange
            var expected = "Buzz";

            //Act
            string actual = number.GetNewNumber(5);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
