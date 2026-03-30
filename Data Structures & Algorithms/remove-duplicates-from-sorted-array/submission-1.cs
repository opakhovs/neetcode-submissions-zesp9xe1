public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int c = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[c] = nums[i];
                c++;
            }
        }

        return c;
    }
}