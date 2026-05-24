public class Solution {
    
    public int OrangesRotting(int[][] grid) {

        int rows = grid.Length;
        int cols = grid[0].Length;

        // Directions: right, down, left, up
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };

        Queue<(int x, int y)> q = new Queue<(int, int)>();

        int fresh = 0;

        // Step 1: Count fresh oranges and add rotten oranges to queue
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {

                if (grid[i][j] == 1)
                    fresh++;

                else if (grid[i][j] == 2)
                    q.Enqueue((i, j));
            }
        }

        // No fresh oranges already
        if (fresh == 0)
            return 0;

        int minutes = 0;

        // Step 2: Multi-source BFS
        while (q.Count > 0) {

            int size = q.Count;
            bool infected = false;

            for (int i = 0; i < size; i++) {

                var (x, y) = q.Dequeue();

                // Check all 4 directions
                for (int d = 0; d < 4; d++) {

                    int nx = x + dx[d];
                    int ny = y + dy[d];

                    // Boundary check
                    if (nx < 0 || ny < 0 || nx >= rows || ny >= cols)
                        continue;

                    // Fresh orange becomes rotten
                    if (grid[nx][ny] == 1) {

                        grid[nx][ny] = 2;

                        fresh--;

                        q.Enqueue((nx, ny));

                        infected = true;
                    }
                }
            }

            // Increase time only if infection spread
            if (infected)
                minutes++;
        }

        // If fresh oranges still remain
        return fresh == 0 ? minutes : -1;
    }
}