namespace AlgoPractice.Strings;

public static class StringToInt
{
    public static int Run(string s)
    {
        int sign = 1, result = 0;
        if (s.Trim().Length == 0)
            return 0;

        var firstChar = s.Trim().First();
        if (firstChar == '-')
            sign = -1;

        foreach (var c in firstChar is '-' or '+' ? s.Trim().Skip(1) : s.Trim())
        {
            if (!char.IsDigit(c))
                break;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && c - '0' > (int.MaxValue % 10)))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + (c - '0');
        }

        return result * sign;
    }
}
