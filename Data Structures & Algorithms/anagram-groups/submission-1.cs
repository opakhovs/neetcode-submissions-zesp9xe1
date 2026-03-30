public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            int[] nums = new int[26];
            foreach (char c in s) {
                nums[c - 'a']++;
            }

            string key = string.Join(",", nums);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }

        return res.Values.ToList<List<string>>();
    }
}
