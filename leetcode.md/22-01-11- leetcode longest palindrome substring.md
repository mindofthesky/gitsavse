가장 긴 팬린드롬 부분 문자열 문제 

아문제는 데이터를 얼마나 잘 아껴쓰는가 문제이기도한데

사실 실무에서 쓰지않는 퍼즐 문제와가깝다 

C#을 쓸때도 중첩함수를 첨부하지 않지만 여기 경우는 expand() 함수는 이미 이전에 정의된 함수를 호출하여 메모리를 절약하는 기법이다 단 const 같은 변수는 수정이 불가능하고 부모 변수만 불러 올수있지만
가변 변수형인 경우 데이터값을 수정하면 부모 데이터 까지 변경되기때문에 주의를 해야될것같다 



class Solution:
    
    def longestPalindrome(self, s: str) -> str:
        def expand(left: int, right: int) -> str:
            while left >= 0 and right <len(s) and s[left] == s[right]:
                left -= 1;
                right += 1;
            return s[left +1 : right];
        
        if len(s) < 2 or s == s[::-1]:
            return s;
        result = '';
        
        for i in range(len(s) -1):
            result = max(result, expand(i, i + 1), expand(i, i + 2), key = len);
            
        return result;
        
