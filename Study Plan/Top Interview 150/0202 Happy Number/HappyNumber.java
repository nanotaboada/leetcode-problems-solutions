/*  
    Problem
    --------------------------------------------------------------------------------
    202. Happy Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 70.04% of users with Java)
    - Memory 41.09 MB (Beats 19.03% of users with Java)
*/

class Solution {
    public boolean isHappy(int n) {
        // To avoid entering in an endless loop, that is, obtaining a result N
        // that leads to the same result N, and as suggested by the Topics of 
        // the problem, we will make use of a HashSet to store the results that
        // we've already processed or computed through the process.
        HashSet<Integer> computed = new HashSet<>();
        while(!computed.contains(n)) {
            computed.add(n);
            if(n == 1) {
                return true;
            }
            n = sumOfSquaresOfDigits(n);
        }
        return false;
    }
    private int sumOfSquaresOfDigits(int number) {
        int sum = 0;
        int digit = 0;
        // The following is a popular way to split a number into its digits:
        while (number > 0) {
            digit = number % 10;
            number /= 10;
            sum += digit * digit;
        }
        return sum;
    }
}