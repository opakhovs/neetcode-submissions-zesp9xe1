public class NumMatrix {
    private int[][] prefixSum;

    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        prefixSum = new int[rows][];

        for (int i = 0; i < rows; i++) {
            prefixSum[i] = new int[cols];
            prefixSum[i][0] = matrix[i][0];
            for (int j = 1; j < cols; j++) {
                prefixSum[i][j] = prefixSum[i][j - 1] + matrix[i][j];
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        int res = 0;
        for (int row = row1; row <= row2; row++) {
            if (col1 > 0) {
                res += prefixSum[row][col2] - prefixSum[row][col1 - 1];
            } else {
                res += prefixSum[row][col2];
            }
        }
        return res;
    }
}