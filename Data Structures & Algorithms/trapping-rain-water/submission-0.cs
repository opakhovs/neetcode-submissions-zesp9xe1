public class Solution {
    public int Trap(int[] height) {
        int i = 0, j = height.Length - 1;
        int l = 0, r = 0;
        int res = 0;

        while (i <= j) {
            if (l <= r) {
                if (height[i] > l) {
                    l = height[i];
                } else {
                    res += (l - height[i]);
                }
                i++;
            } else {
                if (height[j] > r) {
                    r = height[j];
                } else {
                    res += (r - height[j]);
                }
                j--;
            }
        }

        return res;
    }
}
