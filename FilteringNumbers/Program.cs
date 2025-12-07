using FilteringNumbers;
using FilteringNumbers;

var numbers = NumberService.ReadNumbersFromUser();
var filtered = NumberService.FilterNumbers(numbers);
NumberService.PrintNumbers(filtered);