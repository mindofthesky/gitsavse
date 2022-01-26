class Solution:
    def isMatch(self, s: str, p: str) -> bool:
        if s == p:
            return True

        match = []
        [match.append([False]*(len(s)+1)) for _ in range(len(p)+1)]
        match[0][0] = True
        for i in range(0, len(p)):
            c = p[i]
            if c == "*":
                match[i+1][0] = match[i][0]

        for i in range(len(p)):
            for j in range(len(s)):
                c1 = s[j]
                c2 = p[i]

                if c2 == "*":
                    match[i+1][j+1] = match[i][j] or match[i+1][j] or match[i][j+1]
                elif c2 == "?":
                    match[i+1][j+1] = match[i][j]
               
                else:
                    match[i+1][j+1] = match[i][j] and (c1 == c2)
        return match[len(p)][len(s)]
