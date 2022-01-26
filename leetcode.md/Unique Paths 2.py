class Solution:
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        n,m = len(obstacleGrid[0]) , len(obstacleGrid);
        dp = [[0 for _ in range(n)] for _ in range(m)]
        
        for c in range(n):
            if obstacleGrid[0][c] ==1 : break;
            dp[0][c]=1;
            
        for r in range(m):
            if obstacleGrid[r][0] == 1: break;
            dp[r][0] =1
            
        for r in range(1,m):
            for c in range(1,n):
                if obstacleGrid[r][c] == 1:continue;
                dp[r][c] = dp[r-1][c]+dp[r][c-1];
        
        return dp[-1][-1]
