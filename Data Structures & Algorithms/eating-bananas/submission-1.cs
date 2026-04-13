public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int l = 1, r = piles[0];

        foreach (int a in piles)
        {
            if (a > r)
            {
                r = a;
            }
        }

        while (l < r)
        {
            int steps = 0;
            int mid = l + (r - l) / 2;

            foreach (int val in piles)
            {
                steps += val / mid + (val % mid > 0 ? 1 : 0);
            }

            if (steps <= h)
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }

        return l;
    }
}