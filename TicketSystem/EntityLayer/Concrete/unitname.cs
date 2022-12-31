using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class unitname
    {
        public int UnitNameID { get; set; }
        public string UnitName { get; set; }

        public IList<employeeinfo> employeeinfos { get; set; }
    }
}
