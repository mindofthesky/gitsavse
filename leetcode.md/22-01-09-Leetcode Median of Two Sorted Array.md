두수의 중간값 
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays
정렬되지 않은 두수에 대하여 두수의 중간값을 만들어라 
The overall run time complexity should be O(log (m+n)).
전체적인 시간복잡도는 O(log(m+n) 안에 있어야한다
class Solution:
    
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
       
        # 서로 값을 주는 a,b 를통해 변수를 보낸다 
        A, B = nums1, nums2;
        total = len(nums1) + len(nums2);
        # 토탈값은 len <- 리스트의 갯수를 들고오는 함수를 들고오고 두수의 리스트 값을 더한다 
        half = total //2;
        
        if len(B) < len(A):
            A, B = B, A;
        # 만약 비가 작다면 b < a  a = b , b= a로 변경 서로 값을 변경한다 
        l = 0;
        r = len(A) - 1;
        while True:
            i = (l + r) // 2;
            j = half - i - 2;
            
            Aleft = A[i] if i>= 0 
            else:
              float("-infinity"); 
            # 왼쪽과 중간값을 계산 할수 없기때문에 0 의 값을 가지는경우 음의 무한이 출력 
            Aright = A[i + 1] if (i + 1) < len(A) 
            else:
              float("infinity");
            # 오른쪽 값이 증가하나 len(n) 커질수 없기때문에 값을 무한으로 출력 
            Bleft = B[j] if j >= 0 
            else:
              float("-infinity");
            Bright = B[j + 1] if (j + 1) < len(B) 
            else: 
              float("infinity");         
            # else 절을 만나지 않는다면 바로 이쪽부터 호출 시작 
            if Aleft <= Bright and Bleft <= Aright:
                if total % 2:
                    return min(Aright, Bright);
                return (max(Aleft, Bleft) + min(Aright, Bright)) / 2;
                # 이쪽 구문이 결과값을 호출하는 부분이고 이하 아래경우는 값이 클경우 정렬하는데 들어가는 알고리즘이다 
            elif Aleft > Bright:
                r = i -1;
            else:
                l = i + 1;
