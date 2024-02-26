# [746. Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/)

You are given an integer array `cost` where `cost[i]` is the cost of $i^{th}$ step on a staircase. Once you pay the cost, you can either climb one or two steps.

You can either start from the step with index `0`, or the step with index `1`.

Return _the minimum cost to reach the top of the floor_.

**Example 1:**

```text
Input: cost = [10,15,20]
Output: 15
Explanation: You will start at index 1.
- Pay 15 and climb two steps to reach the top.
The total cost is 15.
```

**Example 2:**

```text
Input: cost = [1,100,1,1,1,100,1,1,100,1]
Output: 6
Explanation: You will start at index 0.
- Pay 1 and climb two steps to reach index 2.
- Pay 1 and climb two steps to reach index 4.
- Pay 1 and climb two steps to reach index 6.
- Pay 1 and climb one step to reach index 7.
- Pay 1 and climb two steps to reach index 9.
- Pay 1 and climb one step to reach the top.
The total cost is 6.
```

**Constraints:**

- $2 <=$ `cost.length` $<= 1000$
- $0 <=$ `cost[i]` $<= 999$

:bulb: **Hint 1**

Build an array `dp` where `dp[i]` is the minimum cost to climb to the top starting from the $i^{th}$ staircase.

:bulb: **Hint 2**

Assuming we have `n` staircase labeled from `0` to `n - 1` and assuming the top is `n`, then `dp[n] = 0`, marking that if you are at the top, the cost is `0`.

:bulb: **Hint 3**

Now, looping from `n - 1` to `0`, the `dp[i] = cost[i] + min(dp[i + 1], dp[i + 2])`. The answer will be the minimum of `dp[0]` and `dp[1]`
