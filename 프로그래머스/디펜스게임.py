#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Apr 26 16:39:43 2024

@author: anhyeongjin
"""
n = 7
k = 3
#enemy = [4,4,4,4]
enemy = [4, 2, 4, 5, 3, 3, 1]
def solution(n, k, enemy):
    answer = 0
    fight = []
    for i in range(len(enemy)-k):
        for j in range(len(enemy)-k):
            if enemy[i]+enemy[j] == n:
                fight+=[i,j]
                break
    # 배열만큼 무적권 !! 
    # k를 쓰는 조건이 뭘까? 
    # 7을 만드는 조건이 가능한걸 찾아야한다 
    
    print(fight)
    # 소트를 하지않는다 
    for i in enemy:
        # k 로 넘어가면서 무조건 0으로남을수있는구간까지 가야한다 
        n -= i
        if n > 0:
            answer+=1
        else:
            break
    answer += k
    if len(enemy) < answer:
        answer = len(enemy)
    print(answer)
    # 이렇게짜면 최대한 못감 
    # 딱 0 되는 부분까지는 써야한다 
    return answer

solution(n, k, enemy)