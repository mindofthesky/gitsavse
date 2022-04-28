class Solution:
    def minimumEffortPath(self, heights: List[List[int]]) -> int:
        m, n = len(heights), len(heights[0]);
        dirs = [(1,0),(-1,0),(0,1),(0,-1)];
        out = 0;
        heap = [(0,0,0)];
        visited = set();
        while heap:
            k,x,y = heappop(heap);
            out = max(out, k);
            
            if (x,y) == (m-1, n-1):
                return out;
            visited.add((x,y))
            for dx, dy in dirs:
                new_x, new_y = x+dx, y+dy;
                if 0<=new_x<m and 0<=new_y<n and (new_x,new_y) not in visited:
                    new_k = abs(heights[x][y]- heights[new_x][new_y]);
                    heappush(heap,(new_k,new_x,new_y));
        return -1;
