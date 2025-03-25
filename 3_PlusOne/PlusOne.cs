public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int length = digits.length;
        for (int i = length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }
        int[] digits2 = new int[length + 1];
        digits2[0] = 1;
        return digits2;

    }
}