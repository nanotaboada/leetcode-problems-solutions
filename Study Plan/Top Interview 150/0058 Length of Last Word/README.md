# [58. Length of Last Word](https://leetcode.com/problems/length-of-last-word/)

Given a string `s` consisting of words and spaces, return _the length of the **last** word in the string._

A **word** is a maximal substring consisting of non-space characters only.
A substring is a contiguous non-empty sequence of characters within a string.

**Example 1:**

```text
Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
```

**Example 2:**

```text
Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
```

**Example 3:**

```text
Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
```

**Constraints:**

- $1 <=$ `s.length` <= $10^{4}$
- `s` consists of only English letters and spaces `' '`.
- There will be at least one word in `s`.
