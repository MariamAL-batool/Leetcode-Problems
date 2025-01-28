public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int max = 0;
        int num = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }
            if (count > max)
            {
                max = count;
                num = nums[i];
            }

        }
        return num;
    }
}