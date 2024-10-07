using CodingProblems;

//var output = SegregateEvenOdd.Execute(HelperFunctions.GetUserInputNumbers());
//HelperFunctions.PrintOutput(output);

// var first = HelperFunctions.GetUserInputNumbers();
// var second = HelperFunctions.GetUserInputNumbers();
// var output = MergeTwoSortedArrays.Execute(first, second);
// HelperFunctions.PrintOutput(output);

// var output = DutchNationalFlag.Execute(HelperFunctions.GetUserInputCharacters());
// HelperFunctions.PrintOutput(output);

var inputData = HelperFunctions.GetInputTwoSumInSortedArray();
var output = TwoSumInSortedArrays.Execute(inputData.inputArray, inputData.target);
HelperFunctions.PrintOutput(output);
