# [383. Ransom Note](https://leetcode.com/problems/ransom-note/)

Given two strings `ransomNote` and `magazine`, return `true` _if_ `ransomNote` _can be constructed by using the letters from_ `magazine` _and_ `false` _otherwise_.

Each letter in `magazine` can only be used once in `ransomNote`.

**Example 1:**

```text
Input: ransomNote = "a", magazine = "b"
Output: false
```

**Example 2:**

```text
Input: ransomNote = "aa", magazine = "ab"
Output: false
```

**Example 3:**

```text
Input: ransomNote = "aa", magazine = "aab"
Output: true
```

**Constraints:**

- $1 <=$ `ransomNote.length`, `magazine.length` $<= 10^{5}$
- `ransomNote` and `magazine` consist of lowercase English letters.
