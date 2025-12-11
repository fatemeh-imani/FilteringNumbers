using FilteringNumbers.FilterStrategyByobject;
using System;
using System.Collections.Generic;
using Xunit;


namespace FilteringNumbers.tests.FilterStrategyByobjectTests
{
    public class NumberServiceTests 
    {
        [Fact]
        public void FilterObjects_DefaultFilter_ShouldReturnOnlyNumbersGreaterThan10()
        {
            // Arrange
            var items = new List<object> { 5, 12, 8, 15, "hello", 13.5 };

            // Act
            var result = NumberService.FilterObjects(items, FilterConditions.DefaultFilter).ToList();

            // Assert
            var expected = new List<object> { 12, 15, "hello", 13.5 };
            Assert.Equal(expected.Count, result.Count); // ابتدا تعداد عناصر
            Assert.All(expected, item => Assert.Contains(item, result));
        }


        [Fact]
        public void ReadItemsFromUser_ShouldReturnNumbersCorrectly()
        {
            //ListNumber
            // Arrange: ورودی Fake و ذخیره خروجی
            var fakeIOList = new FakeConsoleUserIO(new[] { "3", "7", "done" });
            ConsoleUserIO.OverrideForTest(fakeIOList);

            //Act
            var numbersList = NumberService.ReadItemsFromUser();

            //assert
            Assert.Equal(new List<object> { 3, 7 }, numbersList);
            Assert.Contains(Messages.EnterItems, fakeIOList.outputs);


        }

        [Fact]
        public void PrintItems_ShouldWriteAllNumbers()
        {
            // Arrange
            var fakeIO = new FakeConsoleUserIO(new string[0]);
            ConsoleUserIO.OverrideForTest(fakeIO);

            var items = new List<object> { 4, 8 };

            // Act
            NumberService.PrintItems(items);

            // Assert
            Assert.Contains(Messages.Result, fakeIO.outputs);
            Assert.Contains("4", fakeIO.outputs);
            Assert.Contains("8", fakeIO.outputs);
        }
    }
}