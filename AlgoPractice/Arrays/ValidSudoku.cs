namespace AlgoPractice.Arrays;

public class ValidSudoku
{

    /// <summary>
    /// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
    /// Each row must contain the digits 1-9 without repetition.
    /// Each column must contain the digits 1-9 without repetition.
    /// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    /// 
    /// Note:
    /// A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    /// Only the filled cells need to be validated according to the mentioned rules.
    /// Constraints:
    /// board.length == 9
    /// board[i].length == 9
    /// board[i][j] is a digit 1-9 or '.'.
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public bool IsValidSudoku(char[][] board)
    {
        if (board == null || board.Length != 9)
            return false;

        var columns = new HashSet<char>[board.Length];
        var boxes = new HashSet<char>[board.Length];
        for (int i = 0; i < columns.Length; i++)
        {
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < board.Length; i++)
        {
            var row = new HashSet<char>();
            for (int j = 0; j < board[i].Length; j++)
            {
                char digit = board[i][j];
                if (digit == '.')
                    continue;

                int boxIndex = GetBoxIndex(i, j);
                if (boxes[boxIndex].Contains(digit))
                {
                    return false;
                }
                else
                {
                    boxes[boxIndex].Add(digit);
                }
                if (columns[j].Contains(digit))
                {
                    return false;
                }
                else
                {
                    columns[j].Add(digit);
                }
                if (row.Contains(digit))
                {
                    return false;
                }
                else
                {
                    row.Add(digit);
                }
            }
        }

        return true;
    }

    private int GetBoxIndex(int i, int j)
    {
        bool firstRow = i >= 0 && i < 3;
        bool secondRow = i >= 3 && i < 6;
        bool thirdRow = i >= 6 && i < 9;

        bool firstColumn = j >= 0 && j < 3;
        bool secondColumn = j >= 3 && j < 6;
        bool thirdColumn = j >= 6 && j < 9;

        if (firstRow && firstColumn)
            return 0;
        if (firstRow && secondColumn)
            return 1;
        if (firstRow && thirdColumn)
            return 2;
        if (secondRow && firstColumn)
            return 3;
        if (secondRow && secondColumn)
            return 4;
        if (secondRow && thirdColumn)
            return 5;
        if (thirdRow && firstColumn)
            return 6;
        if (thirdRow && secondColumn)
            return 7;
        if (thirdRow && thirdColumn)
            return 8;

        return 0;
    }
}

