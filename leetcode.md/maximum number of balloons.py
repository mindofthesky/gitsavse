class Solution:
    def maxNumberOfBalloons(self, text: str) -> int:
        count = Counter(text);
        balloon = Counter("balloon");
        
        res = len(text);
        for i in balloon:
            res = min(res, count[i] // balloon[i]);
        return res;
