/*  
    Problem
    --------------------------------------------------------------------------------
    1. Two Sum
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 179 ms (Beats 19.04% of users with C#)
    - Memory 44.43 MB (Beats 46.07% of users with C#)
*/
public class Solution {
    
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[2] {i, j};
                }
            }
        }
        
        return null;
    }
}