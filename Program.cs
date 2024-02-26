// Entry point using top-level statements
using Code_Test.Interfaces;
using Code_Test;


var input = args.Length > 0 ? args[0] : GetUserInput();

ISubsequenceFinder subsequenceFinder = GetSubsequenceFinder(input);

List<int> result = subsequenceFinder.FindLongestSubsequence();
Console.WriteLine($"Longest Increasing Subsequence: {string.Join(" ", result)}");


string GetUserInput()
{
	Console.WriteLine("Please enter either:");
	Console.WriteLine("1. A sequence of numbers separated by spaces (e.g., '1 2 3 4')");
	Console.WriteLine("2. A file name containing the sequence of numbers");

	Console.Write("Your input: ");
	return Console.ReadLine();
}

ISubsequenceFinder GetSubsequenceFinder(string input)
{
	string inpurFilePath = Path.Combine("TestData", input);
	if (File.Exists(inpurFilePath))
	{
		string fileContent = File.ReadAllText(inpurFilePath);
		return new LongestIncreasingSubsequenceFinder(fileContent);
	}
	else
	{
		return new LongestIncreasingSubsequenceFinder(input);
	}
}