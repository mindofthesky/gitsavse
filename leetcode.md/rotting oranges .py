class Solution:
    def orangesRotting(self, grid: List[List[int]]) -> int:
        q = deque();
        time , fresh  = 0 , 0 ;
        
        row, col = len(grid), len(grid[0]);
        for r in range(row):
            for c in range(col):
                if grid[r][c] == 1:
                    fresh += 1;
                if grid[r][c] == 2:
                    q.append([r,c]);
        drections = [[0,1], [0, -1], [1, 0], [-1,0]];
        while q and fresh > 0:
            for i in range(len(q)):
                r, c = q.popleft();
                for dr, dc in drections:
                    row1, col1 = dr + r, dc + c;
                    if (row1 < 0 or row1 == len(grid) or col1 < 0 or col1 == len(grid[0]) or grid[row1][col1] != 1):
                        continue;
                    grid[row1][col1] = 2;
                    q.append([row1,col1]);
                    fresh -= 1;
            time += 1;
        return time if fresh == 0 else -1;
