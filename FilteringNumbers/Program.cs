using FilteringNumbers.FilterStrategyByEnumerable;


var numbers = NumberService.ReadNumbersFromUser();
var filter = new EvenAndGreaterThanTenFilter();
var filtered = NumberService.FilterNumbers(numbers,filter);
NumberService.PrintNumbers(filtered);