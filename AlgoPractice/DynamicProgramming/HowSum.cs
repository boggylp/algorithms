namespace AlgoPractice.DynamicProgramming;

// Write a function canSum(targetSum, numbers) which should return a boolean array containing any combination
// of elements that add up to exactly the target sum. If no combo return null.
// canSum(7, [5, 3, 4, 7]) -> [3, 4]
// canSum(7, [2, 4]) -> null
public static class HowSum
{
    public static int[]? Run(int targetSum, int[] numbers)
    {
        return Run(targetSum, numbers, new Dictionary<int, List<int>?>())?.ToArray();
    }

    private static List<int>? Run(int targetSum, int[] numbers, Dictionary<int, List<int>?> memo)
    {
        if (memo.TryGetValue(targetSum, out var result))
            return result;
        if (targetSum == 0)
            return [];
        if (targetSum < 0)
            return null;

        foreach (var number in numbers)
        {
            var remainder = targetSum - number;
            var remainderResult = Run(remainder, numbers, memo);
            if (remainderResult != null)
            {
                memo[targetSum] = remainderResult.Append(number).ToList();
                return memo[targetSum];
            }
        }

        memo[targetSum] = null;
        return null;
    }
}
