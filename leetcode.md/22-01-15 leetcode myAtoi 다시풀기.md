

class Solution:

    def myAtoi(self, s: str) -> int:
        sen = s.lstrip()
        sen = sen.split(' ')
        MAX_NUM = 2**31-1
        MIN_NUM = -2**31
        number_list = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9']
               
        numchar = sen[0]
        if len(numchar) > 0:
            end = 0
            if numchar[0] in number_list + ['-', '+']:
                condition = True
                end += 1
                while condition and end < len(numchar):
                    if numchar[end] in number_list:
                        condition = True
                        end += 1
                    else:
                        condition = False

                try:
                    if int(numchar[:end])<MIN_NUM:
                        return MIN_NUM
                    elif int(numchar[:end])>MAX_NUM:
                        return MAX_NUM
                    else:
                        return int(numchar[:end])
                except:
                    return 0
            else:
                return 0
        else:
            return 0       
            
            
            이문제는 좀 그냥 따라한 문제인데
            try 구문을 안쓰고 할수있는 문제가 분명한데도 나는왜 이새끼가 트라이와 리턴을 여기서 많이섰는지가 이해가 되지않음
            
            다른 문제 풀이를 보고 생각이 필요함 
