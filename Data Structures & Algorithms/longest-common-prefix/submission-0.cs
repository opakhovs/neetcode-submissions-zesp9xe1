public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        string res = "";
        int numOfWords = strs.Length;

        for (int i = 0; i < strs[0].Length && i < strs[numOfWords - 1].Length; i++) {
            if (strs[0][i] != strs[numOfWords - 1][i]) {
                return res;
            }
            res += strs[0][i];
        }

        return res;
    }
}