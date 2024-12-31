namespace AlgoPractice.Arrays;

public class PlusOneSolution
{
    /// <summary>
    /// You are given a large integer represented as an integer array digits,
    /// where each digits[i] is the ith digit of the integer.
    /// The digits are ordered from most significant to least significant in left-to-right order.
    /// The large integer does not contain any leading 0's.
    /// Increment the large integer by one and return the resulting array of digits.
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public static int[] PlusOne(int[] digits)
    {
        if (digits == null || digits.Length == 0)
            return Array.Empty<int>();

        var result = new List<int>();
        bool addedOne = false;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9 && !addedOne)
            {
                result.Add(0);
            }
            else if (!addedOne)
            {
                result.Add(digits[i] + 1);
                addedOne = true;
            }
            else
            {
                result.Add(digits[i]);
            }
        }

        if (!addedOne)
        {
            result.Add(1);
        }

        result.Reverse();
        return [.. result];
    }
}
