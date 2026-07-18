public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int valCount = 0;

        for (int i = 0; i <= nums.Length - 1; i++) {
            if (nums[i] == val) {

                if (i != nums.Length - 1) {
                    nums[i] = nums[i + 1];
                }

                valCount++;
            }
            Console.WriteLine(nums[i]);
        }

        Console.WriteLine($"valcount: {valCount}");

        return nums.Length - valCount;
    }
}