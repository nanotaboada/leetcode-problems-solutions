/*  
    Problem
    --------------------------------------------------------------------------------
    26. Remove Duplicates from Sorted Array
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 112 ms (Beats 93.05% of users with C#)
    - Memory 49.83 MB (Beats 51.52% of users with C#)
*/

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1) return 1;

        // Consider the number of unique elements of nums to be k
        var k = 0;

        for (var index = 0; index < nums.Length - 1; index++)
        {
            if (nums[index] != nums[index + 1])
            {
                nums[k++] = nums[index];
            }
        }

        nums[k++] = nums[nums.Length - 1];

        return k;
    }
}