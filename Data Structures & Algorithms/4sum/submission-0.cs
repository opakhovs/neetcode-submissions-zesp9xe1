public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();

        int l = 0, r = nums.Length - 1;
        bool a = false;
        while (l + 1 < r - 1) {
            int l1 = l + 1, r1 = r - 1;
            while (l1 < r1) {
                if ((nums[l] + nums[l1] + nums[r1] + nums[r]) == target) {
                    res.Add(new List<int> { nums[l], nums[l1], nums[r1], nums[r] });
                    l1++;
                    r1--;
                    while (l1 < r1 && nums[l1] == nums[l1 - 1]) {
                        l1++; 
                    } 
                    while (l1 < r1 && nums[r1] == nums[r1 + 1]) { 
                        r1--;
                    }
                } else if (nums[l] + nums[l1] + nums[r1] + nums[r] > target) {
                    r1--;
                } else {
                    l1++;
                }
            }
            if (a) {
                l++;
                a = false;
                while (l < r && nums[l] == nums[l - 1]) l++;
            } else {
                r--;
                a = true;
                while (l < r && nums[r] == nums[r + 1]) r--;
            }
        }

        return res;
    }
}