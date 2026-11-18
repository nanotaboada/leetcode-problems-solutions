using BenchmarkDotNet.Attributes;

namespace LeetCode.Benchmarks;

/// <summary>
/// <c>AllUnique</c> is the worst case: the answer is true, so every version must
/// count every value. <c>Random</c> repeats counts early, so versions that stop
/// at the first repeated count can return before building the whole set.
/// </summary>
[MemoryDiagnoser]
public class P1207UniqueNumberOfOccurrencesBenchmarks
{
    private int[] arr = [];

    [Params(1_000, 100_000)]
    public int Length { get; set; }

    [Params(Scenario.AllUnique, Scenario.Random)]
    public Scenario Input { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random(1207);
        arr = Input switch
        {
            Scenario.AllUnique => AllUnique(Length, random),
            _ => Enumerable.Range(0, Length).Select(_ => random.Next(-1000, 1001)).ToArray(),
        };
    }

    [Benchmark(Baseline = true)]
    public bool V1() => new P1207.V1.Solution().UniqueOccurrences(arr);

    [Benchmark]
    public bool V2() => new P1207.V2.Solution().UniqueOccurrences(arr);

    [Benchmark]
    public bool V3() => new P1207.V3.Solution().UniqueOccurrences(arr);

    [Benchmark]
    public bool V2026() => new P1207.V2026.Solution().UniqueOccurrences(arr);

    public enum Scenario
    {
        AllUnique,
        Random,
    }

    // Value k appears k times (1, 2, 2, 3, 3, 3, ...), shuffled.
    private static int[] AllUnique(int length, Random random)
    {
        var values = new List<int>(length);
        for (var value = 1; values.Count + value <= length; value++)
        {
            values.AddRange(Enumerable.Repeat(value, value));
        }
        var result = values.ToArray();
        random.Shuffle(result);
        return result;
    }
}
