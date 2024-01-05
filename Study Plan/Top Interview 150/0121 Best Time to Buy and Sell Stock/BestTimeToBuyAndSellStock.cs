/*  
    Problem
    --------------------------------------------------------------------------------
    121. Best Time to Buy and Sell Stock
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock/solutions/4384292/c-time-complexity-o-n-space-complexity-o-1-beats-72-in-runtime/

    - Time Complexity O(n)
    - Space Complexity O(1)

    - Runtime 207 ms (Beats 72.14% of users with C#)
    - Memory 49.80 MB (Beats 78.80% of users with C#)
*/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var profit = 0;
        var buyingPrice = prices[0];

        for (var day = 1; day < prices.Length; day++)
        {
            var dailyPrice = prices[day];

            // https://github.com/LeetCode-Feedback/LeetCode-Feedback/issues/18237
            // if (dailyPrice > 0)
            // {
                if (dailyPrice < buyingPrice)
                {
                    // buy cheaper
                    buyingPrice = dailyPrice;
                }
                else if (dailyPrice - buyingPrice > profit)
                {
                    // sell and take profit
                    profit = dailyPrice - buyingPrice;
                }
            // }
        }

        return profit;
   