using FilteringNumbers.FilterStrategyByGeneric;
using FilteringNumbers.FilterStrategyByobject;

// --- Object ---
Console.WriteLine(" enter items to filtering Items By Object Method: ");
var items = FilteringNumbers.FilterStrategyByobject.NumberService.ReadItemsFromUser();
var filteredObject = items.FilterObjects(FilteringNumbers.FilterStrategyByobject.FilterConditions.DefaultFilter);
filteredObject.PrintItems();

// --- Generic ---

Console.WriteLine(" enter items to filtering integer Items By Generic Methods:");
var numbersInt = FilteringNumbers.FilterStrategyByGeneric.NumberService.ReadItemsFromUserList(FilterParsers.IntParser);
var filteredGenericInt = numbersInt.FilterObjects(FilteringNumbers.FilterStrategyByGeneric.FilterConditions.GreaterThan10);
filteredGenericInt.PrintItems();

Console.WriteLine(" enter items to filtering Double Items By Generic Methods:");
var numbersDouble = FilteringNumbers.FilterStrategyByGeneric.NumberService.ReadItemsFromUserList(FilterParsers.DoubleParser);
var filteredGenericDouble = numbersDouble.FilterObjects(FilteringNumbers.FilterStrategyByGeneric.FilterConditions.DoubleGreaterThan10);
filteredGenericDouble.PrintItems();

Console.WriteLine(" enter items to filtering Strings Items By Generic Methods:");
var numbersString = FilteringNumbers.FilterStrategyByGeneric.NumberService.ReadItemsFromUserList(FilterParsers.StringParser);
var filteredGenericString = numbersString.FilterObjects(FilteringNumbers.FilterStrategyByGeneric.FilterConditions.AnyString);
filteredGenericString.PrintItems();
