public class Solution {
    public class Position {
    public int X { get; set; }
    public int Y { get; set; }
    
    public Position(int x, int y) {
        X = x;
        Y = y;
    }
}
    public int OrangesRotting(int[][] grid) {
        int c =0;
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };
        Queue<Position> q = new Queue<Position>();
        int ans=0;

        for(int i =0;i<grid.Length;i++){
            for(int j = 0;j<grid[0].Length;j++) 
            {
                if(grid[i][j] == 1) c++;
                else if(grid[i][j] == 2) q.Enqueue(new Position(i,j));
            }  
        }
        if(c==0) return  0;
        while (q.Count > 0) {
            int levelSize = q.Count;
            for (int i = 0; i < levelSize; i++) {
                Position current = q.Dequeue();
                
                for (int d = 0; d < 4; d++) {
                    int x = current.X + dx[d];
                    int y = current.Y + dy[d];
                    if (x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length) {
                        continue;
                    }
                    else {if (grid[x][y]==1){q.Enqueue(new Position(x, y)); grid[x][y] = 2;c--;}}
                }
                
            }
            ans++;
        }
        if(c==0) return ans-1;
        return -1;    
    }
}