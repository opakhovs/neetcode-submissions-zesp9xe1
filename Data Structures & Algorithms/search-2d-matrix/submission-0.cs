public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int columns = matrix[0].Length;
        int n = matrix.Length * columns;

        int l = 0, r = n;

        while (l < r)
        {
            int mid = l + (r - l) / 2;
            int value = matrix[mid / columns][mid % columns];

            if (value <= target)
                l = mid + 1;
            else
                r = mid;
        }

        if (l == 0) return false;

        int index = l - 1;
        return matrix[index / columns][index % columns] == target;
    }
}