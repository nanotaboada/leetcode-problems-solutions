# [1207. Unique Number of Occurrences](https://leetcode.com/problems/unique-number-of-occurrences/)

Given an array of integers `arr`, return `true` _if the number of occurrences of each value in the array is **unique** or_ `false` _otherwise_.

**Example 1:**

```text
Input: arr = [1,2,2,1,1,3]
Output: true
Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1.
No two values have the same number of occurrences.
```

**Example 2:**

```text
Input: arr = [1,2]
Output: false
```

**Example 3:**

```text
Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
Output: true
```

**Constraints:**

- $1 <=$ `arr.length` $<= 1000$
- $-1000 <=$ `arr[i]` $<= 1000$

:bulb: **Hint 1**

Find the number of occurrences of each element in the array using a hash map.

:bulb: **Hint 2**

Iterate through the hash map and check if there is a repeated value.

## Retrospective

_Reviewed in November 2026. Original versions: C# V1 and V2 (December 2023), C# V3 and Java V3 (January 2024, C# V3 presized in February 2024). See the [review rubric](../../../README.md#review-rubric) for what each aspect means._

### Then

The C# versions show a clear progression, and each step responds to the percentile LeetCode reported:

- **V1** follows the two hints literally: `GroupBy` to count, then a `HashSet` to detect a repeated count. It is short and correct. Reported: "Beats 16%".
- **V2** goes fully declarative: a second `GroupBy` over the counts, then `All(count => count == 1)`. It reads like a query, but it is the hardest to follow and the slowest. Reported: "Beats 5.7%".
- **V3** replaces LINQ with an explicit `Dictionary` loop. Reported: "Beats 95%". A later commit presized the dictionary to `arr.Length`, which moved the memory percentile from 24% to 89% for a difference of 0.42 MB, measured on top of a process baseline of about 40 MB.
- **Java V3** is the same algorithm as C# V3, and was already "Beats 98%".

### Review

Every version is O(n) time and O(n) space. None of the rewrites changed the algorithm, only constant factors and readability.

| Aspect | V1 | V2 | V3 | 2026 |
| --- | --- | --- | --- | --- |
| Naming | Fair | Poor | Fair | Good |
| Readability | Good | Poor | Fair | Good |
| Simplicity | Good | Poor | Fair | Good |
| Idiomatic API use | Fair | Fair | Fair | Good |
| Comments | Fair | Poor | Fair | Good |
| Correctness at a glance | Good | Fair | Good | Good |
| Consistency | Fair | Good | Fair | Good |

- **Readability and simplicity:** to see that V2 checks "every count appears once", a reviewer has to trace three chained projections and an anonymous type. V3 spends five lines and two lookups (`ContainsKey`, then the indexer) on what `CountBy` in C# or `merge` in Java express in one.
- **Idiomatic API use:** `GroupBy(...).Select(group => group.Count())` builds a collection for every group only to count it. .NET 9 added `CountBy` for exactly this case.
- **Comments:** "Hint 1" and "Hint 2" repeat LeetCode's hints, and the link to `HashSet<T>.Add` documents the API rather than the intent. One line explaining that a `false` from `Add` means a repeated count is enough.
- **Correctness at a glance:** in V2, the reader has to work out that `All(... == 1)` over grouped counts is equivalent to "no repeated count".
- **Consistency:** `if(` without a space in V1 and V3, against the spacing used everywhere else.
- **Presizing:** `new Dictionary<int, int>(arr.Length)` sizes the dictionary for the number of elements, but the number of distinct keys is bounded by the value range (2,001). Within LeetCode's limits (1,000 elements) this is harmless. At 100,000 elements it allocates 2.1 MB on the Large Object Heap and triggers Gen2 collections.

### Naming

| Version | Name | What it holds | Issue | Better |
| --- | --- | --- | --- | --- |
| V1, V3 | `occurrences` | Element to count | An occurrence is one appearance, not a count | `countByElement` |
| V1, V3 | `occurrence` | One count | Singular noun for a number | `count` (Java V3 already uses it) |
| V1, V3 | `uniques` | Counts seen so far | Adjective used as a noun; does not say what is unique | `seenCounts` |
| V2 | `occurrenceOfElements` | Element and count pairs | Would read "occurrences per element" | `countByElement` |
| V2 | `numberOfOccurrences` | How many elements share each count | Says the opposite of what it holds | `elementsPerCount` |
| V2 | `uniqueOcurrences` | A `bool` | Typo ("ocurrencia" in Spanish), and does not read as a statement | `allCountsUnique` |

`element` for each value and the problem's own vocabulary were good choices. The issues are about precision, not English: a name should say what the variable holds, not what topic it relates to.

### Results

Intel Core i7-9750H, macOS 15.7, .NET 10.0.12 (BenchmarkDotNet 0.15.8), Temurin 25.0.4.1 (JMH 1.37). `AllUnique`: value _k_ appears _k_ times, so every count is distinct and no version can stop early. `Random`: values drawn from the full range, so counts repeat almost immediately.

C#, mean time and allocated memory per call:

| Input | Length | V1 | V2 | V3 | 2026 |
| --- | ---: | ---: | ---: | ---: | ---: |
| AllUnique | 1,000 | 19.4 μs, 23.4 KB | 21.6 μs, 26.7 KB | 10.7 μs, 24.4 KB | **6.4 μs, 6.2 KB** |
| Random | 1,000 | 51.6 μs, 90.5 KB | 84.9 μs, 130.5 KB | **12.4 μs, 21.8 KB** | 12.9 μs, 34.0 KB |
| AllUnique | 100,000 | 2,090 μs, 1,254 KB | 2,126 μs, 1,284 KB | 1,444 μs, 2,149 KB | **700 μs, 61 KB** |
| Random | 100,000 | 3,708 μs, 1,488 KB | 4,197 μs, 1,584 KB | 1,212 μs, 2,123 KB | **607 μs, 151 KB** |

Java, mean time and allocated memory per call:

| Input | Length | V3 | 2026 |
| --- | ---: | ---: | ---: |
| AllUnique | 1,000 | 12.8 μs, 3.8 KB | 12.9 μs, 3.8 KB |
| Random | 1,000 | 27.5 μs, 68.0 KB | 30.9 μs (± 7.6), 54.3 KB |
| AllUnique | 100,000 | 2,054 μs, 3,708 KB | 1,792 μs, 2,272 KB |
| Random | 100,000 | 3,262 μs, 2,817 KB | 2,813 μs, 1,456 KB |

- In C#, the 2026 version is 3 to 6 times faster than V1 and allocates up to 20 times less. On random input of LeetCode's size it ties with V3, because both stop at the first repeated count.
- V2 is the slowest in every scenario.
- In Java, V3 was already the right solution. The 2026 version modernizes the syntax with a similar performance.
- A first 2026 draft compared the sizes of two full collections instead of stopping early, and was twice as slow as V3 on random input. The benchmark caught it.

### Takeaways

1. Chasing the percentile did find a real gain (V3 is twice as fast as V1), but it cost readability and introduced a presizing that backfires outside LeetCode's limits.
2. The right standard library API removes the trade-off: `CountBy` is both the most readable and the fastest C# version.
3. Stopping at the first repeated count matters whenever the answer can be found early.
4. Name what a variable holds: `countByElement`, `seenCounts`, `allCountsUnique`.
5. Not adopted: since values are bounded to [-1000, 1000], an `int[2001]` counting array would avoid hashing altogether. It is faster, but it couples the code to the constraints and is harder to review.
