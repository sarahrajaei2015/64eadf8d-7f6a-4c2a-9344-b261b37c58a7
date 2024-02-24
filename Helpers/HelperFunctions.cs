namespace Code_Test.Helpers
{
    public class HelperFunctions
    {
        public static void UpdateLongestSubsequence(ref List<int> longest, List<int> current)
        {
            if (current.Count > longest.Count)
            {
                longest = new List<int>(current);
            }
        }
    }
}
