public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        long[] bits = new long[(n + 63) / 64];

        // Mark numbers from 1..n
        for (int i = 0; i < n; i++) {
            if (nums[i] >= 1 && nums[i] <= n) {
                int x = nums[i] - 1; // map 1 -> bit 0
                bits[x / 64] |= 1L << (x % 64);
            }
        }

        // Find first missing
        for (int i = 0; i < n; i++) {
            if ((bits[i / 64] & (1L << (i % 64))) == 0) {
                return i + 1;
            }
        }

        return n + 1;
    }
}