public class Solution {
    public void Rotate(int[] nums, int k) {
        for (int i = 0; i < k; i++) {
            for (int j = 0; j < nums.Length - 1; j++) {
                int temp = nums[j];
                nums[j] = nums[nums.Length -1];
                nums[nums.Length -1] = temp;
            }
        }
    }
}