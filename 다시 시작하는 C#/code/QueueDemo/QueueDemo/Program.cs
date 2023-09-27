using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class queue
    {
        public int[] a = new int[100];
        public int l = 0;
        public int m = 0;
        public int count()
        {
        return l - m;
        }
        public void Enqueue(int e)
        {
            int f = count();
            if (f == a.Length)
            {
                Console.WriteLine("큐 가득참");

            }
            else
            {
                a[l] = e;
                l++;
            }

        }
        public void Dequeue()
        {
            bool f = IsEmpty();
            if( f ==true )
            {
                Console.WriteLine("큐가 비어있습니다");
            }
            else
            {
                int e = top();
                m++;
                l--;
                Console.WriteLine(e +" 가 추가 되었습니다");
            }
        }
        public int top()
        {
            int e;
            e = a[m];
            a[m] = 0;
            return e;
        }
        public bool IsEmpty()
        {
            if (count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // 큐잉 구현부터

            queue q =new queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(35);
            q.Dequeue();
            q.Dequeue();
            q.Dequeue();
        }
        
    }
}
