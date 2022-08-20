class Solution:
    def minRefuelStops(self, target: int, startFuel: int, stations: List[List[int]]) -> int:
        
        h = [];
        out = 0;
        pre = 0;
        fuel = startFuel;
        for distance , gas in stations+[[target,0]]:
            fuel -= (distance - pre);
            while h and fuel < 0:
                fuel += -heappop(h);
                out += 1;
            if fuel < 0: return -1;
            heappush(h , -gas);
            pre = distance;
        return out;
