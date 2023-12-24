namespace AlgoPractice.Strings;

public class ReverseInt
{
    public static int Run(int x)
    {
        if (x == int.MaxValue)
            return int.MinValue;

        char[] charArray = x.ToString().ToCharArray();
        char[] invertedChar = charArray.Reverse().ToArray();

        var prefix = charArray[0];
        if (!char.IsDigit(prefix))
        {
            return int.Parse($"{prefix}{new string(invertedChar.Take(invertedChar.Length - 1).ToArray())}");
        }

        return int.Parse(invertedChar);
    }
}
