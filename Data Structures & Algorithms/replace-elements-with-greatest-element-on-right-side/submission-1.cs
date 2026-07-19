public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxRight = arr[arr.Length - 1];

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

        arr[arr.Length - 1] = -1;

        return arr;
    }
}