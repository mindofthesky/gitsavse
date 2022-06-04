class Solution:
    def findCheapestPrice(self, n: int, flights: List[List[int]], src: int, dst: int, k: int) -> int:
        pri = [float("inf")] * n ;
        pri[src] = 0;
        
        for i in range(k + 1):
            tmppri = pri.copy();
            for s, d , p in flights:
                if pri[s] == float("inf"):
                    continue;
                if pri[s] + p  < tmppri[d]:
                    tmppri[d] = pri[s] + p;
            pri = tmppri;
        return -1 if pri[dst] == float("inf") else pri[dst];
