public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0;
        string str = "";

        while (i < word1.Length || j < word2.Length) {
            if (i < word1.Length) {
                str += word1[i];
                i++;
            }
            if (j < word2.Length) {
                str += word2[j];
                j++;
            }
        }

        return str;
    }
}