class Solution:
    def hIndex(self, citations: List[int]) -> int:
        n = len(citations);
        tmp = [0 for _ in range(n+1)];
        for i, v in enumerate(citations):
            if v > n:
                tmp[n] += 1;
            else:
                tmp[v] += 1;
        total = 0;
        for i in range(n,-1,-1):
            total += tmp[i];
            if total >= i: return i;
