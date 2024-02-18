/*  
    Problem
    --------------------------------------------------------------------------------
    219. Contains Duplicate II
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 270 ms (Beats 81.83% of users with C#)
    - Memory 66.01 MB (Beats 73.53% of users with C#)
*/

public class Solution 
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var numberAndIndex = new Dictionary<int, int>(nums.Length);

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
