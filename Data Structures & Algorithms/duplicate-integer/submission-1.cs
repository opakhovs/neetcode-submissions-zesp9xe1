public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>();
        foreach (var num in nums) {
            if (!seen.Add(num)) return true;
        }
        return false;
    }
}