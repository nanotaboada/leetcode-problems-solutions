/*  
    Problem
    --------------------------------------------------------------------------------
    1071. Greatest Common Divisor of Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 2 ms (Beats 23.63% of users with Java)
    - Memory 42.07 MB (Beats 64.24% of users with Java)
*/

import java.math.BigInteger;

class Solution {
    public String gcdOfStrings(String str1, String str2) {
        if (!(str1 + str2).equals(str2 + str1)) return "";
        BigInteger str1Length = BigInteger.valueOf(str1.length());
        BigInteger str2Length = BigInteger.valueOf(str2.length());
        BigInteger gcd = str1Length.gcd(str2Length);
        return str2.substring(0, gcd.intValue());
    }
}
