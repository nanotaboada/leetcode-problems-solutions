/*
    Problem
    --------------------------------------------------------------------------------
    12. Integer to Roman
*/

/*
    Solution
    --------------------------------------------------------------------------------
    - Runtime 7 ms (Beats 39.65% of users with Java)
    - Memory 44.92 MB (Beats 6.19% of users with Java)
*/

class Solution {
    public String intToRoman(int num) {
        StringBuilder roman = new StringBuilder();
        // Guarantees insertion order
        LinkedHashMap<Integer,String> numbersAndSymbols = new LinkedHashMap<>();
        numbersAndSymbols.put(1000, "M" );
        numbersAndSymbols.put( 900, "CM");
        numbersAndSymbols.put( 500, "D" );
        numbersAndSymbols.put( 400, "CD");
        numbersAndSymbols.put( 100, "C" );
        numbersAndSymbols.put(  90, "XC");
        numbersAndSymbols.put(  50, "L" );
        numbersAndSymbols.put(  40, "XL");
        numbersAndSymbols.put(  10, "X" );
        numbersAndSymbols.put(   9, "IX");
        numbersAndSymbols.put(   5, "V" );
        numbersAndSymbols.put(   4, "IV");
        numbersAndSymbols.put(   1, "I" );
        for (Map.Entry<Integer,String> numberAndSymbol : numbersAndSymbols.entrySet()) {
            int number = numberAndSymbol.getKey();
            String symbol = numberAndSymbol.getValue();
            while (num >= number) {
                roman.append(symbol);
                num -= number;
            }
        }
        return roman.toString();
    }
}
