class Solution:
    def candy(self, ratings: List[int]) -> int:
        n = len(ratings);
        o = [1 for _ in range(n)];
        
        for i in range(1,n):
            if ratings[i] > ratings[i-1]:
                o[i] = max(o[i-1]+1,o[i]);
        
        for i in range(n-2, -1, -1):
            if ratings[i] > ratings[i+1]:
                o[i] = max(o[i+1] + 1, o[i]);
        return sum(o);
