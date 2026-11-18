# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

## [Unreleased]

### Added

- Build harness that compiles the original C# and Java solutions unchanged, adding a namespace or package per problem and version (#4)
- xUnit v3 and JUnit 6 test projects that run every case against every version of a solution (#4)
- BenchmarkDotNet and JMH benchmark projects that compare versions on identical inputs (#4)
- GitHub Actions build workflow and Dependabot configuration (#4)
- Review rubric for rating readability and maintainability alongside performance (#5)
- 2026 retrospective for 1207. Unique Number of Occurrences, with C# and Java 2026 versions, tests and benchmarks (#5)

### Fixed

- Missing closing braces in the C# solution for 0121. Best Time to Buy and Sell Stock (#4)
- Leftover draft lines in the C# V3 solution for 0380. Insert Delete GetRandom O(1) (#4)
