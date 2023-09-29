using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        delegate int addint(int x, int y);
        static void Main(string[] args)
        {
            // 람다의 장점이 함수를 직접호출 안해도된다는건데 

            addint addints = (x, y) => x + y;
            int result = addints(1, 2);
            Console.WriteLine(result);

            // 이걸 활용을하면 

            // 오늘은 추석이니 대충 람다식 쓴걸로하고 
            //내일은 linq 람다식...
        }
    }
}
