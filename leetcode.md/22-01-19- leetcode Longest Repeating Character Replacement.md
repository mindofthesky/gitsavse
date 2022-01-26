class Solution:

    def characterReplacement(self, s: str, k: int) -> int:
        left = right = 0;
        counters = collections.Counter();
        
        for right in range(1, len(s) + 1):
            counters[s[right - 1]]  += 1;
            max_char_n = counters.most_common(1)[0][1];
            
            if right - left - max_char_n > k:
                counters[s[left]] -= 1;
                left += 1;
        return right - left;
