class Solution:
    def findLUSlength(self, strs: List[str]) -> int:
        def isSub(s,t):
            i = 0;
            if len(s) > len(t): return False;
            for c in t:
                if i<len(s) and c==s[i]: i+=1;
            return i == len(s);
        strs.sort(key=lambda x: -len(x));
        for i, word in enumerate(strs):
            found =True;
            for j in range(len(strs)):
                if i != j:
                    if isSub(word,strs[j]):
                        found =False;
                        break;
            if found: return len(word);
    
        return -1;
