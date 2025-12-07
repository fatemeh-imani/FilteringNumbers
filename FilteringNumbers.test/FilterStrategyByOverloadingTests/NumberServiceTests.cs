using FilteringNumbers.FilterStrategyByOverloading;
using System;
using System.Collections.Generic;
using Xunit;


namespace FilteringNumbers.tests.FilterStrategyByOverloadingTests
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
            //ListNumber
            // Arrange: ورودی Fake و ذخیره خروجی
            var fakeIOList = new FakeConsoleUserIO(new[] { "3", "7", "done" });
            ConsoleUserIO.OverrideForTest(fakeIOList);

            //Act
            var numbersList = NumberService.ReadNumbersFromUserList();

            //assert
            Assert.Equal(new List<int> { 3, 7 }, numbersList);
            Assert.Contains(Messages.EnterNumbers, fakeIOList.outputs);


            //arrayNumber
            var fakeIOArray = new FakeConsoleUserIO(new[] { "3", "7", "done" });
            ConsoleUserIO.OverrideForTest(fakeIOArray);
            // جایگزینی Fake با ConsoleUserIO

            // Act
            var numbersArray = NumberService.ReadNumbersFromUserArray();

            // Assert
            Assert.Equal(new int[] { 3, 7 }, numbersArray);
            Assert.Contains(Messages.EnterNumbers, fakeIOArray.outputs);
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