/*  
    Problem
    --------------------------------------------------------------------------------
    190. Reverse Bits
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/reverse-bits/solutions/4384305/clean-solution-in-c-beats-96-50-of-users-in-runtime/

    - Runtime 16 ms (Beats 96.34% of users with C#)
    - Memory 24.56 MB (Beats 18.50% of users with C#)
*/
public class Solution
{
    public uint reverseBits(uint n)
    {
        var original = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
        Array.Reverse(original);
        var reversed = new string(original);
        
        return Convert.ToUInt32(reversed, 2);
    }
}