public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var columns = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int row = 0; row < 9; row++) {
            for (int column = 0; column < 9; column++) {
                char value = board[row][column];

                if (value == '.')
                    continue;

                int boxIndex = (row / 3) * 3 + (column / 3);

                if (rows[row].Contains(value) || columns[column].Contains(value) ||
                    boxes[boxIndex].Contains(value))
                    return false;

                rows[row].Add(value);
                columns[column].Add(value);
                boxes[boxIndex].Add(value);
            }
        }
        return true;
    }
}
