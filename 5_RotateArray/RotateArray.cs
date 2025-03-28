public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int length = nums.Length;
        for (int i = 0; i < k; i++)
        {
            int lastNum = nums[length - 1];
            for (int j = length - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];
            }
            nums[0] = lastNum;
        }
    }
}