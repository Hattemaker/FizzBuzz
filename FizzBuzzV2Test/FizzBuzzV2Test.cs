using Xunit;
using FizzBuzz;

namespace JazzFuzzV2Test
{
    public class FizzBuzzV2Test
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
        public void TestFive()
        {
            //Arrange
            var expected = "Buzz";

            //Act
            string actual = number.MultipleRules(5);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
