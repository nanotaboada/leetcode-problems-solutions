/*  
    Problem
    --------------------------------------------------------------------------------
    66. Plus One
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 129 ms (Beats 44.96% of users with C#)
    - Memory 42.65 MB (Beats 28.39% of users with C#)
*/

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        // Loop backwards (right-to-left)
        // e.g. [ 4, 3, 2, 1 ]
        for (var rightToLeft = digits.Length - 1; rightToLeft >= 0; rightToLeft--)
        {
            // If the last digit is less than 9, just increment by one and return
            if (digits[rightToLeft] < 9) // digits[3] = 1
            {
                digits[rightToLeft]++; // [ 4, 3, 2, 2 ]

                return digits;
            }
            // If the last digit is greater than 9, then set the current digit to 0
            // and the next iteration will handle the carry anyways
            // e.g. [1, 9, 9]
            else
            {
                digits[rightToLeft] = 0;
                // 1st iteration [1, 9, 0]
                // 2nd iteration [1, 0, 0]
            }
        }

        // If the last digit is greater than 9 through the whole cycle, then the
        // number would be all nines, e.g. [9, 9, 9], and we will need to add an
        // extra digit to the collection to address that case

        // Create a collection with an additional digit and set the first to 1
        var digitsPlusOne = new int[digits.Length + 1]; // [ 0, 0, 0, 0 ]
        digitsPlusOne[0] = 1; // [ 1, 0, 0, 0 ]
        
        return digitsPlusOne;
    }
}