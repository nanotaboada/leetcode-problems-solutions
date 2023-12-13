/*  
    Problem
    --------------------------------------------------------------------------------
    121. Best Time to Buy and Sell Stock
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock/solutions/4384292/clean-solution-in-c-beats-73-60-in-runtime/

    - Runtime 207 ms (Beats 76.87% of users with C#)
    - Memory 49.80 MB (Beats 81.90% of users with C#)
*/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int buyingPrice = prices[0];

        for (int day = 1; day < prices.Length; day++)
        {
            int dailyPrice = prices[day];

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
   