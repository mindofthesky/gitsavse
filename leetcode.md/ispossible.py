class Solution:
    def isPossible(self, target: List[int]) -> bool:
        
        if len(target) == 1:
            return target == [1];
        
        p =  [-num for num in target];
        heapq.heapify(p);
        total = sum(target);
        
        while -p[0] > 1:
            max1 = -heapq.heappop(p);
            remain = total - max1;
            
            if remain == 1:
                return True;
            
            pre = max1 % remain;
            
            if pre < 1 or pre == max1:
                return False;
            
            heapq.heappush(p,-pre);
            total += pre - max1;
            
        return True;
