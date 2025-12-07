using FilteringNumbers;
using EnumerableService = FilteringNumbers.FilterStrategyByEnumerable.NumberService;
using OverloadingService = FilteringNumbers.FilterStrategyByOverloading.NumberService;


var numbersEnumerable = EnumerableService.ReadNumbersFromUser();
var filteredEnumerable = EnumerableService.FilterNumbers(numbersEnumerable);
EnumerableService.PrintNumbers(filteredEnumerable);


var numbersOverloadingList = OverloadingService.ReadNumbersFromUserList();
var filteredOverloadingList = OverloadingService.FilterNumbers(numbersOverloadingList);
OverloadingService.PrintNumbers(filteredOverloadingList);


var numbersOverloadingArray = OverloadingService.ReadNumbersFromUserArray();
var filteredOverloadingArray = OverloadingService.FilterNumbers(numbersOverloadingArray);
OverloadingService.PrintNumbers(filteredOverloadingArray);