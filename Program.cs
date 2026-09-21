using K_Mart_LongestIncreasingSubsequence.Services;
using System;

partial  class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }

        var result = SequenceSolver.FindLongestIncreasingSubsequence(input);
        Console.WriteLine("Longest Increasing Subsequence:");
        Console.WriteLine(string.Join(" ", result));
    }
}
