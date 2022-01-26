
class Solution:

    def longestCommonPrefix(self, strs: List[str]) -> str:
        minlen = min(strs, key= len);
        
        for i, ch in enumerate(minlen):
            for s in strs:
                if s[i] != ch:
                    return minlen[:i];
        return minlen;
