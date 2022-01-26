class Solution:

    def totalNQueens(self, n: int) -> int:
        def backtrack(i):
            nonlocal ans;
            if i == n:
                ans += 1;
                return 
            
            for j in range(n):
                if not nq[j] and not pon[i+j] and not nit[i-j]:
                    nq[j] = True;
                    pon[i+j] = True;
                    nit[i-j] = True;
                    
                    backtrack(i+1);
                    
                    nq[j] = False;
                    pon[i+j] = False;
                    nit[i-j] = False;
                    
        nq = [False] * n;
        pon = defaultdict(bool);
        nit = defaultdict(bool);
        ans = 0;
        
        backtrack(0);
        
        return ans;
