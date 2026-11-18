/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*
    Solution (2026 revision, written with AI assistance)
    --------------------------------------------------------------------------------
    - Time complexity O(n), space complexity O(n)
    - Enumerable.CountBy (.NET 9) builds the value -> occurrences map in one pass,
      replacing GroupBy, which materializes every group just to count it.
    - HashSet.Add returns false for a repeated count, so the check stops at the
      first one instead of comparing the sizes of two full collections.
*/

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var seenCounts = new HashSet<int>();

        foreach (var (_, count) in arr.CountBy(element => element))
        {
            if (!seenCounts.Add(count))
            {
                return false;
            }
        }

        return true;
    }
}
