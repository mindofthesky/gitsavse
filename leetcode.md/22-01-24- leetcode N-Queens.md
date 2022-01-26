class Solution:

    def solveNQueens(self, n: int) -> List[List[str]]:
        nq = set();
        pon = set();
        nit = set();
        
        res = [];
        board = [["."] * n for i in range(n)];
        
        def backtrack(r):
            if r == n:
                copy = ["".join(row) for row in board];
                res.append(copy);
                return;
            
            for c in range(n):
                if c in nq or (r + c) in pon or (r - c) in nit:
                    continue;
                    
                nq.add(c);
                pon.add(r+c);
                nit.add(r-c);
                board[r][c] = "Q";
                
                backtrack(r + 1);
                
                nq.remove(c);
                pon.remove(r+c);
                nit.remove(r-c);
                board[r][c] = ".";
                
        backtrack(0)
        return res;
                
