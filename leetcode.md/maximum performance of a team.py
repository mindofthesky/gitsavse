class Solution:
    def maxPerformance(self, n: int, speed: List[int], efficiency: List[int], k: int) -> int:
        tmp = zip(efficiency,speed);
        tmp = sorted(tmp);
        
        out = 0;
        h = [];
        sm = 0;
        for e in range(n-1, -1, -1):
            heappush(h, tmp[e][1]);
            sm += tmp[e][1];
            if len(h) > k:
                sm -= heappop(h);
            out = max(out, sm* tmp[e][0]);
        
        return out % (10**9 + 7);
