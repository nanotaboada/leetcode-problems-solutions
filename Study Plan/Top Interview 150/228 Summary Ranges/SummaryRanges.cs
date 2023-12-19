/*  
    Problem
    --------------------------------------------------------------------------------
    228. Summary Ranges
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/summary-ranges/solutions/4426207/clean-easy-to-follow-solution-in-c-beats-83-in-runtime/
    
    - Runtime 135 ms (Beats 83.92% of users with C#)
    - Memory 43.52 MB (Beats 14.87% of users with C#)
*/

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var ranges = new List<string>();

        if (nums.Length == 0)
        {
            return ranges;
        }

        var index = 0;

        // Cycle the entire collection
        while (index < nums.Length)
        {
            var a = nums[index];
            var b = a;

            // Loop while a + 1 = b to define the range
            // (and index is within bounds)
            while (index < nums.Length - 1
                && nums[index] + 1 == nums[index + 1])
            {
                b = nums[index + 1];
                index++;
            }

            // There is more than one element in the range
            if (a != b)
            {
                ranges.Add(string.Format("{0}->{1}", a, b));
            }
            // Just a single element
            else
            {
                ranges.Add(string.Format("{0}", a));
            }

            index++;
        }

        return ranges;
    }
}