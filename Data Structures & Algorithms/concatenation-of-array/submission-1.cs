public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int numsLength = nums.Length;

        int[] ans = new int[numsLength * 2];

        int j = nums.Length;

        for (int i = 0; i < numsLength; i++)
        {
            ans[i] = nums[i];
            ans[j] = nums[i];
            j++;
        }

        return ans;
    }
}