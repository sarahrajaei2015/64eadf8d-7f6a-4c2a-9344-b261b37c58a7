namespace Code_Test.Helpers
{
	public class Utils
	{
		public static void UpdateLongestSubsequence(List<List<int>> subsequences, List<int> subsequence)
		{
			if (subsequence.Count > 1)
			{
				subsequences.Add(new List<int>(subsequence));
			}
		}

		public static bool IsValidSequenceNumber(int number, List<int> subsequence)
		{
			return subsequence.Count == 0 || number > subsequence.Last();
		}
	}
}
