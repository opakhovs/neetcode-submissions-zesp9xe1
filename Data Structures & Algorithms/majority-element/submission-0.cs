public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int majority = nums.Length / 2;

        foreach ( int n in nums ) {
            if (map.ContainsKey(n)) {
                map[n]++;
            } else {
                map[n] = 1;
            }
            if (map[n] > majority) {
                return n;
            }
        }

        return -1;
    }
}