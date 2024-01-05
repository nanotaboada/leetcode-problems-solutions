/*
    Problem
    --------------------------------------------------------------------------------
    12. Integer to Roman
*/

/*
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/integer-to-roman/solutions/4508995/c-time-complexity-o-n-space-complexity-o-1-beats-98-in-runtime-list-of-key-value-pairs/
    
    - Runtime 50 ms (Beats 98.84% of users with C#)
    - Memory 46.38 MB (Beats 26.10% of users with C#)
*/

public class Solution
{
    public string IntToRoman(int num)
    {
        var roman = new StringBuilder();

        // Guarantees insertion order
        List<KeyValuePair<int, string>> numbersAndSymbols = new()
        {
            new(1000, "M" ),
            new( 900, "CM"),
            new( 500, "D" ),
            new( 400, "CD"),
            new( 100, "C" ),
            new(  90, "XC"),
            new(  50, "L" ),
            new(  40, "XL"),
            new(  10, "X" ),
            new(   9, "IX"),
            new(   5, "V" ),
            new(   4, "IV"),
            new(   1, "I" )
        };

        foreach (var numberAndSymbol in numbersAndSymbols)
        {
            var number = numberAndSymbol.Key;
            var symbol = numberAndSymbol.Value;

            while (num >= number)
            {
                roman.Append(symbol);
                num -= number;
            }
        }

        return roman.ToString();
    }
}
