public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] a = new int[len * 2];

        for (int i = 0; i < len; i++) {
            a[i] = nums[i];
            a[(i + len)] = nums[i];
        }

        return a;
    }
}