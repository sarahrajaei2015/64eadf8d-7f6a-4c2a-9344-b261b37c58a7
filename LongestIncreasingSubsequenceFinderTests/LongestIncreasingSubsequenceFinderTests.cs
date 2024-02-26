using Code_Test;
using Code_Test.Interfaces;

namespace LongestIncreasingSubsequenceFinderTests
{
	public class LongestIncreasingSubsequenceFinderTests
	{
		[Theory]
		[InlineData("6 1 5 9 2", "1 5 9")]
		[InlineData("6 2 4 3 1 5 9", "1 5 9")]
		[InlineData("6 2 4 6 1 5 9 2", "2 4 6")]
		public void FindLongestSubsequence_Returns_CorrectResult(string input, string expectedOutput)
		{
			// Arrange
			ISubsequenceFinder subsequenceFinder = new LongestIncreasingSubsequenceFinder(input);

			// Act
			List<int> result = subsequenceFinder.FindLongestSubsequence();

			// Assert
			string resultString = string.Join(" ", result);
			Assert.Equal(expectedOutput, resultString);
		}
	}
}