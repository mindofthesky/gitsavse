Given a string s, find the length of the longest substring without repeating characters.
 String 의값 s를 주어졌을때, 가장긴 문장의 수를 값을 구하라.




class Solution:
    
    def lengthOfLongestSubstring(self, s: str) -> int:
        # 기초 변수 설정
        sub = {};
        cur_sub_start = 0;
        cur_len = 0;
        longest = 0;
        # 가장긴 값을 주어주는 이유는 다른 큰값이 정해졌을경우 값을 변환하기 위해 변수를 지정 
        for i, letter in enumerate(s):
            #같은 값인경우 count를 넣지않음 다른 값일때 +=1 
            #같은 값인 경우 값유지 letter는 abcabcbb로 하나하나 호출값을 리스트로 받아있는 값 
            if letter in sub and sub[letter] >= cur_sub_start:
                cur_sub_start = sub[letter] + 1;
                cur_len = i - sub[letter];
                sub[letter] = i;
                
                
            else:
                sub[letter] = i;
                cur_len += 1;
                if cur_len >longest:
                    longest = cur_len;
        
        return(longest);
