public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int a in nums) {
            if (!map.ContainsKey(a)) {
                map[a] = 0;
            }
            map[a]++;
        }

        return map
            .Where(x => x.Value > (nums.Length / 3))
            .Select(x => x.Key)
            .ToList();
    }
}