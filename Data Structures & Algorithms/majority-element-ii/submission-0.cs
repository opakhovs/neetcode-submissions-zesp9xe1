public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int, int> map = Dictionary<int, int>();

        foreach (int a in nums) {
            if (map.ContainsKey(a) != null) {
                map[a] = 0;
            }
            map[a]++;
        }

        return dict
            .Where(x => x.Value > (nums.Length / 3))
            .Select(x => x.Key)
            .ToList();
    }
}