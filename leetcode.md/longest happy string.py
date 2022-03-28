class Solution:
    def longestDiverseString(self, a: int, b: int, c: int) -> str:
        res, maxhaep = "", [];
        for count , char in [(-a, "a"), (-b, "b"), (-c, "c")]:
            if count != 0:
                heapq.heappush(maxhaep, (count, char));
        
        while maxhaep:
            count, char = heapq.heappop(maxhaep);
            if len(res) > 1 and res[-1] == res[-2] == char:
                if not maxhaep:
                    break;
                count2, char2 = heapq.heappop(maxhaep);
                res += char2;
                count2 += 1;
                
                if count2:
                    heapq.heappush(maxhaep, (count2, char2));
            else:
                res += char;
                count += 1;
            if count:
                heapq.heappush(maxhaep, (count, char));
        return res;
