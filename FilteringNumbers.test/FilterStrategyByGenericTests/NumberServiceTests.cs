using System;
using System.Collections.Generic;
using Xunit;
using FilteringNumbers.FilterStrategyByGeneric;


namespace FilteringNumbers.tests.FilterStrategyByGenericTests
{
    public class NumberServiceTests
    {
        [Fact]
        public void FilterObjects_IntGreaterThan10_ShouldReturnCorrectItems()
        {
            // Arrange
            var numbers = new List<int> { 5, 12, 8, 20 };

            // Act
            var result = NumberService.FilterObjects(numbers, FilterConditions.GreaterThan10);

            // Assert
            Assert.Equal(new List<int> { 12, 20 }, result);
        }

        [Fact]
        public void FilterObjects_DoubleGreaterThan10_ShouldReturnCorrectItems()
        {
            // Arrange
            var numbers = new List<double> { 5.5, 12.3, 8.1, 20.0 };

            // Act
            var result = NumberService.FilterObjects(numbers, FilterConditions.DoubleGreaterThan10);

            // Assert
            Assert.Equal(new List<double> { 12.3, 20.0 }, result);
        }

        [Fact]
        public void FilterObjects_AnyString_ShouldReturnAllStrings()
        {
            // Arrange
            var items = new List<string> { "abc", "hello", "x" };

            // Act
            var result = NumberService.FilterObjects(items, FilterConditions.AnyString);

            // Assert
            Assert.Equal(items, result);
        }

        [Fact]
        public void ReadItemsFromUserList_IntParser_ShouldReturnCorrectList()
        {
            // Arrange: Fake IO
            var fakeIO = new FakeConsoleUserIO(new[] { "3", "7", "done" });
            ConsoleUserIO.OverrideForTest(fakeIO);

            // Act
            var result = NumberService.ReadItemsFromUserList(FilterParsers.IntParser);

            // Assert
            Assert.Equal(new List<int> { 3, 7 }, result);
            Assert.Contains(Messages.EnterNumbers, fakeIO.outputs);
        }

        [Fact]
        public void ReadItemsFromUserList_DoubleParser_ShouldReturnCorrectList()
        {
            var fakeIO = new FakeConsoleUserIO(new[] { "3.5", "7.1", "done" });
            ConsoleUserIO.OverrideForTest(fakeIO);

            var result = NumberService.ReadItemsFromUserList(FilterParsers.DoubleParser);

            Assert.Equal(2, result.Count); // ابتدا تعداد عناصر
            Assert.Equal(3.5, result[0]);
            Assert.Equal(7.1, result[1]);
           // Assert.Equal(new List<double> { 3.5, 7.1 }, result);
        }

        [Fact]
        public void ReadItemsFromUserList_StringParser_ShouldReturnCorrectList()
        {
            var fakeIO = new FakeConsoleUserIO(new[] { "abc", "hello", "done" });
            ConsoleUserIO.OverrideForTest(fakeIO);

            var result = NumberService.ReadItemsFromUserList(FilterParsers.StringParser);

            Assert.Equal(new List<string> { "abc", "hello" }, result);
        }
    
       
       [Fact]
        public void PrintItems_ShouldWriteAllItems_Generic()
        {
            // Arrange
            var fakeIO = new FakeConsoleUserIO(new string[0]);
            ConsoleUserIO.OverrideForTest(fakeIO);

            var itemsInt = new List<int> { 4, 8 };
            var itemsDouble = new List<double> { 3.5, 7.1 };
            var itemsString = new List<string> { "abc", "hello" };

            // Act
            NumberService.PrintItems(itemsInt);
            NumberService.PrintItems(itemsDouble);
            NumberService.PrintItems(itemsString);

            // Assert
            Assert.Contains(Messages.Result, fakeIO.outputs);
            Assert.Contains("4", fakeIO.outputs);
            Assert.Contains("8", fakeIO.outputs);
            Assert.Contains("3.5", fakeIO.outputs);
            Assert.Contains("7.1", fakeIO.outputs);
            Assert.Contains("abc", fakeIO.outputs);
            Assert.Contains("hello", fakeIO.outputs);
        }

    }
}