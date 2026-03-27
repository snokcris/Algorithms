namespace Algorithms.Arrays;

public class MaxSubarraySolver
{
    public int Solve(int[] nums)
    {
        int max = nums[0];
        int current = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            current = Math.Max(nums[i], current + nums[i]);
            max = Math.Max(max, current);
        }

        return max;
    }
}