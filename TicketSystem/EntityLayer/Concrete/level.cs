using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class level
    {
        public int LevelID { get; set; }
        public string LevelName { get; set; }

        public IList<employeeinfo> employeeinfos { get; set; }
    }
}
