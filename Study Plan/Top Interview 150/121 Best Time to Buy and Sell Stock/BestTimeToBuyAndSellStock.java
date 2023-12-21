/*  
    Problem
    --------------------------------------------------------------------------------
    121. Best Time to Buy and Sell Stock
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 2 ms (Beats 75.28% of users with Java)
    - Memory 61.74 MB (Beats 8.18% of users with Java)
    
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