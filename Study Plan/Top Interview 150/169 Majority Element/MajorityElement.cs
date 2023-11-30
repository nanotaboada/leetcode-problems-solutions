/*  
    Problem
    --------------------------------------------------------------------------------
    169. Majority Element
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 103 ms (Beats 33.37% of users with C#)
    - Memory 45.48 MB (Beats 7.15% of users with C#)
*/
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int majority = 0;
        var groups = nums.GroupBy(element => element);
        
        foreach (var group in groups)
        {
            if (group.Count() > nums.Length / 2)
            {
                majority = group.Key;
            }
        }

        return majority;
    }
}
