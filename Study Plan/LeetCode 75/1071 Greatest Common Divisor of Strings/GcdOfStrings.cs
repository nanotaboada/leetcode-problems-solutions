/*  
    Problem
    --------------------------------------------------------------------------------
    1071. Greatest Common Divisor of Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 66 ms (Beats 43.17% of users with C#)
    - Memory 40.41 MB (Beats 28.49% of users with C#)
*/

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return string.Empty;
        }

        var gcd = EuclideanGcd(str1.Length, str2.Length);

        return str2.Substring(0, gcd);
    }
    
    // https://www.freecodecamp.org/news/euclidian-gcd-algorithm-greatest-common-divisor/
    static int EuclideanGcd(int n1, int n2)
    {
        int R;

        while (n2 > 0)
        {
            R = n1 % n2;
            n1 = n2;
            n2 = R;
        }

        return n1;
    }
}