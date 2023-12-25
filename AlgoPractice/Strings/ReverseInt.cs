namespace AlgoPractice.Strings;

public class ReverseInt
{
    public static int Run(int x)
    {
        string str = new string(x.ToString().Trim('-').Reverse().ToArray());
        bool tryInt32 = int.TryParse(str, out int intValue);
        return tryInt32
            ? x.ToString().Contains('-')
                ? intValue * -1
                : intValue
            : 0;
    }
}
