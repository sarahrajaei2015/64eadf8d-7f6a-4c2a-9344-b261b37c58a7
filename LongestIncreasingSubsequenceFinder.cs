using Code_Test.Helpers;
using Code_Test.Interfaces;

namespace Code_Test
{
	// Concrete strategy for finding the longest increasing subsequence
	public class LongestIncreasingSubsequenceFinder : ISubsequenceFinder
	{
		private readonly List<int> numbers;
		public LongestIncreasingSubsequenceFinder(string input)
		{
			numbers = input.Split(' ').Select(int.Parse).ToList();
		}
		public List<int> FindLongestSubsequence()
		{
			List<List<int>> subsequences = new List<List<int>>();
			List<int> currentSubsequence = new List<int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				// If the current number is greater than the previous one or if the current subsequence is empty, 
				if (Utils.IsValidSequenceNumber(numbers[i], currentSubsequence))
				{
					currentSubsequence.Add(numbers[i]);
				}
				else
				{
					Utils.UpdateLongestSubsequence(subsequences, currentSubsequence);
					currentSubsequence.Clear();
					currentSubsequence.Add(numbers[i]);
				}
			}

			Utils.UpdateLongestSubsequence(subsequences, currentSubsequence);

			//returns the first(longest) subsequence from the sorted list, or an empty list if no valid subsequences are found.
			return subsequences.OrderByDescending(s => s.Count).FirstOrDefault() ?? new List<int>();
		}

	}
}
