public class Solution {

    public List<(int row, int col)> directions = new () {(-1, 0), (1, 0), (0, -1), (0,1)};  
    public HashSet<(int row, int col)> visited = new ();

    public int NumIslands(char[][] grid) 
    {
        var ROW = grid.Length;
        var COL = grid[0].Length;
        var count = 0;

        for(int r = 0; r < ROW; r++)
        {
            for(int c = 0; c < COL; c++)
            {
                if (grid[r][c] == '1' && !visited.Contains((r, c)))
                {
                    Dfs(grid, r, c);
                    count += 1;
                }
            }
        }

        return count;
    }

    public void Dfs(char[][] grid, int r, int c) {
        
        foreach(var dir in directions)
        {
            var nbd = (r: 0, c: 0);
            nbd.r = r + dir.row;
            nbd.c = c + dir.col;

            if ((nbd.r >= 0 && nbd.r < grid.Length) && (nbd.c >= 0 && nbd.c < grid[0].Length) &&
                (grid[nbd.r][nbd.c] != '0') && visited.Add((nbd.r, nbd.c)))
                Dfs(grid, nbd.r, nbd.c);
        }
    }
}
