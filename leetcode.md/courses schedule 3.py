class Solution:
    def scheduleCourse(self, courses: List[List[int]]) -> int:
        courses.sort(key=lambda x:x[1]);
        p =[];
        time = 0;
        for i, j in courses:
            if time + i <= j:
                heapq.heappush(p,-i);
                time += i;
            elif p and -p[0] > i :
                time += i + heapq.heappop(p);
                heapq.heappush(p,-i);
        return len(p);
