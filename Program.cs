// Entry point using top-level statements
using Code_Test.Interfaces;
using Code_Test;

// Read input from the file
string inputFilePath = Path.Combine("TestData", "TestCase4.txt");
string input = File.ReadAllText(inputFilePath);

// Use the LongestIncreasingSubsequenceFinder by default
ISubsequenceFinder subsequenceFinder = new LongestIncreasingSubsequenceFinder(input);
SubsequenceContext context = new SubsequenceContext(subsequenceFinder);

List<int> result = context.FindLongestSubsequence();

Console.WriteLine($"Longest Increasing Subsequence: {string.Join(" ", result)}");
