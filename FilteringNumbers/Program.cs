using FilteringNumbers.FilterStrategyByEnumerable;


var numbers = NumberService.ReadNumbersFromUser();
var filter = new EvenAndGreaterThanTenFilter();
var filtered = numbers.FilterNumbers(filter);
filtered.PrintNumbers();