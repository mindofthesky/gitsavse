

class Solution:
    
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        cur = sumnode = ListNode();
        while list1 and list2:
            if list1.val > list2.val:
                cur.next = list2;
                list2 = list2.next;
            else:
                cur.next = list1;
                list1 = list1.next;
            cur = cur.next;
        
        if not list1:
            cur.next = list2;
        else:
            cur.next = list1;
        return sumnode.next;
