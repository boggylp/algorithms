namespace AlgoPractice.Strings;

public static class StrStr
{
    public static int Run(string haystack, string needle) => haystack.IndexOf(needle, StringComparison.Ordinal);
}
