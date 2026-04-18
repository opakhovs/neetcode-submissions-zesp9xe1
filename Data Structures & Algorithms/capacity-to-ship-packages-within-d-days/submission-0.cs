public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = weights.Max();
        int r = weights.Sum();
        int res = r;

        bool CanShip(int cap) {
            int ships = 1;
            int currCap = cap;

            foreach (int w in weights) {
                if (currCap - w < 0) {
                    ships++;
                    if (ships > days) return false;
                    currCap = cap;
                }
                currCap -= w;
            }

            return true;
        }

        while (l <= r) {
            int cap = (l + r) / 2;
            if (CanShip(cap)) {
                res = Math.Min(res, cap);
                r = cap - 1;
            } else {
                l = cap + 1;
            }
        }

        return res;
    }
}