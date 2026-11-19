namespace AlgoPractice.DynamicProgramming;

// Write a function canSum(targetSum, numbers) which should return a boolean array containing any combination
// of elements that add up to exactly the target sum. If no combo return null.
// canSum(7, [5, 3, 4, 7]) -> [3, 4]
// canSum(7, [2, 4]) -> null
public static class HowSum
{
    public static int[]? Run(int targetSum, int[] numbers)
    {
        var result = new int[targetSum + 1][];
        result[0] = [];

        for (int i = 0; i <= targetSum; i++)
        {
            if (result[i] is null)
                continue;
            foreach (var number in numbers)
            {
                var targetIndex = i + number;
                if (targetIndex <= targetSum)
                {
                    result[targetIndex] = result[i].Append(number).ToArray();
                }
            }
        }

        return result[targetSum];
    }
}
