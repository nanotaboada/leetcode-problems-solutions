/*  
    Problem
    --------------------------------------------------------------------------------
    13. Roman to Integer
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/roman-to-integer/solutions/4565600/c-beats-90-in-runtime-dictionary-time-complexity-o-n-space-complexity-o-1/

    - Runtime 52 ms (Beats 90.03% of users with C#)
    - Memory 48.95 MB (Beats 22.08% of users with C#)
*/
public class Solution
{
    public int RomanToInt(string s)
    {
        int integer = 0;

        Dictionary<char, int> symbolsAndValues = new()
        {
            {'I',    1},
            {'V',    5},
            {'X',   10},
            {'L',   50},
            {'C',  100},
            {'D',  500},
            {'M', 1000}
        };

        var symbols = s.ToCharArray();

        // Take the value of the last symbol to compare it with the second last
        integer = symbolsAndValues[symbols[^1]];

        // Hint 1
        // Problem is simpler to solve by working the string from back to front
        // and using a map.
        for (var index = symbols.Length - 2; index >= 0; index--)
        {
            var symbol = symbols[index];
            var nextSymbol = symbols[index + 1];
            var valueOfSymbol = symbolsAndValues[symbol];
            var valueOfNextSymbol = symbolsAndValues[nextSymbol];

            // If the first value is smaller than the next,
            if (valueOfSymbol < valueOfNextSymbol)
            {
                // they have to be subtracted
                integer -= valueOfSymbol;
            }
            // If the value is bigger than the next,
            else
            {
                // they have to be be added
                integer += valueOfSymbol;
            }
        }

        return integer;
    }
}