/*  
    Problem
    --------------------------------------------------------------------------------
    136. Single Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 104 ms (Beats 27.66% of users with C#)
    - Memory 50.15 MB (Beats 5.61% of users with C#)
*/
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        return nums
            .GroupBy(number => number)
            .Where(group => group.Count() == 1)
            .Select(element => element.Key)
            .First();
    }
}
