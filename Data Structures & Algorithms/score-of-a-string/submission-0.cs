public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;

        for (int i = 0; i < s.Length; i ++) {
            if (i == s.Length - 1) {
                // sum += (int) s[i];
                break;
            }

            int val1 = (int) s[i];
            int val2 = (int) s[i + 1];

            sum += Math.Abs(val1 - val2);

            Console.WriteLine($"char1: {s[i]}\t char2: {s[i + 1]}");
            Console.WriteLine($"val1: {val1}\t val2: {val2}");
            Console.WriteLine($"sum: {sum}");
        }

        return sum;
    }
}