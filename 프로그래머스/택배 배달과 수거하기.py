#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Apr 16 20:33:45 2024

@author: anhyeongjin
"""
cap = 4
n = 5
deliveries = [1, 0, 3, 1, 2]	
pickups = [0, 3, 0, 4, 0]	
# result = 14 
def solution(cap, n, deliveries, pickups):
    answer = 0
    # i번째 집은 물류창고에서 거리 i만큼 떨어져 있습니다. 
    # 또한 i번째 집은 j번째 집과 거리 j - i만큼 떨어져 있습니다.
    # (1 ≤ i ≤ j ≤ n) 트럭에는 재활용 택배 상자를 최대 cap 넣을수있음
    # 각 집 마다 빈활용들 수거해서 가지고감
    # 개수와 수거 할 빈 택배 상자의 개수를 알고 ㅣ있을때
    # 배달과 수거가 끝났을때 최소 이동거리 
    # 일단 답은 14 
    # 1/0 0/3 3/0 1/4 2/0
    # 5번째 이동ㅎ라면서 4번째 택배를 1개 배달 
    # 5번째에 2개 배달 
    deliveries.reverse()
    pickups.reverse()
    # 두 변수를 뒤에서부터 시작
    delivery = 0
    pickup = 0
    for i in range(n):
        delivery += deliveries[i]
        pickup += pickups[i]
        
        while delivery > 0 or pickup > 0 :
            delivery -= cap 
            pickup -= cap
            answer += n - i
    print(answer)
    return answer * 2
solution(cap, n, deliveries, pickups)