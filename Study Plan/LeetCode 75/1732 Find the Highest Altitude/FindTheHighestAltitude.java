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

    https://leetcode.com/problems/find-the-highest-altitude/solutions/4431238/clean-solution-in-java-with-explanation-in-code-comments-beats-100-in-runtime/

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.60 MB (Beats 6.57% of users with Java)
*/

class Solution {
    public int largestAltitude(int[] gain) {
        int altitude = 0;
        int highestAltitude = 0;
        for (int netgain : gain) {
            altitude += netgain;
            if (altitude > highestAltitude) {
                highestAltitude = altitude;
            }
        }
        return highestAltitude;
    }
}
