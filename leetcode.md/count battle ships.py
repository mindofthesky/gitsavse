class Solution:
    def countBattleships(self, board: List[List[str]]) -> int:
        ans = 0;
        m , n = len(board), len(board[0]);
        
        for i in range(m):
            for j in range(n):
                if board[i][j] == 'X':
                    if j > 0 and board[i][j-1] == 'X':
                        continue;
                        
                    if i > 0 and board[i-1][j] == 'X':
                        continue;
                    
                    if j == 0 or board[i][j-1] == '.':
                        ans += 1;
                    
                    elif i == 0 or board[i-1][j] == '.':
                        ans += 1;
        return ans;
