using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class AllConstructTest
{
    [Test]
    [MethodDataSource(nameof(GetTestData))]
    public async Task ValidHappyFlow(string target, string[] words, string[][] expectedResult)
    {
        var result = AllConstruct.Run(target, words);
        await Assert.That(result).IsEquivalentTo(expectedResult);
    }

    public static IEnumerable<Func<(string, string[], string[][])>> GetTestData()
    {
        yield return () =>
            (
                "abcdef",
                ["ab", "abc", "cd", "def", "abcd", "ef", "c"],
                [
                    ["ab", "cd", "ef"],
                    ["ab", "c", "def"],
                    ["abc", "def"],
                    ["abcd", "ef"],
                ]
            );
        yield return () =>
            (
                "",
                ["cat", "dog"],
                [
                    [],
                ]
            );
        yield return () => ("birds", ["cat", "dog"], []);
    }
}
