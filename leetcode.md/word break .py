class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        d = set(wordDict);
        N = len(s);
        
        dp = [False for _ in range(N+1)];
        dp[0] = True;
        
        for start in range(N):
            if not dp[start] : continue;
            for end in range(start + 1 , N + 1):
                if s[start:end] in d: dp[end] =True;
        return dp[-1]
