/*  
    Problem
    --------------------------------------------------------------------------------
    13. Roman to Integer
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/roman-to-integer/solutions/4565600/c-beats-93-in-runtime-faster-than-dictionary-time-and-space-complexity-o-n/
    - Runtime 45 ms (Beats 93.25% of users with C#)
    - Memory 49.47 MB (Beats 22.44% of users with C#)
*/

public class Solution
{
    public int RomanToInt(string s)
    {
        int integer = 0;

        // https://www.ascii-code.com/
        var values = new int[90];
        values['I'] = 1;
        values['V'] = 5;
        values['X'] = 10;
        values['L'] = 50;
        values['C'] = 100;
        values['D'] = 500;
        values['M'] = 1000;

        var symbols = s.ToCharArray();

        // Take the value of the last symbol to compare it with the second last
        integer = values[symbols[^1]];

        // Hint 1
        // Problem is simpler to solve by working the string from back to front
        // and using a map.
        for (var index = symbols.Length - 2; index >= 0; index--)
        {
            var currentSymbol = symbols[index];
            var nextSymbol = symbols[index + 1];
            var currentValue = values[currentSymbol];
            var nextValue = values[nextSymbol];

            // If the current value is smaller than the next,
            if (currentValue < nextValue)
            {
                // they have to be subtracted
                integer -= currentValue;
            }
            // If the current value is bigger than the next,
            else
            {
                // they have to be be added
                integer += currentValue;
            }
        }

        return integer;
    }
}