using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWareManageMent.ManageMentAPI
{
    public interface IEntitiyPrimaryProperties
    {
        int id { get; set; }
        string name { get; set; }
        string Type { get; set; }
    }
}
