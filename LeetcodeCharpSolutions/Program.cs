// See https://aka.ms/new-console-template for more information
using LeetcodeCharpSolutions.Array.Problem001;

Console.WriteLine("Hello, World!");
int[] numberstest = new int[] { 2, 7, 11, 15 };
int target = 9;

Problem001 problem001 = new Problem001();

var item = problem001.TwoSumTwoPointerTech(numberstest, target);
foreach (int i in item)
{
    Console.WriteLine(i);   
}