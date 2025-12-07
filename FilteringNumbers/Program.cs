using FilteringNumbers.FilterStrategyByEnumerable;


var numbers = NumberService.ReadNumbersFromUser();
var filtered = NumberService.FilterNumbers(numbers,EvenAndGreaterThanTenFilter.IsMatch);
NumberService.PrintNumbers(filtered);