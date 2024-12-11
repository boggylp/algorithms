namespace AlgoPractice.Strings;

// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
//
// Example 1:
// Input: s = "leetcode"
// Output: 0
//
// Explanation:
// The character 'l' at index 0 is the first character that does not occur at any other index.
//
// Example 2:
// Input: s = "loveleetcode"
// Output: 2
//
// Example 3:
// Input: s = "aabb"
// Output: -1
//
//  
//
// Constraints:
//
// 1 <= s.length <= 105
// s consists of only lowercase English letters.
public static class FirstUniqueCharInString
{
    public static int Run(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (i != j && s[i] == s[j])
                {
                    break;
                }

                if (j == s.Length - 1)
                    return i;
            }
        }

        return -1;
    }
}
