namespace AlgoPractice.Strings;

public static class StrStr
{
    public static int Run(string haystack, string needle) => haystack.Contains(needle) ? haystack.IndexOf(needle) : -1;
}
