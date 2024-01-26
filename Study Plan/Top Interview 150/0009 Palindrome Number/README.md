# [9. Palindrome Number](https://leetcode.com/problems/palindrome-number/)

Given an integer `x`, return `true` _if_ `x` _is a_ _**[palindrome](https://en.wikipedia.org/wiki/Palindrome)**_, _and_ `false` _otherwise_.

**Example 1:**

```text
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
```

**Example 2:**

```text
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-.
Therefore it is not a palindrome.
```

**Example 3:**

```text
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
```

**Constraints:**

- $-2^{31}$ <= `x` <= $2^{31} - 1$

**Follow up:** Could you solve it without converting the integer to a string?

:bulb: **Hint 1**

Beware of overflow when you reverse the integer.
