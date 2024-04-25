#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Apr 25 11:09:20 2024

@author: anhyeongjin
"""
import math
arrayA = [10, 20]
arrayB = [5, 20]	
# result = 0 
# [10, 20] A , [5,17] B > result 10
def solution(arrayA, arrayB):
    answer = 0
    # list > arrayA 정렬크기에 따라 다르기때문 
    # 재풀이 필요 
    arrayA = list(set(arrayA))
    len_arrayA = len(arrayA)
    gcdA = arrayA[0]
    
    if len_arrayA != 1:
        for i in range(1,len_arrayA):
            gcdA = math.gcd(gcdA, arrayA[i])
    print(math.gcd(gcdA, arrayA[i]))
    arrayB = list(set(arrayB))
    len_arrayB = len(arrayB)
    gcdB = arrayB[0]
    if len_arrayB != 1:
        for i in range(1,len_arrayB):
            gcdB = math.gcd(gcdB, arrayB[i])
    for i in arrayA:
        if i % gcdB == 0:
            # i 가 
            gcdB = 1    
            break
    
    for i in arrayB:
        if i % gcdA == 0:
            gcdA = 1
            break
    
    if gcdA == 1:
        if gcdB == 1:
            return 0
        else:
            return gcdB
    else:
        if gcdB == 1:
            return gcdA
        else:
            return max(gcdA, gcdB)
    answer = max(gcdA,gcdB)
    print(answer)
    return answer

solution(arrayA, arrayB)