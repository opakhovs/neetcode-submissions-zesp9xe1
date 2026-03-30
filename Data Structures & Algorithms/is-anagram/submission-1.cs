public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var anagramMap = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            anagramMap[s[i]] = anagramMap.GetValueOrDefault(s[i], 0) + 1;
            anagramMap[t[i]] = anagramMap.GetValueOrDefault(t[i], 0) - 1;
        }
        
        foreach (KeyValuePair<char, int> ele in anagramMap) {
            if (ele.Value != 0) {
                return false;
            }
        }

        return true;
    }
}
