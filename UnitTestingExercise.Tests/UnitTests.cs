using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calcInstance = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calcInstance.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 10, -5)]
        [InlineData(10, 5, 5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calcInstance = new Calculator();

            //Act
            var actual = calcInstance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 1, 5)]
        [InlineData(5, 5, 25)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calcInstance = new Calculator();

            //Act
            var actual = calcInstance.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calcInstance = new Calculator();

            //Act
            var actual = calcInstance.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
