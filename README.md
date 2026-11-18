# Solutions to LeetCode problems

## Manifesto

> "Nobody should start to undertake a large project. You start with a small _trivial_ project, and you should never expect it to get large. If you do, you'll just overdesign and generally think it is more important than it likely is at that stage. Or worse, you might be scared away by the sheer size of the work you envision. So start small, and think about the details. Don't think about some big picture and fancy design. If it doesn't solve some fairly immediate need, it's almost certainly over-designed. And don't expect people to jump in and help you. That's not how these things work. You need to get something half-way _useful_ first, and then others will say "hey, that _almost_ works for me", and they'll get involved in the project." — Linus Torvalds

## About

My solutions to several [LeetCode](https://leetcode.com/) problems, in C# and Java.

## How it works

Every original file declares a top-level `Solution` class with no namespace or package, as LeetCode expects, so the files cannot be compiled together as they are. Before compiling, the build copies each one into a generated source folder and adds a namespace or package derived from the problem number and the file name:

| File | C# namespace | Java package |
| --- | --- | --- |
| `UniqueNumberOfOccurrences.cs` | `LeetCode.P1207.V1` | |
| `UniqueNumberOfOccurrencesV3.cs`, `.java` | `LeetCode.P1207.V3` | `leetcode.p1207.v3` |
| `UniqueNumberOfOccurrences.2026.cs`, `.java` | `LeetCode.P1207.V2026` | `leetcode.p1207.v2026` |

- C#: an MSBuild task in [`LeetCode.Solutions.csproj`](dotnet/LeetCode.Solutions/LeetCode.Solutions.csproj) adds the namespace and a `#line` directive, so compiler errors and stack traces point at the original file.
- Java: [`GenerateSources.java`](java/solutions/build/GenerateSources.java) adds the package and LeetCode's implicit imports on the original first line, so line numbers are preserved.

## Running tests

Requires the .NET 10 SDK and JDK 25.

```bash
dotnet test --solution LeetCode.slnx
```

```bash
cd java && ./mvnw verify
```

## Running benchmarks

```bash
dotnet run --configuration Release --project dotnet/LeetCode.Solutions.Benchmarks -- --filter '*P1207*'
```

```bash
cd java && ./mvnw --quiet package -DskipTests && java -jar benchmarks/target/benchmarks.jar P1207 -prof gc
```

Benchmarks do not run in CI, because shared runners produce noisy measurements. The results in each retrospective come from a single machine, which is listed next to them. Compare the ratios between versions, not the absolute values.

## Credits

The solutions have been coded using [Visual Studio Code](https://code.visualstudio.com/). The 2026 retrospectives, revisions, tests and benchmarks were written with [Claude Code](https://claude.com/claude-code).

## Terms

All trademarks, registered trademarks, service marks, product names, company names or logos are property of their respective owners and are used for educational purposes only.
