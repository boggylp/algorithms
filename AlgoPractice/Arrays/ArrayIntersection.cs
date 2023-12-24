namespace AlgoPractice.Arrays;

public class ArrayIntersection
{
    /// <summary>
    /// Given two integer arrays nums1 and nums2, return an array of their intersection. 
    /// Each element in the result must appear as many times as it shows in both arrays 
    /// and you may return the result in any order.
    /// 
    /// Example 1:
    /// Input: nums1 = [1,2,2,1], nums2 = [2,2]
    /// Output: [2,2]
    /// 
    /// Example 2:
    /// Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
    /// Output: [4,9]
    /// Explanation: [9,4] is also accepted.
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0 || nums2.Length == 0)
            return null;

        var solution = new List<int>();

        var firstGroup = nums1.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var secondGroup = nums2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        firstGroup.Where(fg => secondGroup.ContainsKey(fg.Key)).ToList().ForEach(g =>
        {
            int count = Math.Min(g.Value, secondGroup[g.Key]);
            for (int i = 0; i < count; i++)
            {
                solution.Add(g.Key);
            }
        });

        return solution.ToArray();
    }
}
