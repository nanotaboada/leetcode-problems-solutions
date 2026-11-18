# 🧩 Solutions to LeetCode problems

## 📜 Manifesto

> "Nobody should start to undertake a large project. You start with a small _trivial_ project, and you should never expect it to get large. If you do, you'll just overdesign and generally think it is more important than it likely is at that stage. Or worse, you might be scared away by the sheer size of the work you envision. So start small, and think about the details. Don't think about some big picture and fancy design. If it doesn't solve some fairly immediate need, it's almost certainly over-designed. And don't expect people to jump in and help you. That's not how these things work. You need to get something half-way _useful_ first, and then others will say "hey, that _almost_ works for me", and they'll get involved in the project." — Linus Torvalds

## 💡 About

My solutions to several [LeetCode](https://leetcode.com/) problems, in C# and Java.

## 🔁 2026 Retrospective

These solutions were written between late 2023 and early 2024. In 2026 they are being revisited one problem at a time. The original files are kept exactly as they were submitted, and each problem gains:

- 📝 A **Retrospective** section in its README: why it was solved that way at the time, a review against the [review rubric](#-review-rubric), naming, benchmark results, and what a better solution looks like today.
- ✨ A **2026 version** (`*.2026.cs`, `*.2026.java`), written with AI assistance. Like the originals, it can still be submitted to LeetCode as is.
- ✅ **Tests** that run the same cases against every version.
- 📊 **Benchmarks** that compare every version on identical inputs. They replace LeetCode's "Beats X%" percentile, which ranks a single run against other users at submission time and cannot be reproduced.

| # | Problem | Pattern | Retrospective |
| --- | --- | --- | --- |
| 1207 | Unique Number of Occurrences | Counting with a hash map | [Read](Study%20Plan/LeetCode%2075/1207%20Unique%20Number%20of%20Occurrences/README.md#-retrospective) |

## 🧭 Review rubric

LeetCode only measures runtime and memory. Each retrospective also rates every version on how easy it would be to review, trust and maintain, using the same aspects:

| Aspect | Question |
| --- | --- |
| 🏷️ Naming | Does each name say what the variable holds? |
| 📖 Readability | Can a reviewer tell what the code does in a single read? |
| ✂️ Simplicity | Is every variable, branch and level of nesting necessary? |
| 🧰 Idiomatic API use | Does it use the language and its standard library as intended, instead of reimplementing them? |
| 💬 Comments | Do comments explain why, instead of repeating the code or the API documentation? |
| 🎯 Correctness at a glance | Are edge cases (empty input, single element, bounds, overflow) visibly handled? |
| 📐 Consistency | Does it follow the language's conventions for casing, formatting and braces? |

Each aspect is rated 🟢 Good, 🟡 Fair or 🔴 Poor, and every rating is justified in the review notes. Performance is then measured with benchmarks.

## ⚙️ How it works

Every original file declares a top-level `Solution` class with no namespace or package, as LeetCode expects, so the files cannot be compiled together as they are. Before compiling, the build copies each one into a generated source folder and adds a namespace or package derived from the problem number and the file name:

| File | C# namespace | Java package |
| --- | --- | --- |
| `UniqueNumberOfOccurrences.cs` | `LeetCode.P1207.V1` | |
| `UniqueNumberOfOccurrencesV3.cs`, `.java` | `LeetCode.P1207.V3` | `leetcode.p1207.v3` |
| `UniqueNumberOfOccurrences.2026.cs`, `.java` | `LeetCode.P1207.V2026` | `leetcode.p1207.v2026` |

- C#: an MSBuild task in [`LeetCode.Solutions.csproj`](dotnet/LeetCode.Solutions/LeetCode.Solutions.csproj) adds the namespace and a `#line` directive, so compiler errors and stack traces point at the original file.
- Java: [`GenerateSources.java`](java/solutions/build/GenerateSources.java) adds the package and LeetCode's implicit imports on the original first line, so line numbers are preserved.

## 🧪 Running tests

Requires the .NET 10 SDK and JDK 25.

```bash
dotnet test --solution LeetCode.slnx
```

```bash
cd java && ./mvnw verify
```

## ⏱️ Running benchmarks

```bash
dotnet run --configuration Release --project dotnet/LeetCode.Solutions.Benchmarks -- --filter '*P1207*'
```

```bash
cd java && ./mvnw --quiet package -DskipTests && java -jar benchmarks/target/benchmarks.jar P1207 -prof gc
```

Benchmarks do not run in CI, because shared runners produce noisy measurements. The results in each retrospective come from a single machine, which is listed next to them. Compare the ratios between versions, not the absolute values.

## 🙏 Credits

The solutions have been coded using [Visual Studio Code](https://code.visualstudio.com/). The 2026 retrospectives, revisions, tests and benchmarks were written with [Claude Code](https://claude.com/claude-code).

## ⚖️ Terms

All trademarks, registered trademarks, service marks, product names, company names or logos are property of their respective owners and are used for educational purposes only.
