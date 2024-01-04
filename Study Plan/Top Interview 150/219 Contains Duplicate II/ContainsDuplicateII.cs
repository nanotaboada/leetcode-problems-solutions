/*  
    Problem
    --------------------------------------------------------------------------------
    219. Contains Duplicate II
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 264 ms (Beats 37.89% of users with C#)
    - Memory 70.64 MB (Beats 9.27% of users with C#)
*/

public class Solution 
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var numberAndIndex = new Dictionary<int, int>();

        for (var index = 0; index < nums.Length; index++)
        {
            var number = nums[index];

            if (!numberAndIndex.ContainsKey(number))
            {
                numberAndIndex.Add(number, index);
            }
            else
            {
                if (Math.Abs(numberAndIndex[number] - index) <= k)
                {
                    return true;
                }
                else
                {
                    numberAndIndex[number] = index;
                }
            }
        }

        return false;
    }
}
