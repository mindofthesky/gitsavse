class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        row , col = len(matrix), len(matrix[0]);
        
        top, bot = 0 , row - 1;
        
        while top <=bot:
            row1 = (top + bot) // 2;
            if target > matrix[row1][-1]:
                top = row1 + 1;
            elif target < matrix[row1][0]:
                bot = row1 -1;
            else:
                break;
        
        if not (top <= bot):
            return False;
        row1 = (top + bot) //2;
        i,j = 0, col -1;
        while i <= j:
            x= (i + j) // 2;
            if target > matrix[row1][x]:
                i = x + 1;
            elif target < matrix[row1][x]:
                j = x - 1;
            else:
                return True;
            
        return False;
