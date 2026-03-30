public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            res[i] = nums[i] * nums[i];
        }
        Array.Sort(res);

        return res;
    }
}