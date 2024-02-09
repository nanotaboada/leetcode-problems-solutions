/*
    Problem
    --------------------------------------------------------------------------------
    12. Integer to Roman
*/

/*
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/integer-to-roman/solutions/4702339/java-beats-98-in-runtime-faster-than-hashmap-time-and-space-complexity-o-1/
    - Runtime 3 ms (Beats 98.23% of users with Java)
    - Memory 44.65 MB (Beats 32.44% of users with Java)
*/

class Solution {
    public String intToRoman(int num) {
        StringBuilder roman = new StringBuilder();
        int[] numbers = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        String[] symbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        for (int i = 0; i < numbers.length; i++) {
            while (num >= numbers[i]) {
                roman.append(symbols[i]);
                num -= numbers[i];
            }
        }
        return roman.toString();
    }
}

