def solution(users, emoticons):
    answer = [0,0]
    #[[40, 10000], [25, 10000]]	
    # user[i][0] = 비율 , user[i][1] = 가격 
    # 이상의 돈을 이모티콘 구매에 사용한다면 
    # 이모티콘 구매를 모두 취소하고 이모티콘 플러스 서비스에 가입한다는 의미입니다.
    
    # result[0] = 가입자 , result[1] = 이익(가입하지않은사람)
    # 30 40  
    # 할인률은 
    # user[1]<k<user[0] 값이될수있다
    # 할인률은 최소값보단 크거나 같아야한다 
    # 할인률의 최고는 제한이없다 
    # 할인률은 이모티콘에 따라 다르다
    sale =[]
    sale_emo = [10,20,30,40]
    # 할인률은 고정된 4개 
    answer_count =[0,0]
    print(users)
    def dfs(width, depth):
        if depth == len(width):
            sale.append(width[:])
            return
        for i in sale_emo:
            width[depth] += i 
            dfs(width, depth+1)
            width[depth] -= i
    dfs([0]* len(emoticons), 0)
    for i in range(len(sale)):
        plus_user =0
        profit = 0
        for user in users:
            emoticons_buy = 0
            for x in range(len(emoticons)):
                if sale[i][x] >= user[0]:
                    emoticons_buy += emoticons[x] * ((100 - sale[i][x]) / 100)
            if user[1] <= emoticons_buy:
                plus_user += 1
            else :
                profit += emoticons_buy
        if answer_count[0] < plus_user:
            answer_count = [plus_user, int(profit)]
        elif answer_count[0] == plus_user:
            if answer_count[1] < profit:
                answer_count = [plus_user, int(profit)]
    answer = answer_count
    return answer