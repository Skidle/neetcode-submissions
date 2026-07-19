public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxRight = -1;
        int temp = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            temp = arr[i];
            arr[i] = maxRight;

            if (temp > maxRight)
            {
                maxRight = temp;
            }
        }
        return arr;
    }
}