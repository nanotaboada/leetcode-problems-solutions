/*  
    Problem
    --------------------------------------------------------------------------------
    27. Remove Element
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 101 ms (Beats 97.62% of users with C#)
    - Memory 45.78 MB (Beats 5.42% of users with C#)
*/
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;

        // Consider the number of elements in nums which are not equal to val
        // be k
        var k = 0;

        for (var index = 0; index < nums.Length; index++)
        {
            if (nums[index] != val)
            {
                // Swap the non-val element to the front
                nums[k] = nums[index];
                // Increment the number of non-val elements
                k++;
            }
        }

        return k;
    }
}