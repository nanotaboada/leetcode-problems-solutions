/*
    Problem
    --------------------------------------------------------------------------------
    2215. Find the Difference of Two Arrays
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/find-the-difference-of-two-arrays/solutions/4400507/c-linq-time-and-space-complexity-o-max-n-m-beats-97-in-runtime/

    - Time and Space Complexity O(max(n, m))

    - Runtime 142 ms (Beats 97.26% of users with C#)
    - Memory 59.77 MB (Beats 19.45% of users with C#)
*/

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var answer = new List<IList<int>>();
        
        var answer1 = nums1.Except(nums2).ToList();
        var answer2 = nums2.Except(nums1).ToList();
        
        answer.Add(answer1);
        answer.Add(answer2);
        
        return answer;
    }
}