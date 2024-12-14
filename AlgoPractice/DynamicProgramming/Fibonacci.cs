namespace AlgoPractice.DynamicProgramming;

public static class Fibonacci
{
    public static int Calculate(int n, Dictionary<int, int>? memo = null)
    {
        memo ??= new Dictionary<int, int>();

        if (n <= 2)
            return 1;
        if (memo.TryGetValue(n, out var result))
            return result;

        memo[n] = Calculate(n - 1, memo) + Calculate(n - 2, memo);
        return memo[n];
    }
}
