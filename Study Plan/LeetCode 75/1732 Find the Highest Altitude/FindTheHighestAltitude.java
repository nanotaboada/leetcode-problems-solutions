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

    https://leetcode.com/problems/find-the-highest-altitude/solutions/4431238/java-time-complexity-o-n-space-complexity-o-1-runtime-0-ms-beats-100-graphical-analysis/

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.60 MB (Beats 19.36% of users with Java)
*/

class Solution {
    public int largestAltitude(int[] gain) {
        int[] altitudes = new int[gain.length + 1];
        int highestAltitude = 0;
        for (int index = 1; index <= gain.length; index++) {
            // Hint 1
            // Let's note that the altitude of an element is the sum of gains
            // of all the elements behind it
            // Hint 2
            // Getting the altitudes can be done by getting the prefix sum 
            // array of the given array
            altitudes[index] = altitudes[index - 1] + gain[index - 1];
            if (altitudes[index] > highestAltitude) {
                highestAltitude = altitudes[index];
            }
        }
        return highestAltitude;
    }
}
