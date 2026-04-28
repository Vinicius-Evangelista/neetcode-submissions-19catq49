public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        for(int i = 0; i < 9; i++)
        {
            var seen = new HashSet<char>();

            for(int row = 0; row < 9; row++)
            {
                if (board[row][i] == '.') continue;
                if (!seen.Add(board[row][i])) return false;
            }
        }


        for(int i = 0; i < 9; i++)
        {
            var seen = new HashSet<char>();

            for(int col = 0; col < 9; col++)
            {
                if (board[i][col] == '.') continue;
                if (!seen.Add(board[i][col])) return false;
            }
        }


        for(int square = 0; square < 9; square++)
        {
            var seen = new HashSet<char>();

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {   
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;

                    if (board[row][col] == '.') continue;
                    if (!seen.Add(board[row][col])) return false;
                }
            }
        }

        return true;
    }
}
