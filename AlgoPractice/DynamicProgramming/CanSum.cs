namespace AlgoPractice.DynamicProgramming;

// Write a function canSum(targetSum, numbers) which should return a boolean indicating whether or not it is possible
// to generate the targetSum using numbers from the array. All input numbers are non negative.
// canSum(7, [5, 3, 4, 7]) -> true
// canSum(7, [2, 4]) -> false
public static class CanSum
{
    public static bool Run(int targetSum, int[] numbers)
    {
        return Run(targetSum, numbers, new Dictionary<int, bool>());
    }

    private static bool Run(int targetSum, int[] numbers, Dictionary<int, bool> memo)
    {
        if (memo.TryGetValue(targetSum, out var result))
            return result;
        if (targetSum == 0)
            return true;
        if (targetSum < 0)
            return false;

        foreach (var number in numbers)
        {
            var remainder = targetSum - number;
            if (Run(remainder, numbers, memo))
            {
                memo[targetSum] = true;
                return true;
            }
        }

        memo[targetSum] = false;
        return false;
    }
}
