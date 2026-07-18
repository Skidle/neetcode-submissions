public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int highestNumSeen = arr[arr.Length - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] < highestNumSeen){
                arr[i + 1] = arr[i];
                arr[i] = highestNumSeen;
            } else {
                highestNumSeen = arr[i];
            }
            Console.WriteLine($"highestNumSeen: {highestNumSeen}");
        }

        return arr;
    }
}