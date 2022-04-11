class Solution:
    def shiftGrid(self, grid: List[List[int]], k: int) -> List[List[int]]:
        i, j = len(grid), len(grid[0]);
        
        def posval(a,b):
            return a * j + b;
        def valpos(x):
            return [x // j, x % j];
        
        res = [[0] * j for a1 in range(i)];
        for a in range(i):
            for b in range(j):
                newval = (posval(a,b) + k) % (i * j);
                newa,  newb = valpos(newval);
                res[newa][newb] = grid[a][b];
        return res;
                
