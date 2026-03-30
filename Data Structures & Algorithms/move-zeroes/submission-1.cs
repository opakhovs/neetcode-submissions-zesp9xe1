public class Solution {
    public void MoveZeroes(int[] nums) {
        int l = 0, r = nums.Length - 1;

        while (l < r) {
            while (l < r && nums[l] != 0) {
                l++;
            }
            while (l < r && nums[r] == 0) {
                r--;;
            }
            if (l != r) {
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
            }
        }
    }
}