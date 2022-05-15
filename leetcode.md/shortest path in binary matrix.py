class Solution:
    def shortestPathBinaryMatrix(self, grid: List[List[int]]) -> int:
        m, n = len(grid), len(grid[0]);
        visited = set();
        q = deque();
        dirs = [(0,1),(0,-1),(1,0),(-1,0),(-1,-1),(1,1),(-1,1),(1,-1)];
        
        if grid[0][0] == 0:
            q.append((1,(0,0)));
            grid[0][0] = 1;
        
        while q:
            steps, tmp = q.popleft();
            r, c = tmp[0], tmp[1];
            if (r,c) == (m-1,n-1):
                return steps;
            for i,j in dirs:
                new_r, new_c = r + i , c + j;
                if 0 <= new_r < m and 0<=new_c< n and  grid[new_r][new_c] == 0 and (new_r,new_c) not in visited:
                    q.append((steps+1, (new_r,new_c)));
                    grid[new_r][new_c] =1;
        return -1;
    
