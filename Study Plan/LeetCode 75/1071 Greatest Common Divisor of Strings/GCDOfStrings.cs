/*  
    Problem
    --------------------------------------------------------------------------------
    1071. Greatest Common Divisor of Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 78 ms (Beats 31.18% of users with C#)
    - Memory 37.74 MB (Beats 93.02% of users with C#)
*/
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return string.Empty;
        }

        var gcd = GcdByEuclidsAlgorithm(str1.Length, str2.Length);

        return str2[..gcd];
    }
    
    // https://www.freecodecamp.org/news/euclidian-gcd-algorithm-greatest-common-divisor/
    static int GcdByEuclidsAlgorithm(int n1, int n2)
    {
        if (n2 == 0)
        {
            return n1;
        }
        
        return GcdByEuclidsAlgorithm(n2, n1 % n2);
    }
}