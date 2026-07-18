public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int onesCount = 0;
        int result = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                onesCount++;
            }
            else
            {
                onesCount = 0;
            }

            result = Math.Max(onesCount, result);
        }

        return result;
    }
}