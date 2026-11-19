using AlgoPractice.DynamicProgramming;

namespace AlgoPracticeTest.DynamicProgramming;

public sealed class AllConstructTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void ValidHappyFlow(string target, string[] words, string[][] expectedResult)
    {
        var result = AllConstruct.Run(target, words);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<string, string[], string[][]> GetTestData() => new()
    {
        { "abcdef", ["ab", "abc", "cd", "def", "abcd", "ef", "c"], [["ab", "cd", "ef"], ["abcd", "ef"]] },
        { "", ["cat", "dog"], [[]] },
        { "birds", ["cat", "dog"], [] }
    };
}
