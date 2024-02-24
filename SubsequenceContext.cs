using Code_Test.Interfaces;

namespace Code_Test
{
    // Context class that uses the strategy to find subsequences
    public class SubsequenceContext
    {
        private ISubsequenceFinder _subsequenceFinder;
        public SubsequenceContext(ISubsequenceFinder subsequenceFinder)
        {
            _subsequenceFinder = subsequenceFinder;
        }

        // Change the strategy dynamically
        public void SetSubsequenceFinder(ISubsequenceFinder subsequenceFinder)
        {
            _subsequenceFinder = subsequenceFinder;
        }

        // Find the longest subsequence in the given input
        public List<int> FindLongestSubsequence(string input)
        {
            List<int> sequence = ParseInput(input);
            return _subsequenceFinder.FindSubsequence(sequence);
        }

        // Parse input string into a list of integers
        private List<int> ParseInput(string input)
        {
            return input.Split(' ').Select(int.Parse).ToList();
        }
    }
}
