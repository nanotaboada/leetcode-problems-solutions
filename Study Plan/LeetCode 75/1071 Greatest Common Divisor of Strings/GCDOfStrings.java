/*  
    Problem
    --------------------------------------------------------------------------------
    1071. Greatest Common Divisor of Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/greatest-common-divisor-of-strings/solutions/4431471/java-time-complexity-o-log-min-m-n-space-complexity-o-1-beats-84-in-runtime-euclid-s/

    - Time Complexity O(log(min(m, n)))
    - Space Complexity O(1)

    - Runtime 1 ms (Beats 84.16% of users with Java)
    - Memory 42.33 MB (Beats 14.83% of users with Java)
*/

class Solution {
    public String gcdOfStrings(String str1, String str2) {
        if (!(str1 + str2).equals(str2 + str1)) return "";
        int gcd = gcdByEuclidsAlgorithm(str1.length(), str2.length());
        return str2.substring(0, gcd);
    }
    // https://www.freecodecamp.org/news/euclidian-gcd-algorithm-greatest-common-divisor/
    static int gcdByEuclidsAlgorithm(int n1, int n2) {
        if (n2 == 0) {
            return n1;
        } else {
            return gcdByEuclidsAlgorithm(n2, n1 % n2);
        }
    }
}