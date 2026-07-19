public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxRight = -1;
        int temp = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            temp = arr[i];
            arr[i] = maxRight;

            maxRight = Math.Max(temp, maxRight);
        }
        return arr;
    }
}