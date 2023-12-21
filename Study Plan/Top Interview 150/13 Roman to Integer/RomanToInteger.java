/*  
    Problem
    --------------------------------------------------------------------------------
    13. Roman to Integers
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    1. Take the value of the last symbol to compare it with the second last
    2. Cycle from the second last to the first symbol comparing its values
    3. If the value is smaller than the next, they have to be subtracted
    4. If the value is bigger than the next, they have to be be added

    https://leetcode.com/problems/roman-to-integer/solutions/4432637/easy-to-follow-solution-in-java-using-hashmap-beats-66-in-runtime/

    - Runtime 4 ms (Beats 66.67% of users with Java)
    - Memory 45.06 MB (Beats 7.39% of users with Java)
*/

class Solution {
    public int romanToInt(String s) {
        int integer = 0;
        HashMap<Character, Integer> symbolsAndValues = new HashMap<>();
        symbolsAndValues.put('I', 1);
        symbolsAndValues.put('V', 5);
        symbolsAndValues.put('X', 10);
        symbolsAndValues.put('L', 50);
        symbolsAndValues.put('C', 100);
        symbolsAndValues.put('D', 500);
        symbolsAndValues.put('M', 1000);
        char[] symbols = s.toCharArray();
        // Take the value of the last symbol to compare it with the second last
        char lastSymbol = symbols[symbols.length - 1];
        integer = symbolsAndValues.get(lastSymbol);
        // Cycle from the second last to the first symbol comparing its values
        for (int i = symbols.length - 2; i >= 0; i--) {
            char symbol = symbols[i];
            char nextSymbol = symbols[i+1];
            int valueOfSymbol = symbolsAndValues.get(symbol);
            int valueOfNextSymbol = symbolsAndValues.get(nextSymbol);
            // If the first value is smaller than the next, they have to be subtracted
            if ( valueOfSymbol < valueOfNextSymbol) {
                integer -= valueOfSymbol;
            } else {
                // If the value is bigger than the next, they have to be be added
                integer += valueOfSymbol;
            }
        }
        return integer;
    }
}
