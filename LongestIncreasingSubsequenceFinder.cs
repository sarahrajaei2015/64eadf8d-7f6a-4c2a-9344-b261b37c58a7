using Code_Test.Helpers;
using Code_Test.Interfaces;

namespace Code_Test
{
    // Concrete strategy for finding the longest increasing subsequence
    public class LongestIncreasingSubsequenceFinder : ISubsequenceFinder
        {
            public List<int> FindSubsequence(List<int> sequence)
            {
                List<int> longestSubsequence = new List<int>();
                List<int> currentSubsequence = new List<int>();

                // Iterate through the sequence to find the longest increasing subsequence
                for (int i = 0; i < sequence.Count - 1; i++)
                {
                    if (sequence[i] < sequence[i + 1])
                    {
                        // Extend the current subsequence
                        currentSubsequence.Add(sequence[i]);

                        // Include the last element if it is part of the increasing subsequence
                        if (i == sequence.Count - 2)
                        {
                            currentSubsequence.Add(sequence[i + 1]);
                        }
                    }
                    else
                    {
                        // End of increasing subsequence, compare and update the longest subsequence
                        currentSubsequence.Add(sequence[i]);
                    HelperFunctions.UpdateLongestSubsequence(ref longestSubsequence, currentSubsequence);

                        // Reset the current subsequence for the next iteration
                        currentSubsequence.Clear();
                    }
                }

                return longestSubsequence;
            }
        }
}
