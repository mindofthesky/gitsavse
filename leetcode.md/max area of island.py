class Solution:
    def maxAreaOfIsland(self, grid: List[List[int]]) -> int:
        m, n = len(grid), len(grid[0]);
        
        def dfs(r,c):
            if 0 <= r < m and 0<=c<n and grid[r][c]==1:
                grid[r][c] = 0;
                return 1 + dfs(r+1,c) + dfs(r-1, c) + dfs(r,c+1) + dfs(r,c-1);
            else:
                return 0;
            
        out = 0;
        for r in range(m):
            for c in range(n):
                out = max(out,dfs(r,c));
        return out;
