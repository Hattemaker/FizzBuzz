using Xunit;
using FizzBuzzV2;

namespace FizzBuzzTest
{
    public class FizzBuzzUnitTest
    {
        private IFizzBuzz fizzBuzzInterface;

        [Fact]
        public void TestOne()
        {
            //Arrange
            string expected = "1";

            //Act
            string actual = getNumber.GetNewNumber(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestThree()
        {
            //Arrange
            string expected = "Fizz";

            //Act
            string actual = getNumber.GetNewNumber(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFive()
        {
            //Arrange
            string expected = "Buzz";

            //Act
            string actual = getNumber.GetNewNumber(5);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
