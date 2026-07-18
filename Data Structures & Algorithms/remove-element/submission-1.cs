public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int goodCount = 0;

        for (int i = 0; i <= nums.Length - 1; i++) {
            if (nums[i] != val) {
                nums[goodCount] = nums[i];
                goodCount++;
            }
        }

        return goodCount;
    }
}