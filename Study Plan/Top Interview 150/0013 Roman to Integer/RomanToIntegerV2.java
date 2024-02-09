/*  
    Problem
    --------------------------------------------------------------------------------
    13. Roman to Integer
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/roman-to-integer/solutions/4432637/java-beats-100-in-runtime-faster-than-hashmap-time-and-space-complexity-o-n/
    - Runtime 2 ms (Beats 100.00% of users with Java)
    - Memory 44.62 (MB Beats 53.02% of users with Java)
*/

class Solution {
    public int romanToInt(String s) {
        int integer = 0;
        // https://www.ascii-code.com/
        int[] values = new int[90];
        values['I'] = 1;
        values['V'] = 5;
        values['X'] = 10;
        values['L'] = 50;
        values['C'] = 100;
        values['D'] = 500;
        values['M'] = 1000;
        char[] symbols = s.toCharArray();
        // Take the value of the last symbol to compare it with the second last
        char lastSymbol = symbols[symbols.length - 1];
        integer = values[lastSymbol];
        // Hint 1
        // Problem is simpler to solve by working the string from back to front
        // and using a map.
        for (int index = symbols.length - 2; index >= 0; index--) {
            char currentSymbol = symbols[index];
            char nextSymbol = symbols[index + 1];
            int currentValue = values[currentSymbol];
            int nextValue = values[nextSymbol];
            // If the current value is smaller than the next,
            if (currentValue < nextValue) {
                // they have to be subtracted
                integer -= currentValue;
            // If the current value is bigger than the next,
            } else {
                // they have to be be added
                integer += currentValue;
            }
        }
        return integer;
    }
}
