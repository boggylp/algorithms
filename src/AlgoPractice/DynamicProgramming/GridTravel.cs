namespace AlgoPractice.DynamicProgramming;

// There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]).
// The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]).
// The robot can only move either down or right at any point in time.
// Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
// The test cases are generated so that the answer will be less than or equal to 2 * 109.
// Example 1
// Input: m = 3, n = 7
// Output: 28
// Example 2
// Input: m = 3, n = 2
// Output: 3
public static class GridTravel
{
    public static int UniquePaths(int m, int n)
    {
        if (m <= 0 || n <= 0)
            return 0;

        if (m == 1 || n == 1)
            return 1;

        var memo = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0)
                {
                    memo[i, j] = 1;
                }

                var current = memo[i, j];

                if (j + 1 < n)
                {
                    memo[i, j + 1] += current;
                }

                if (i + 1 < m)
                {
                    memo[i + 1, j] += current;
                }
            }
        }

        return memo[m - 1, n - 1];
    }
}
