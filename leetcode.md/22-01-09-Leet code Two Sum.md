categories:
  -leetcode
  
원문

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
주어진 행렬과 값으로 타겟값을 만들어 내라 
You may assume that each input would have exactly one solution, and you may not use the same element twice.
단 각각의 숫자는 한번 사용할 수있고 같은 값은 두번이상 들어갈수없다 
You can return the answer in any order.
문제의 답을 답하라 순서대로 

배열의 숫자들을 잡게되어 타겟값이 되는경우 값이 나오는 함수 
단 같은 숫자는 두번 넣을수 없다 

가능한 모든 횟수를 시도해야 하나 같은 값을 두번 이상 호출해선 안된다 
[2,2] target -> 4인 경우는 두번 호출 할수있으나 같은 위치의 값을 불러오는것은 아니기때문에 조건에서는 위반되지 않는다.
[2] target -> 4 인경우는 같은 값을 호출할수 없기에 False 값으로 답이 나올수 없다. 

eunmerate 목록화 함수로 원소의 값과 목록값을 둘다 호출하는 함수 



class Solution:

    def twoSum(self, nums: List[int], target: int) -> List[int]:
        nums_map = {}
        # i 와 num 에 값이 같은 값으로 호출 i값은 num 의값으로 호출 num = 0 i = 0  같은 값 위치로 저장  
        for i, num in enumerate(nums):
            nums_map[num] = i
        # 현재 모든 변수의 값과 Num = i 값은 같다    

        # 타겟에서 첫 번째 수를 뺀 결과를 키로 조회
        for i, num in enumerate(nums):
            if target - num in nums_map and i != nums_map[target - num]:
                return [i, nums_map[target - num]]
        # 타겟값과 첫번째 값으로 값을 가지고 있기때문에 0 이되면 덧셈값이 맞기때문에 결과로 호출 
