class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        ran = sorted(list(ransomNote));
        mag = sorted(list(magazine));
        
        for char in mag :
            if ran and char == ran[0]:
                ran.pop(0);
        
        if ran:
            return False;
        else:
            return True;
