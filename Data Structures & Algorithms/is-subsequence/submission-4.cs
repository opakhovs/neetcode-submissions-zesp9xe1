public class Solution {
    public bool IsSubsequence(string s, string t) {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        foreach (char c in s) {
            if (dic.ContainsKey(c)) {
                dic[c] += 1;
            } else {
                dic[c] = 1;
            }
        }

        foreach (char c in t) {
            if (dic.ContainsKey(c)) {
                dic[c] -= 1;
            }
        }

        foreach (KeyValuePair<string, string> entry in dic)
        {
            if (entry.Value > 0) {
                return false;
            }
        }

        return true;
    }
}