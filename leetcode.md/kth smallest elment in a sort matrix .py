class Solution:
    def kthSmallest(self, matrix: List[List[int]], k: int) -> int:
        l, r, n = matrix[0][0] , matrix[-1][-1], len(matrix);
        
        def lees_k(m):
            count = 0;
            for r in range(n):
                x = bisect_right(matrix[r],m);
                count += x;
            return count;
    
        while l < r:
            mid = (l+r)//2;
            if lees_k(mid) < k:
                l = mid +1;
            else:
                r = mid;
        return l;
