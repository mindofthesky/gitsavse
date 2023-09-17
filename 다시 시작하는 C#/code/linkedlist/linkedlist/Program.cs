using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList listed = new LinkedList();
            listed.addhead(100);
            listed.addtail(500);
            listed.listPrint();
        }
    }
}
