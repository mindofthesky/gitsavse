class Solution:

    def maximalRectangle(self, matrix: List[List[str]]) -> int: if(not matrix) : return 0

        for i in range(0, len(matrix)):
            for j in range(len(matrix[0])):
                if( matrix[i][j] == '1' ):
                    matrix[i][j] = int(matrix[i][j]) + int(matrix[i-1][j] if(i>0) else 0 )
                else:
                    matrix[i][j] = 0
        
        def findLargestArea(heights):
            if(not heights): return 0
            heights.append(0)
            stack = [-1]
            ans = 0
            for i in range(len(heights)):
                while( heights[i] < heights[stack[-1]] ):
                    h = heights[stack.pop()]
                    w = i - stack[-1] - 1
                    ans = max( ans, h*w )
                stack.append(i)
            return ans
            
        maxArea = 0
        for row in matrix:
            maxArea = max( maxArea, findLargestArea(row) )
        return maxArea        
