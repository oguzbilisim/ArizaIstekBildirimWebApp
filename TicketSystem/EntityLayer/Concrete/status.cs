using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class status
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public IList<employeeinfo> employeeinfos { get; set; }
    }
}
