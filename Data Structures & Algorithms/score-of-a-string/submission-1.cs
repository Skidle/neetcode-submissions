public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;

        for (int i = 0; i < s.Length; i ++) {
            if (i == s.Length - 1) {
                break;
            }

            int val1 = (int) s[i];
            int val2 = (int) s[i + 1];

            sum += Math.Abs(val1 - val2);
        }

        return sum;
    }
}