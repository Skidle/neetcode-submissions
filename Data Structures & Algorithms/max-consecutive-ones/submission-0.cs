public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int probableMaxConsecutiveOnes = 0;
        int finalMaxConsecutiveOnes = 0;

        for (int index = 0; index < nums.Length - 1; index++)
        {
            if (nums[index] == 1)
            {
                maxConsecutiveOnes++;
            }
            else
            {
                if (finalMaxConsecutiveOnes < probableMaxConsecutiveOnes)
                {
                    finalMaxConsecutiveOnes = probableMaxConsecutiveOnes;
                }
            }
        }

        return finalMaxConsecutiveOnes;
    }
}