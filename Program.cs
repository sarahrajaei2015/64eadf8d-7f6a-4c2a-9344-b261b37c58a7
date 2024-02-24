// Entry point using top-level statements
using Code_Test.Interfaces;
using Code_Test;

// Read input from the file
string inputFilePath = Path.Combine("TestData", "TestCase11.txt");
string input = File.ReadAllText(inputFilePath);

// Use the LongestIncreasingSubsequenceFinder by default
ISubsequenceFinder subsequenceFinder = new LongestIncreasingSubsequenceFinder();
SubsequenceContext context = new SubsequenceContext(subsequenceFinder);

List<int> result = context.FindLongestSubsequence(input);

Console.WriteLine($"Longest Increasing Subsequence: {string.Join(" ", result)}");
