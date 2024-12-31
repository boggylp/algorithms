namespace AlgoPractice.DynamicProgramming;

// Find all of the ways to construct a word for given input
public static class AllConstruct
{
    public static string[][] Run(string target, string[] words)
    {
        if (string.IsNullOrEmpty(target))
        {
            return [[]];
        }

        var result = new string[target.Length + 1][][];
        result[0] = [[]];
        // Initialize each first-level element with an empty array
        for (int i = 1; i < result.Length; i++)
        {
            result[i] = [];
        }

        for (int i = 0; i < result.Length; i++)
        {
            foreach (var word in words)
            {
                var targetIndex = i + word.Length;
                if (targetIndex >= result.Length)
                    continue;
                if (target.Substring(i, word.Length) != word)
                    continue;
                var newCombinations = result[i].Select(subArray => subArray.Append(word).ToArray()).ToArray();
                result[targetIndex] = result[targetIndex].Concat(newCombinations).ToArray();
            }
        }

        return result[target.Length];
    }
}
