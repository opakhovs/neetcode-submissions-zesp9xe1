public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> nums = new HashSet<int>();

        foreach (int a in nums1) {
            if (!nums.Contains(a)) {
                nums.Add(a);
            }
        }
        
        foreach (int a in nums2) {
            if (!nums.Contains(a)) {
                nums.Add(a);
            }
        }

        return nums.ToArray();
    }
}