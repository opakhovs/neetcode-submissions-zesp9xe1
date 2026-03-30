public class Solution {
    public void SortColors(int[] nums) {
        int[] numsMap = new int[3];

        foreach (int n in nums) {
            numsMap[n]++;
        }

        int j = 0;
        for (int i = 0; i < 3; i++) {
            int k = 0;
            while (k++ < numsMap[i]) {
                nums[j++] = i;
            }
        }
    }
}