namespace AlgoPractice.Strings;

public class ReverseString
{
    public static void Run(char[] characters)
    {
        int j = characters.Length - 1;
        for (int i = 0; i == j; i++)
        {
            (characters[j], characters[i]) = (characters[i], characters[j]);
        }
    }
}
