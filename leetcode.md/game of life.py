class Solution:
    def gameOfLife(self, board: List[List[int]]) -> None:
        """
        Do not return anything, modify board in-place instead.
        """
        m, n = len(board), len(board[0]);
        
        def helper(r,c):
            p = [(0,1),(0,-1),(1,0),(-1,0),(1,1),(1,-1),(-1,1),(-1,-1)];
            cnt = 0;
            for x,y in p:
                if 0 <= r+y < m and 0<= c+x < n and board[r+y][c+x] > 0:
                    cnt += 1;
            
            if board[r][c] > 0:
                if cnt < 2:
                    return 2;
                elif 2 <= cnt <= 3:
                    return 1;
                else:
                    return 2;
            else:
                if cnt == 3:
                    return -1;
                else:
                    return 0;
        
        for r in range(m):
            for c in range(n):
                board[r][c] = helper(r,c);
        
        for r in range(m):
            for c in range(n):
                if board[r][c] == 2:
                    board[r][c] = 0;
                elif board[r][c] == -1:
                    board[r][c] = 1
