public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int l = 0, r = n - 1, resIndex = n - 1;

        while (l <= r) {
            if (Math.Abs(nums[l]) > Math.Abs(nums[r])) {
                res[resIndex] = nums[l] * nums[l];
                l++;
            } else {
                res[resIndex] = nums[r] * nums[r];
                r--;
            }
            resIndex--;
        }

        return res;
    }
}