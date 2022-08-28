class Solution:
    def diagonalSort(self, mat: List[List[int]]) -> List[List[int]]:
        M , N = len(mat), len(mat[0]);
        new_mat = defaultdict(list);
        
        for row in range(M):
            for col in range(N):
                heappush(new_mat[row-col] , mat[row][col]);
        
        for row in range(M):
            for col in range(N):
                mat[row][col] = heappop(new_mat[row-col]);
        
        return mat;
