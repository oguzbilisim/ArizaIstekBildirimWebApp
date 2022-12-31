using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class title
    {
        public int TitleID { get; set; }
        public string TitleName { get; set; }

        public IList<employeeinfo> employeeinfos { get; set; }
    }
}
