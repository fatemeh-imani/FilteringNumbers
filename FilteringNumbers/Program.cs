using FilteringNumbers.FilterStrategyByGeneric;
using FilteringNumbers.FilterStrategyByobject;

// --- Object ---
Console.WriteLine(" enter items to filtering Items By Object Method: ");
var items = FilteringNumbers.FilterStrategyByobject.NumberService.ReadItemsFromUser();
var filteredObject = FilteringNumbers.FilterStrategyByobject.NumberService.FilterObjects
    (items, FilteringNumbers.FilterStrategyByobject.FilterConditions.DefaultFilter);
FilteringNumbers.FilterStrategyByobject.NumberService.PrintItems(filteredObject);

// --- Generic ---

Console.WriteLine(" enter items to filtering integer Items By Generic Methods:");
var numbersInt = FilteringNumbers.FilterStrategyByGeneric.NumberService.ReadItemsFromUserList(FilterParsers.IntParser);
var filteredGenericInt = FilteringNumbers.FilterStrategyByGeneric.NumberService.FilterObjects
    (numbersInt, FilteringNumbers.FilterStrategyByGeneric.FilterConditions.GreaterThan10);
FilteringNumbers.FilterStrategyByGeneric.NumberService.PrintItems(filteredGenericInt);

Console.WriteLine(" enter items to filtering Double Items By Generic Methods:");
var numbersDouble = FilteringNumbers.FilterStrategyByGeneric.NumberService.ReadItemsFromUserList(FilterParsers.DoubleParser);
var filteredGenericDouble = FilteringNumbers.FilterStrategyByGeneric.NumberService.FilterObjects
    (numbersDouble, FilteringNumbers.FilterStrategyByGeneric.FilterConditions.DoubleGreaterThan10);
FilteringNumbers.FilterStrategyByGeneric.NumberService.PrintItems(filteredGenericDouble);

Console.WriteLine(" enter items to filtering Strings Items By Generic Methods:");
var numbersString = FilteringNumbers.FilterStrategyByGeneric.NumberService.ReadItemsFromUserList(FilterParsers.StringParser);
var filteredGenericString = FilteringNumbers.FilterStrategyByGeneric.NumberService.FilterObjects
    (numbersString, FilteringNumbers.FilterStrategyByGeneric.FilterConditions.AnyString);
FilteringNumbers.FilterStrategyByGeneric.NumberService.PrintItems(filteredGenericString);
