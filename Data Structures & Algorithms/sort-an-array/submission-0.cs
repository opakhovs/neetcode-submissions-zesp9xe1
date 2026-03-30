public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] nums, int lIndex, int rIndex) {
        if (lIndex == rIndex) return;

        int mIndex = (lIndex + rIndex) / 2;
        MergeSort(nums, lIndex, mIndex);
        MergeSort(nums, mIndex + 1, rIndex);
        Merge(nums, lIndex, mIndex, rIndex);
    }

    private void Merge(int[] nums, int lIndex, int mIndex, int rIndex) {
        int[] left = nums[lIndex..(mIndex + 1)];
        int[] right = nums[(mIndex + 1)..(rIndex + 1)];

        int i = lIndex, j = 0, k = 0;

        while (j < left.Length && k < right.Length) {
            if (left[j] <= right[k]) {
                nums[i++] = left[j++];
            } else {
                nums[i++] = right[k++];
            }
        }

        while (j < left.Length) {
            nums[i++] = left[j++];
        }

        while (k < right.Length) {
            nums[i++] = right[k++];
        }
    }
}