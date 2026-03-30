public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nums1_len = m + n;

        while (n > 0) {
            if (m > 0 && nums1[m - 1] > nums2[n - 1]) {
                nums1[--nums1_len] = nums1[--m];
            } else {
                nums1[--nums1_len] = nums2[--n];
            }
        }
    }
}