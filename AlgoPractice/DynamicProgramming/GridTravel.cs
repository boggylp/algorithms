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
    private record struct Point(int X, int Y);

    public static int UniquePaths(int m, int n)
    {
        return UniquePaths(m, n, new Dictionary<Point, int>());
    }

    private static int UniquePaths(int m, int n, Dictionary<Point, int> results)
    {
        if (m <= 0 || n <= 0)
            return 0;

        if (m == 1 || n == 1)
            return 1;

        var point = new Point(m, n);
        if (results.TryGetValue(point, out var result))
            return result;

        results[point] = UniquePaths(m - 1, n, results) + UniquePaths(m, n - 1, results);
        results[new Point(n, m)] = results[point]; // (m, n) = (n, m)

        return results[point];
    }
}
