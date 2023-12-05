/*  
    Problem
    --------------------------------------------------------------------------------
    190. Reverse Bits
*/

/*  
    Solution
    --------------------------------------------------------------------------------
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