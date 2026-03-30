public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> seen = new HashSet<int>(nums1);
        List<int> res = new List<int>();

        foreach (int num in nums2) {
            if (seen.Contains(num)) {
                res.Add(num);
                seen.Remove(num);
            }
        }

        return res.ToArray();
    }
}