class Solution:

def setZeroes(self, matrix: List[List[int]]) -> None:
    """
    Do not return anything, modify matrix in-place instead.
    """
    column = False
    row1=False
    row = len(matrix)
    col = len(matrix[0])
    for i in range(row):
        if(matrix[i][0] == 0):
            column = True
    for i in range(col):
        if(matrix[0][i] == 0):
            row1 = True

    for i in range(1, row):
        for j in range(1, col):
            if(matrix[i][j] == 0):
                matrix[0][j] = 0
                matrix[i][0] = 0

    for i in range(1,col):
        if(matrix[0][i] == 0):
            for j in range(1,row):
                matrix[j][i] = 0

    for i in range(1,row):
        if(matrix[i][0] == 0):
            for j in range(1,col):
                matrix[i][j] = 0

    if(column == True):
        for i in range(row):
            matrix[i][0] = 0
    if(row1 == True):
        for i in range(col):
            matrix[0][i] = 0
    return matrix
