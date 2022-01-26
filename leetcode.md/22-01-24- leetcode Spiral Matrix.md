class Solution:

    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
        if not matrix: return [];
        row, row2, col, col2 =0, len(matrix) , 0 , len(matrix[0]);
        res = [];
        while row < row2 or col < col2 :
            if row< row2 : res.extend([matrix[row][i] for i in range(col, col2)])
            row += 1;
            
            if col < col2 : res.extend([matrix[i][col2 - 1] for i in range(row, row2) ])
            col2 -= 1;
            
            if row < row2 : res.extend([matrix[row2 - 1][i] for i in range(col2 -1, col-1, -1)])
            row2 -=1;
            
            if col < col2 : res.extend([matrix[i][col] for i in range(row2-1 , row-1, -1)])
            col += 1;
                
        return res;
