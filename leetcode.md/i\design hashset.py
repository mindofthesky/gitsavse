class MyHashSet:
    def __init__(self):
        self.has = []
    
    def add(self, key: int) -> None:
        if not self.contains(key):
            self.has.append(key)
    
    def remove(self, key: int) -> None:
        if self.contains(key):
            self.has.remove(key)
    
    def contains(self, key: int) -> bool:
        return key in self.has
