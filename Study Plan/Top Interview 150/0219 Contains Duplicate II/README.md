# [219. Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/)

Given an integer array `nums` and an integer `k`, return `true` _if there are two **distinct indices**_ `i` _and_ `j` _in the array such that_ `nums[i] == nums[j]` _and_ `abs(i - j) <= k`.

**Example 1:**

```text
Input: nums = [1,2,3,1], k = 3
Output: true
```

**Example 2:**

```text
Input: nums = [1,0,1,1], k = 1
Output: true
```

**Example 3:**

```text
Input: nums = [1,2,3,1,2,3], k = 2
Output: false
```

**Constraints:**

- $1 <=$ `nums.length` $<= 10^{5}$
- $-10^{9} <=$ `nums[i]` $<= 10^{9}$
- $0 <=$ `k` $<= 10^{5}$
