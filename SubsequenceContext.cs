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

        // Find the longest subsequence in the given input
        public List<int> FindLongestSubsequence()
        {
            return _subsequenceFinder.FindLongestSubsequence();
        }
    }
}
