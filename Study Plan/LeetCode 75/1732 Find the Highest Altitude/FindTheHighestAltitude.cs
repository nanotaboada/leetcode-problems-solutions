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

    - Time Complexity O(n)
    - Space Complexity O(1)

    - Runtime 80 ms (Beats 42.40% of users with C#)
    - Memory 38.49 MB (Beats 21.87% of users with C#)
*/

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var altitude = 0;
        var highestAltitude = 0;

        foreach (var netgain in gain)
        {
            altitude += netgain;

            if (altitude > highestAltitude)
            {
                highestAltitude = altitude;
            }
        }

        return highestAltitude;
    }
}