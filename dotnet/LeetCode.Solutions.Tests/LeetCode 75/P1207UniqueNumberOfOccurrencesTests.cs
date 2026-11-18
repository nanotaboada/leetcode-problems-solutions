namespace LeetCode.Tests;

public class P1207UniqueNumberOfOccurrencesTests
{
    private static readonly Dictionary<string, Func<int[], bool>> Versions = new()
    {
        ["V1"] = arr => new P1207.V1.Solution().UniqueOccurrences(arr),
        ["V2"] = arr => new P1207.V2.Solution().UniqueOccurrences(arr),
        ["V3"] = arr => new P1207.V3.Solution().UniqueOccurrences(arr),
        ["V2026"] = arr => new P1207.V2026.Solution().UniqueOccurrences(arr),
    };

    private static readonly (int[] Input, bool Expected)[] Cases =
    [
        ([1, 2, 2, 1, 1, 3], true),
        ([1, 2], false),
        ([-3, 0, 1, -3, 1, 1, 1, -3, 10, 0], true),
        ([7], true),
        ([5, 5, 5], true),
        ([1, 1, 2, 2], false),
        ([-1000, 1000, 1000], true),
        ([3, 1, 2, 2, 3, 3], true),
        ([1, 2, 3], false),
    ];

    public static TheoryData<string, int[], bool> Data => VersionMatrix.Of(Versions.Keys, Cases);

    [Theory]
    [MemberData(nameof(Data))]
    public void UniqueOccurrences_ReturnsWhetherAllCountsAreDistinct(string version, int[] arr, bool expected)
    {
        Assert.Equal(expected, Versions[version](arr));
    }
}
