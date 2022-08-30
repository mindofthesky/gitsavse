class Solution:
    def partition(self, s: str) -> List[List[str]]:
        
        n = len(s);
        out = [];
        
        def dfs(st, sofar):
            if st == n:
                out.append(sofar);
                return
            
            for i in range(st, n):
                if s[st:i+1] == s[st:i+1][::-1]:
                    dfs(i+1,sofar+ [s[st:i+1]]);
        dfs(0,[]);
        
        return out;
