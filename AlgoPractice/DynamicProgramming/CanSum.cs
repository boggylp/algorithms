namespace AlgoPractice.DynamicProgramming;

// Write a function canSum(targetSum, numbers) which should return a boolean indicating whether or not it is possible
// to generate the targetSum using numbers from the array. All input numbers are non negative.
// canSum(7, [5, 3, 4, 7]) -> true
// canSum(7, [2, 4]) -> false
public static class CanSum
{
    public static bool Run(int targetSum, int[] numbers)
    {
        var result = new bool[targetSum + 1];
        result[0] = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (!result[i])
                continue;

            foreach (var number in numbers)
            {
                var targetIndex = i + number;
                if (targetIndex < result.Length)
                {
                    result[targetIndex] = true;
                }
            }
        }

        return result[targetSum];
    }
}
