using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(10, 10, 10, 30)]
        [InlineData(20, 30, 50, 100)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var add = new UnitTestMethods();
            //Act
            var actual = add.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 9, 11)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subtract = new UnitTestMethods();
            //Act
            var actual = subtract.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(10, 11, 110)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiply = new UnitTestMethods();
            //Act
            var actual = multiply.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(200, 10, 20)]
        [InlineData(100, 33, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new UnitTestMethods();
            //Act
            var actual = divide.Divide(num1 , num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Name()
        {
            //Arrange
            var expected = "Anton Kemuro";
            var name = new UnitTestMethods();
            //Act
            var actual = name.Name();
            //Assert
            Assert.Equal("Anton Kemuro", actual);
        }

        [Fact]
        public void FirstFivePrimeNumbers()
        {
            //Arrange
            var expected = 11;
            var primeNumber = new UnitTestMethods();
            //Act
            var actual = primeNumber.FirstFivePrimeNumbers();
            //Assert
            Assert.Equal( 11, actual);
        }
    }
}
