# [20. Valid Parentheses](https://leetcode.com/problems/valid-parentheses/)

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every close bracket has a corresponding open bracket of the same type.

**Example 1:**

```text
Input: s = "()"
Output: true
```

**Example 2:**

```text
Input: s = "()[]{}"
Output: true
```

**Example 3:**

```text
Input: s = "(]"
Output: false
```

**Constraints:**

- $1 <=$ `s.length` $<= 10^{4}$
- `s` consists of parentheses only `'()[]{}'`.

:bulb: **Hint 1**

Use a stack of characters.

:bulb: **Hint 2**

When you encounter an opening bracket, push it to the top of the stack.

:bulb: **Hint 3**

When you encounter a closing bracket, check if the top of the stack was the opening for it. If yes, pop it from the stack. Otherwise, return false.
