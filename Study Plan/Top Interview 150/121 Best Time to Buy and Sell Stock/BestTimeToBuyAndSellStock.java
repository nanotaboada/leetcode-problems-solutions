/*  
    Problem
    --------------------------------------------------------------------------------
    121. Best Time to Buy and Sell Stock
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock/solutions/4447173/java-time-complexity-o-n-space-complexity-o-1-beats-75-in-runtime/
    
    - Time Complexity O(n)
    - Space Complexity O(1)

    - Runtime 2 ms (Beats 75.39% of users with Java)
    - Memory 61.74 MB (Beats 9.44% of users with Java)
    
*/

class Solution {
    public int maxProfit(int[] prices) {
        int profit = 0;
        int buyingPrice = prices[0];
        for (int day = 1; day < prices.length; day++) {
            int dailyPrice = prices[day];
            if (dailyPrice < buyingPrice) {
                // buy cheaper
                buyingPrice = dailyPrice;
            } else if (dailyPrice - buyingPrice > profit) {
                // sell and take profit
                profit = dailyPrice - buyingPrice;
            }
        }
        return profit;
    }
}