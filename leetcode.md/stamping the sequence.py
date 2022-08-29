class Solution:
    def movesToStamp(self, stamp: str, target: str) -> List[int]:
        N , M = len(target), len(stamp);
        out = [];
        
        move , maxmoves = 0 , 10*N;
        premove = 0;
        def check(src, trg):
            works= False;
            for i in range(M):
                if src[i] == trg[i]:
                    works = True;
                elif src[i] == "?":
                    continue;
                else:
                    return False;
            return works;
        while move < maxmoves:
            premove = move;
            for i in range(N-M+1):
                if check(target[i:i+M],stamp):
                    move +=1;
                    out.append(i);
                    target=target[:i] + "?"*M + target[i+M:];
                    if target == "?"*N:
                        return reversed(out);
            if premove == move:
                return[];
