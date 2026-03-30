public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int res = 0;

        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = (map.ContainsKey(num - 1) ? map[num - 1] : 0) + 
                            (map.ContainsKey(num + 1) ? map[num + 1] : 0) + 1;

                map[map.ContainsKey(num - 1) ? num - map[num - 1] : num] = map[num];
                map[map.ContainsKey(num + 1) ? num + map[num + 1] : num] = map[num];

                res = Math.Max(res, map[num]);
            }
        }

        return res;
    }
}
