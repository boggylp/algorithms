// See https://aka.ms/new-console-template for more information
using AlgoPractice.Arrays;

Console.WriteLine("Hello, Algo!");

var result = RemoveDuplicatesFromSorted.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
//var result = RemoveDuplicatesFromSorted.RemoveDuplicates(new int[] { 1, 2 });
Console.WriteLine($"{nameof(RemoveDuplicatesFromSorted)} result: {result}");

var maxProfit = BestTimeToBuyAndSellStock.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
//var result = RemoveDuplicatesFromSorted.RemoveDuplicates(new int[] { 1, 2 });
Console.WriteLine($"{nameof(BestTimeToBuyAndSellStock)} max profit: {maxProfit}");