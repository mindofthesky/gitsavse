class Solution:
    def numSubmatrixSumTarget(self, matrix: List[List[int]], target: int) -> int:
        n, m = len(matrix[0]), len(matrix);
        
        out = 0;
        
        for r in matrix:
            for i in range(1, len(r)):
                r[i] += r[i-1];
        
        for start in range(n):
            for end in range(start,n):
                lookup = defaultdict(int);
                cumsum = 0;
                lookup[0] = 1;
                for k in range(m):
                    cumsum += matrix[k][end] - (matrix[k][start-1] if start!=0 else 0);
                    if cumsum - target in lookup:
                        out += lookup[cumsum - target];
                    lookup[cumsum] +=1;
        return out;
