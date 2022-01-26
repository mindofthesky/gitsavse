class Solution:

    def rotate(self, matrix: List[List[int]]) -> None:
        n = len(matrix[0]);
        # row i , col j
        for i in range(n):
            for j in range(i, n):
                matrix[j][i] , matrix[i][j] = matrix[i][j], matrix[j][i];
        for x in range(n):
            matrix[x].reverse();
