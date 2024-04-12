# -*- coding: utf-8 -*-
"""
Created on Tue Apr  2 20:23:42 2024

@author: mindo
"""
id_list = ["muzi", "frodo", "apeach", "neo"]
report = ["muzi frodo","apeach frodo","frodo neo","muzi neo","apeach muzi"]	
k = 2  
# A이용자가 B를 신고 "muzi frodo" "a b" > 1번 
# A이용자가 같은 B 이용자를신고할수없다 4번을 신고하더라도 1번으로 
# 자기 자신은 자기를 신고할수없다 "muzi muzi" x 
# dict 형의 특징이지않을까? 
def solution(id_list, report, k):
    answer = []
    answer = [0] * len(id_list)
    # 0, 0, 0, 0 으로 변경함 
    print(answer)
    recode = {id: [] for id in id_list}
    # dict 데이터 선언 
    print("넣기전 데이터 ",recode) 
    # {'muzi': [], 'frodo': [], 'apeach': [], 'neo': []}
    # 확인결과 [0,0,0,0] 맞음 
    for i in set(report):
        i= i.split()
        recode[i[1]].append(i[0])
    print("처리후 ",recode)
    # dict_items([('muzi', ['apeach']), ('frodo', ['apeach', 'muzi']), ('apeach', []), ('neo', ['frodo', 'muzi'])])
    print(recode.items())
    # items 크기 만큼 값 처리 
    
    for a, b in recode.items():
        if len(b) >= k:
            for j in b:
                answer[id_list.index(j)] += 1
                # answer 에 index에 j값이 있으면 1추가 
    #for i in id_list:
    #    record[i] = [0,{}]
    #    for j in id_list:
    #        if i != j:
    #            record[i][1][j] = 0
    
    #for gift in report:
    #    a,b = gift.split()
    #    record[a][0] = 0
    #    record[a][1][b] = 0
    #    record[b][0] = 0
    #    record[b][1][a] = 0
    # 이렇게하면 예전에 가장 많이 받은 선물처럼 
    # 딕셔너리형을 완성할수있음 
    # 근데 문제는 이걸 어떻게 2번 신고를 받으면 터져야함 
    # 근데 이경우에서는 1번받에 신고를 받지못해서 메모리 낭비같음 
    #print(record)
    # 기각 처리 
    return answer

solution(id_list, report, k)