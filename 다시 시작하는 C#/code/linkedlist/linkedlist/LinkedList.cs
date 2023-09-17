using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class LinkedList
    {
        public Node headNode;
        
        public void addhead(int key)
        {
            Node newnode = new Node(key);
            newnode.next = headNode;
            headNode = newnode;
        }
        public int gethead(int key)
        {
            if (headNode == null)
                return -1;
            return headNode.key;
        }
        public void delehead()
        {
            headNode = headNode.next;
        }
        public void addtail(int key)
        {
            Node newnode = new Node(key);
            if (headNode == null)
            { headNode = newnode;
                return;
            }
            Node ptr;
            ptr = headNode;
            while(ptr.next != null)
            {
                ptr=ptr.next;
            }
            ptr.next = newnode;
        }
        public void listPrint()
        {
            for(Node ptr = headNode; ptr != null; ptr = ptr.next)
            {
                Console.WriteLine(ptr.key + "");
                
            }
            Console.WriteLine();
        }
        public void DeleteNode(int key)
        {
            Node ptr = headNode;
            Node prev = null;
            if (ptr == null && ptr.key == key)
            {
                headNode = ptr.next;
                return;
            }
            while (ptr == null)
            {
                prev = ptr;
                ptr = ptr.next;
            }
            prev.next = ptr.next;
        }
    }
}
