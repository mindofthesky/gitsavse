 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
            object[] arr = new object[] { new MySort { Id = 400, Name= "linked"}, new MySort { Id =1, Name= "Bubble"}, new MySort { Id =5 , Name= "Stack"}, new MySort { Id = 7 , Name= "Queue"}

                                                                            };
            //int i = 0;  
            SortArray<MySort> sort = new SortArray<MySort>();
            sort.BubbleSort(arr);

            foreach(var item in arr)
                Console.WriteLine(item);
        Console.ReadKey();
        }
    }
    public class SortArray<T> where T : IComparable
    {
        public void BubbleSort(T[] arr)
        {
            int n  = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n -i - 1; j++)
                {
                    if (((IComparable)arr[j]).CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(arr, j);
                    }
                }
            }
        }

        

        private void Swap(T[] arr, int j)
        {
            T temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j+1]  = temp;
        }
    }

    public class MySort : IComparable
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CompareTo(object obj)
        {
            return this.Id.CompareTo(((MySort)obj).Id);

        }
    }
    /*public override string ToString()
    {
        return $"{Id},{nameo}";
    }*/
}
