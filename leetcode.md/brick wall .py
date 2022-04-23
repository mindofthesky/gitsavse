class Solution:
    def leastBricks(self, wall: List[List[int]]) -> int:
        count = { 0 : 0 };
        
        for i in wall:
            total = 0;
            for j in i[:-1]:
                total += j;
                count[total] = 1 + count.get(total, 0);
        return len(wall) - max(count.values());
