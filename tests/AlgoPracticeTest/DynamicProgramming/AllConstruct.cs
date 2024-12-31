using AlgoPractice.DynamicProgramming;
using System;
using System.Collections.Generic;

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

    public static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            "abcdef",
            new[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" },
            new[] { new[] { "ab", "cd", "ef" }, new[] { "abcd", "ef" } }
        ];

        yield return ["", new[] { "cat", "dog" }, new[] { Array.Empty<string>() }];

        yield return ["birds", new[] { "cat", "dog" }, Array.Empty<string>()];
    }
}
