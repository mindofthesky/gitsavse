class Solution:
    def transpose(self, matrix: List[List[int]]) -> List[List[int]]:
        row, col = len(matrix), len(matrix[0]);
        
        maxtrix1 = [[None] * row for _ in range(col)];
        
        for i in range(row):
            for j in range(col):
                maxtrix1[j][i] = matrix[i][j];
        return maxtrix1
