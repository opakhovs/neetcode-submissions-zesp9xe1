public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int i = 0, j = people.Length - 1;
        int res = 0;

        while (i <= j) {
            if (people[j] + people[i] <= limit) {
                i++;
            }
            res++;
            j--;
        }

        return res;
    }
}