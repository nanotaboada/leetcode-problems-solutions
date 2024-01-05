/*
    Problem
    --------------------------------------------------------------------------------
    238. Product of Array Except Self
*/

/*
    Solution
    --------------------------------------------------------------------------------

    - Cycle the collection left-to-right (from the second element to the last),
    calculating the poduct of the elements to its left.

            ---------------->  leftToRight  
    nums    [       1       ,       2       ,       3       ,       4       ]
                                    1

            --------------- * -------------->  leftToRight
    nums    [       1       ,       2       ,       3       ,       4       ]
                                                    1 * 2

            --------------- * ------------- * -------------->  leftToRight
    nums    [       1       ,       2       ,       3       ,       4       ]
                                                                1 * 2 * 3

            -----------------------------------------------------------------

    left    [               ,       1       ,       2     ,          6      ]

    - Cycle the collection right-to-left (from the second to last to the first),
    calculating the poduct of the elements to its right.

                                        rightToLeft  <----------------
    [       1       ,       2       ,       3       ,       4       ]   nums
                                            4

                        rightToLeft  <-------------- * ---------------
    [       1       ,       2       ,       3       ,       4       ]   nums
                            3 * 4

        rightToLeft  <-------------- * ------------- * ---------------
    [       1       ,       2       ,       3       ,       4       ]   nums
        2 * 3 * 4

    -----------------------------------------------------------------

    [       24      ,       12      ,       4       ,               ]   right

    - Finally, cycle the results collection (output), calculating
    left * right.

    left    [               ,       1       ,       2       ,       6      ]
    right   [       24      ,      12       ,       4       ,              ]
            ----------------------------------------------------------------
            [       24      ,    1 * 12     ,     2 * 4     ,       6      ]

            ----------------------------------------------------------------

    output  [       24      ,        12     ,       8       ,       6      ]

    https://leetcode.com/problems/product-of-array-except-self/solutions/4509267/c-time-and-space-complexity-0-n-runtime-1ms-beats-93-step-by-step-explanation/

    - Runtime 142 ms (Beats 93.99% of users with C#)
    - Memory 58.68 MB (Beats 6.24% of users with C#)
*/

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var output = new int[nums.Length];
        var left = new int[nums.Length];
        var right = new int[nums.Length];

        // A new array is initialized with zeros, so for the product to make
        // sense, we need to set the first element of left and the last element
        // of right to 1, otherwise it will cause n * 0 = 0
        left[0] = 1;
        right[nums.Length - 1] = 1;

        // Cycle the collection left-to-right (from the second element to the last),
        for (var leftToRight = 1; leftToRight < nums.Length; leftToRight++)
        {
            // calculating the poduct of the elements to its left.
            left[leftToRight] = left[leftToRight - 1] * nums[leftToRight - 1];
        }

        // Cycle the collection right-to-left (from the second to last to the first),
        for (var rightToLeft = nums.Length - 2; rightToLeft >= 0; rightToLeft--)
        {
            // calculating the poduct of the elements to its right.
            right[rightToLeft] = right[rightToLeft + 1] * nums[rightToLeft + 1];
        }

        // Finally, cycle the results collection (output),
        for (var index = 0; index < output.Length; index++)
        {
            // calculating left * right.
            output[index] = left[index] * right[index];
        }

        return output;
    }
}
