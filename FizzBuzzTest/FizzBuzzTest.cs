using Xunit;
using FizzBuzzProgram;

namespace JazzFuzzTest
{
    public class FizzBuzzTest
    {
        Rules number = new Rules();

        [Fact]
        public void TestOne()
        {
            //Arrange
            var expected = "1";

            //Act
            string actual = number.MultipleRules(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestThree()
        {
            //Arrange
            var expected = "Fizz";

            //Act
            string actual = number.MultipleRules(3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFour()
        {
            //Arrange
            var expected = "Jazz";

            //Act
            string actual = number.MultipleRules(4);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFive()
        {
            //Arrange
            var expected = "Buzz";

            //Act
            string actual = number.MultipleRules(5);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEight()
        {
            //Arrange
            var expected = "Quzz";

            //Act
            string actual = number.MultipleRules(8);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNine()
        {
            //Arrange
            var expected = "Fuzz";

            //Act
            string actual = number.MultipleRules(9);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}