/*  
    Problem
    --------------------------------------------------------------------------------
    1071. Greatest Common Divisor of Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/greatest-common-divisor-of-strings/solutions/4431471/java-beats-84-in-runtime-euclid-s-time-complexity-o-log-min-m-n-space-complexity-o-1/
    - Runtime 1 ms (Beats 79.23% of users with Java)
    - Memory 41.98 MB (Beats 64.12% of users with Java)
*/

class Solution {
    public String gcdOfStrings(String str1, String str2) {
        if (!(str1 + str2).equals(str2 + str1)) return "";
        int gcd = euclideanGcd(str1.length(), str2.length());
        return str2.substring(0, gcd);
    }
    // https://www.freecodecamp.org/news/euclidian-gcd-algorithm-greatest-common-divisor/
    static int euclideanGcd(int n1, int n2) {
        int R;
        while (n2 > 0) {
            R = n1 % n2;
            n1 = n2;
            n2 = R;
        }
        return n1;
    }
}