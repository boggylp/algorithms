namespace AlgoPractice.Strings;

public static class LongestCommonPrefix
{
    public static string Run(string[] strs)
    {
        string result = "";
        if (strs.Length == 0)
            return result;
        if (strs.Length == 1)
            return strs[0];

        for (int i = 1; i <= strs[0].Length; i++)
        {
            string candidate = strs[0][..i];
            foreach (var word in strs.Skip(1))
            {
                if (word.Length < candidate.Length || !word.StartsWith(candidate))
                {
                    return result;
                }
            }
            result = candidate;
        }

        return result;
    }
}
