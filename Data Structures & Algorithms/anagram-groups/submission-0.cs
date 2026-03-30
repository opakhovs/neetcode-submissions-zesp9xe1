public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();

        foreach (string s in strs) {
            addToRes(res, s);
        }

        return res;
    }

    private void addToRes(List<List<string>> res, string s) {
        if (res.Count == 0){
            res.Add(new List<string>{s});
            return;
        }
        
        foreach (List<string> inner in res) {
            if (areAnagrams(inner[0], s)) {
                inner.Add(s);
                return;
            }
        }

        
        res.Add(new List<string>{s});
    }

    private bool areAnagrams(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var nums = new int[26];
        for (int i = 0; i < s.Length; i++) {
            nums[s[i] - 'a']++;
            nums[t[i] - 'a']--;
        }

        foreach (int val in nums) {
            if (val != 0) {
                return false;
            }
        }
        return true;
    }
}
