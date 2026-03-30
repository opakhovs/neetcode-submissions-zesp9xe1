public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1) {
            return strs[0];
        }

        Array.Sort(strs);
        string first = strs[0];
        string last = strs[strs.Length - 1];

        int i = 0;
        while (i < Math.Min(first.Length, last.Length)) {
            if (first[i] != last[i]) {
                return first.Substring(0, i);
            }
            i++;
        }

        return first;
    }
}