public class NumMatrix {
    private int[][] map;

    public NumMatrix(int[][] matrix) {
        map = new int[matrix.Length][];

        for (int i = 0; i < matrix.Length; i++) {
            map[i] = new int[matrix[i].Length];
            map[i][0] = matrix[i][0];

            for (int j = 1; j < matrix[i].Length; j++) {
                map[i][j] = map[i][j - 1] + matrix[i][j];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int res = 0;
        
        while (row1 <= row2) {
            if (col1 > 0) {
                res += map[row1][col2] - map[row1][col1 - 1];
            } else {
                res += map[row1][col2];
            }
            row1++; 
        } 
        
        return res;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */