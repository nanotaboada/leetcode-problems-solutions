/*  
    Problem
    --------------------------------------------------------------------------------
    1071. Greatest Common Divisor of Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 57 ms (Beats 63.66% of users with C#)
    - Memory 40.49 MB (Beats 34.71% of users with C#)
*/

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if ((str1 + str2) != (str2 + str1))
        {
            return string.Empty;
        }
        // https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger.greatestcommondivisor
        var gcd = BigInteger.GreatestCommonDivisor(str1.Length, str2.Length);

        return str2.Substring(0, (int)gcd);
    }
}
