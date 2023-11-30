/*  
    Problem
    --------------------------------------------------------------------------------
    27. Remove Element
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 141 ms (Beats 5.99% of users with C#)
    - Memory 42.84 MB (Beats 40.50% of users with C#)
*/
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var filtered = nums.Where(value => value != val).ToArray();
        Array.Copy(filtered, nums, filtered.Length);

        return filtered.Length;
    }
}