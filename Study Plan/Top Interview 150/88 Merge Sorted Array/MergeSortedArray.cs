/*  
    Problem
    --------------------------------------------------------------------------------
    88. Merge Sorted Array
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 133 ms (Beats 34.58% of users with C#)
    - Memory 43.34 MB (Beats 6.64% of users with C#)
*/
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var merged = nums1
            .Take(m)
            .Concat(nums2)
            .OrderBy(element => element)
            .ToArray();
        
        Array.Copy(merged, nums1, m + n);
    }
}