/*  
    Problem
    --------------------------------------------------------------------------------
    26. Remove Duplicates from Sorted Array
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 143 ms (Beats 27.72% of users with C#)
    - Memory 46.92 MB (Beats 6.29% of users with C#)
*/
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var uniques = nums.Distinct().ToArray();
        Array.Copy(uniques, nums, uniques.Length);

        return uniques.Length;
    }
}