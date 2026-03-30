public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length - 1;
        int res = 0;

        while (i < j) {
            int h = Math.Min(heights[i], heights[j]);
            int width = j - i;
            res = Math.Max(res, h * width);

            if (heights[i] < heights[j]) {
                i++;
            } else {
                j--;
            }
        }

        return res;
    }
}