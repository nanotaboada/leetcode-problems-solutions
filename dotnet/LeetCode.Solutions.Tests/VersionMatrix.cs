namespace LeetCode.Tests;

/// <summary>
/// Builds theory data that runs every test case against every version of a solution.
/// </summary>
internal static class VersionMatrix
{
    public static TheoryData<string, TInput, TExpected> Of<TInput, TExpected>(
        IEnumerable<string> versions,
        IEnumerable<(TInput Input, TExpected Expected)> cases)
    {
        var data = new TheoryData<string, TInput, TExpected>();
        foreach (var version in versions)
        {
            foreach (var (input, expected) in cases)
            {
                data.Add(version, input, expected);
            }
        }
        return data;
    }
}
