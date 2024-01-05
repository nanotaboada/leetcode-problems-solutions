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

    - Runtime 78 ms (Beats 12.43% of users with C#)
    - Memory 48.25 MB (Beats 33.33% of users with C#)
*/
public class Solution
{
    public int RomanToInt(string s)
    {
        int integer = 0;

        Dictionary<char, int> symbolsAndValues = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var symbols = s.ToCharArray();

        // Take the value of the last symbol to compare it with the second last
        integer = symbolsAndValues[symbols.Last()];

        // Cycle from the second last to the first symbol comparing its values
        for (int i = symbols.Length - 2; i >= 0; i--)
        {
            var symbol = symbols[i];
            var nextSymbol = symbols[i+1];
            var valueOfSymbol = symbolsAndValues[symbol];
            var valueOfNextSymbol = symbolsAndValues[nextSymbol];

            // If the first value is smaller than the next, they have to be subtracted
            if ( valueOfSymbol < valueOfNextSymbol)
            {
                integer -= valueOfSymbol;
            }
            else
            {
                // If the value is bigger than the next, they have to be be added
                integer += valueOfSymbol;
            }
        }

        return integer;
    }
}