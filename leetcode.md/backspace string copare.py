class Solution:
    def backspaceCompare(self, s: str, t: str) -> bool:
        res1, res2 = [],[];
        
        for char in s:
            if char == '#':
                if res1: res1.pop();
            else:
                res1.append(char);
        for char in t:
            if char == '#':
                if res2: res2.pop();
            else:
                res2.append(char);
        
        if res1 == res2:
            return True;
        else:
            return False;
        
