class Solution:
    def maxScore(self, cardPoints: List[int], k: int) -> int:
        n = len(cardPoints);
        m = n-k;
        total = sum(cardPoints);
        mn = s = sum(cardPoints[:m]);
        
        for i in range(k):
            s -= cardPoints[i];
            s += cardPoints[i+m];
            mn = min(mn, s);
            
        return total - mn;
