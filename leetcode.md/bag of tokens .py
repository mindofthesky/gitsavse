class Solution:
    def bagOfTokensScore(self, tokens: List[int], P: int) -> int:
        q =deque(sorted(tokens));
        
        score = 0;
        max_score = 0;
        
        while q:
            if P >= q[0]:
                t = q.popleft();
                P -= t;
                score += 1;
                max_score = max(score, max_score);
            elif score > 0 :
                t = q.pop();
                P += t;
                score -= 1;
            else:
                break;
        return max_score;
