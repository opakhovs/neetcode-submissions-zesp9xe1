public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int c = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[c] = nums[i];
                c++;
            }
        }

        return c;
    }
}