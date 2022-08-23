class Solution:
    def countBinarySubstrings(self, s: str) -> int:
        
        n = len(s);
        pre , cur = 0,1;
        out = 0;
        
        for i in range(1, n):
            if s[i] != s[i-1]:
                out += min(cur, pre);
                pre = cur;
                cur = 1;
            else:
                cur +=1;
        return out + min(pre , cur);
