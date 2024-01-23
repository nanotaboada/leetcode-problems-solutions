/*  
    Problem
    --------------------------------------------------------------------------------
    1. Two Sum
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/two-sum/solutions/4614598/c-based-on-hints-beats-95-in-runtime-time-and-space-complexity-o-n/
    
    - Runtime 110 ms (Beats 95.01% of users with C#)
    - Memory 48.20 MB (Beats 7.33% of users with C#)
*/

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Hint 3
        // The second train of thought is, without changing the array, can we
        // use additional space somehow? Like maybe a hash map to speed up the
        // search?
        var numberAndIndex = new Dictionary<int, int>(nums.Length);

        for (var index = 0; index < nums.Length; index++)
        {
            // Hint 2
            // "y which is value - x where value is the input parameter"
            // hints the concept of the complement:
            // x + y = target
            // y = target - x
            var complement = target - nums[index];

            if (numberAndIndex.ContainsKey(complement))
            {
                return new int[] { numberAndIndex[complement], index };
            }

            numberAndIndex.TryAdd(nums[index], index);
        }
        
        // You may assume that each input would have exactly one solution   
        throw new ArgumentException();
    }
}
