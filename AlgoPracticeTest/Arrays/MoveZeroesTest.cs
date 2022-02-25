using Xunit;
using AlgoPractice.Arrays;
using System;

namespace AlgoPracticeTest.Arrays;

public class MoveZeroesTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    public void TestMoveZeroes(int[] nums, int[] expectedResult)
    {
        var sln = new MoveZeroesSolution();
        sln.MoveZeroes(nums);
        Assert.Equal(expectedResult, nums);
    }
}