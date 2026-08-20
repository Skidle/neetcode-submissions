public class Solution {
    public int MissingNumber(int[] nums) {
        int result = 0;

        Array.Sort(nums);

        foreach (var num in nums) {
            if (num == result) {
                result++;
            }
        }

        return result;
    }
}
