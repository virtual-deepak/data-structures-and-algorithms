using CodingProblems;

//var output = SegregateEvenOdd.Execute(HelperFunctions.GetUserInputNumbers());
//HelperFunctions.PrintNumbers(output);

var first = HelperFunctions.GetUserInputNumbers();
var second = HelperFunctions.GetUserInputNumbers();
var output = MergeTwoSortedArrays.Execute(first, second);
HelperFunctions.PrintNumbers(output);