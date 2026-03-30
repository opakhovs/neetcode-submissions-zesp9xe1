public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int[] row = new int[9];
        int[] column = new int[9];
        int[] square = new int[9];

        int tempValue;
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') continue;

                tempValue = board[i][j] - '1';

                if ((row[i] & (1 << tempValue)) > 0 || (column[j] & (1 << tempValue)) > 0 ||
                        (square[(i / 3) * 3 + (j / 3)] & (1 << tempValue)) > 0) {
                    return false;
                }

                row[i] |= (1 << tempValue);
                column[j] |= (1 << tempValue);
                square[(i / 3) * 3 + (j / 3)] |= (1 << tempValue);
            }
        }

        return true;
    }
}
