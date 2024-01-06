/*
    Problem
    --------------------------------------------------------------------------------
    1732. Find the Highest Altitude
*/

/*  
    Solution
    --------------------------------------------------------------------------------

    -----------------------
    | net gain | altitude |
    -----------------------
    |          |     0    |
    |    -5    |    -5    |
    |     1    |    -4    |
    |     5    |     1    |
    |     0    |     1    |
    |    -7    |    -6    |
    -----------------------

     altitudes
     7 |
     6 |
     5 |        
     4 |    
     3 |
     2 |
     1 |              X    X  
     0 X----|----|----|----|----|---- points
    -1 |    1    2    3    4    5
    -2 |
    -3 |
    -4 |         X
    -5 |    X
    -6 |                        X
    -7 |

    https://leetcode.com/problems/find-the-highest-altitude/solutions/4395531/c-time-complexity-o-n-space-complexity-o-1-graphical-analysis-in-comments/

    - Runtime 63 ms (Beats 92.85% of users with C#)
    - Memory 39.86 MB (Beats 17.61% of users with C#)
*/

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var altitudes = new int[gain.Length + 1];
        var highestAltitude = 0;

        for (int index = 1; index <= gain.Length; index++)
        {
            // Hint 1
            // Let's note that the altitude of an element is the sum of gains
            // of all the elements behind it
            // Hint 2
            // Getting the altitudes can be done by getting the prefix sum 
            // array of the given array
            altitudes[index] = altitudes[index - 1] + gain[index - 1];
            
            if (altitudes[index] > highestAltitude)
            {
                highestAltitude = altitudes[index];
            }
        }

        return highestAltitude;
    }
}