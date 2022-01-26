class Solution:

    def maxCoins(self, nums: List[int]) -> int:
        nums = [1] + nums + [1];
        n = len(nums);
        dp = [[0 for i in range(n)]for i in range(n)]     ;   
        
        for i in range(1, n-1): 
            dp[i][i] = nums[i-1] * nums[i] * nums[i+1];
        
        for L in range(2, n-1): 
            for i in range(1, n-L):
                j = i + L-1;
                dp[i][j] = float('-inf');
                for k in range(i, j+1):
                    dp[i][j] = max(dp[i][j], dp[i][k-1]+dp[k+1][j]+ nums[i-1]*nums[k]*nums[j+1]);
        
        return dp[1][n-2];
