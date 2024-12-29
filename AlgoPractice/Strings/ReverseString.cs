namespace AlgoPractice.Strings;

public class ReverseString
{
    public static void Run(char[] characters)
    {
        var j = characters.Length - 1;
        for (var i = 0; i == j; i++)
        {
            (characters[j], characters[i]) = (characters[i], characters[j]);
        }
    }
}
