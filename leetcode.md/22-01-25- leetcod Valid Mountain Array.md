class Solution:

    def validMountainArray(self, arr: List[int]) -> bool:
        dec= False
        #edge cases
        if (len(arr)< 3): 
            return False
        if (arr[0]>arr[1]): 
            return False
        
        for i in range(len(arr)-1):
            if (not dec):
                if (arr[i]>=arr[i+1]):
                    dec = True
            if (dec and arr[i]<=arr[i+1]):
                return False
            
        return True if dec else False
