public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++) {
            int diff = target - numbers[i];

            if (map.ContainsKey(diff)) {
                return new int[] {map[diff] + 1, i + 1};
            }
            if (!map.ContainsKey(numbers[i])) {
                map[numbers[i]] = i;
            }
        }

        return null;
    }
}
