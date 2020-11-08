using System;
using Xunit;

namespace TestShowcase
{
    public class UnitTests
    {
        [Fact]
        public void TestAdd()
        {
            //Arrange
            double expected = 5;

            //Act
            double actual = Calculator.Add(3, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSub()
        {
            //Arrange
            double expected = 3;

            //Act
            double actual = Calculator.Subtract(5, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMult()
        {
            //Arrange
            double expected = 6;

            //Act
            double actual = Calculator.Subtract(3, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDiv()
        {
            //Arrange
            double expected = 2.5;

            //Act
            double actual = Calculator.Divide(5, 2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
