h1 = 0
m1 = 5
s1 = 30
h2 = 0
m2 = 7
s2 = 0
# result = 2

def solution(h1, m1, s1, h2, m2, s2):
    answer = -1
    # 결과값은 두번 실행됨
    # 왜 두번이지?
    # 초침이 이 시침이나 분침에 같은값이되면 알람
    # 6분에 한번 > 시침에서 만나기때문에
    # 6분 0.6초에 한번 > 분침이랑 만나기때문에 
    # 시침은 1분이상이라면 1번은 만남 
    # 분침도 움직이기때문에 한번은만날수있지만 초과하는경우 7분이후 초과된경우 세지못함
    return answer

solution(h1, m1, s1, h2, m2, s2)