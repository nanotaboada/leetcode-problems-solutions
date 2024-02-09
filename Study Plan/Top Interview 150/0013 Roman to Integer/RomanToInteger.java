/*  
    Problem
    --------------------------------------------------------------------------------
    13. Roman to Integer
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 4 ms (Beats 66.67% of users with Java)
    - Memory 45.06 MB (Beats 7.39% of users with Java)
*/

class Solution {
    public int romanToInt(String s) {
        int integer = 0;
        HashMap<Character, Integer> symbolsAndValues = new HashMap<>();
        symbolsAndValues.put('I',    1);
        symbolsAndValues.put('V',    5);
        symbolsAndValues.put('X',   10);
        symbolsAndValues.put('L',   50);
        symbolsAndValues.put('C',  100);
        symbolsAndValues.put('D',  500);
        symbolsAndValues.put('M', 1000);
        char[] symbols = s.toCharArray();
        // Take the value of the last symbol to compare it with the second last
        char lastSymbol = symbols[symbols.length - 1];
        integer = symbolsAndValues.get(lastSymbol);
        // Hint 1
        // Problem is simpler to solve by working the string from back to front
        // and using a map.
        for (int i = symbols.length - 2; i >= 0; i--) {
            char symbol = symbols[i];
            char nextSymbol = symbols[i+1];
            int valueOfSymbol = symbolsAndValues.get(symbol);
            int valueOfNextSymbol = symbolsAndValues.get(nextSymbol);
            // If the first value is smaller than the next,
            if (valueOfSymbol < valueOfNextSymbol) {
                // they have to be subtracted
                integer -= valueOfSymbol;
            // If the value is bigger than the next,
            } else {
                // they have to be be added
                integer += valueOfSymbol;
            }
        }
        return integer;
    }
}
