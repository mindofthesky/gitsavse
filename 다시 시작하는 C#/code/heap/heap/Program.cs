using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heap
{
    public class heap
    {

        //version heap 1.0 s
        private List<int> list = new List<int>(); 

        

        public void Add(int x)
        {
            list.Add(x);

            int i = list.Count - 1;

            while(i > 0)
            {
                int parent = (i - 1) / 2;
                if (list[parent] < list[i])
                {
                    swap(parent, i);
                    i = parent;
                }
                else
                    break;
                
            }
        }
        public int remove()
        {

            int root = list[0];

            list[0] = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            int i = 0;
            int last = list.Count - 1;
            while( i< last)
            {
                int child = i * 2 + 1;

                if (child < last && list[child] < list[child + 1])
                    child = child + 1;
                if (child > last || list[i] > list[child])
                    break;

                swap(i, child);
                i = child;
            }

            return 0;
        }

        public void swap(int x, int y) 
        {
            int k = list[x];
            list[x] = list[y];
            list[y] = k;

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            heap heapa = new heap();
            
        }
    }
}
