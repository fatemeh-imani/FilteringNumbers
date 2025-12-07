using System;
using System.Collections.Generic;
using Xunit;
using NumbersFilterApp;


namespace NumbersFilterApp.tests
{
    public class NumberServiceTests 
    {
        [Fact]
        public void FilterNumbers_ShouldReturnOnlyNumbersGreaterThanFive()
        {
            //Arrange
             var numbers = new List<int> { 2,5,6,10,3 };

            //Act
            var result = NumberService.FilterNumbers(numbers);

            //Assert
            Assert.Equal(new List<int> { 6, 10 }, result);

        }
       

        [Fact]
        public void ReadNumbersFromUser_ShouldReturnNumbersCorrectly()
        {
            // Arrange: ورودی Fake و ذخیره خروجی
            var fakeIO = new FakeConsoleUserIO(new[] { "3", "7", "done" });
            ConsoleUserIO.OverrideForTest(fakeIO); // جایگزینی Fake با ConsoleUserIO

            // Act
            var numbers = NumberService.ReadNumbersFromUser();

            // Assert
            Assert.Equal(new List<int> { 3, 7 }, numbers);
            Assert.Contains(Messages.EnterNumbers, fakeIO.outputs);
        }

        [Fact]
        public void PrintNumbers_ShouldWriteAllNumbers()
        {
            // Arrange
            var fakeIO = new FakeConsoleUserIO(new string[0]);
            ConsoleUserIO.OverrideForTest(fakeIO);

            var numbers = new List<int> { 4, 8 };

            // Act
            NumberService.PrintNumbers(numbers);

            // Assert
            Assert.Contains(Messages.Result, fakeIO.outputs);
            Assert.Contains("4", fakeIO.outputs);
            Assert.Contains("8", fakeIO.outputs);
        }
    }
}