/*  
    Problem
    --------------------------------------------------------------------------------
    128. Longest Consecutive Sequence
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/longest-consecutive-sequence/solutions/4739304/c-beats-92-in-runtime-time-and-space-complexity-o-n-hashset/
    
    - Runtime 206 ms (Beats 92.76% of users with C#)
    - Memory 66.82 MB (Beats 33.04% of users with C#)
*/

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var longest = 0;

        if (nums.Length == 0) return 0;

        // We use a HashSet to store the numbers (without duplicates) as well as
        // for efficient lookups
        var numbers = new HashSet<int>(nums);

        foreach (var number in numbers)
        {
            // Check if the current number is the start of a potential sequence
            if (!numbers.Contains(number - 1))
            {
                var length = 1;
                var element = number;

                // Traverse the sequence while it contains the next consecutive
                // element
                while (numbers.Contains(element + 1))
                {
                    element++;
                    length++;
                }

                // Update the longest sequence if the current length is longer
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
