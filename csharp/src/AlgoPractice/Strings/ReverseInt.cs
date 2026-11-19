using System.Globalization;

namespace AlgoPractice.Strings;

public static class ReverseInt
{
    public static int Run(int x)
    {
        string str = new string(x.ToString(CultureInfo.InvariantCulture).Trim('-').Reverse().ToArray());
        bool tryInt32 = int.TryParse(str, out int intValue);
        return tryInt32
            ? x.ToString(CultureInfo.InvariantCulture).Contains('-')
                ? intValue * -1
                : intValue
            : 0;
    }
}
