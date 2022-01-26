두수의 합값 



class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        # val  = 10 으로 넘어 갔을경우 앞자리에 1을 더해 주길위한 added 변수 
        added = ListNode(val = (l1.val + l2.val) % 10);
        carry_over = (l1.val + l2.val) //10;
        current_node = added;
        
        while(l1.next and l2.next):
            # 첫번째 원소를 불러오고 두번째 원소를 다불러 올때까지 연산을 시작 그리고 연산 을 하게 시작함 
            l1 = l1.next;
            l2 = l2.next;
            
            current_node.next = ListNode(val = (carry_over + l1.val + l2.val) % 10);
            carry_over = (carry_over + l1.val + l2.val) // 10;
            current_node = current_node.next;
            
        while(l1.next):
            l1 = l1.next;
            current_node.next = ListNode(val = (carry_over + l1.val) % 10)
            carry_over = (carry_over + l1.val + l2.val) //10;
            current_node = current_node.next;
            
        while(l2.next):
            l2 = l2.next;
            current_node.next = ListNode(val = (carry_over + l2.val) % 10);
            carry_over = (carry_over + l2.val) //10;
            current_node = current_node.next;
            
        if(carry_over) > 0:
            current_node.next = ListNode(val = 1);
            # 다음과 같이 모든 연산이 끝난경우 모든 합을 호출 
        return(added);

