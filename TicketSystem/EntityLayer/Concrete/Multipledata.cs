using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Multipledata
    {
        public IEnumerable<employeeinfo> Employeeifo { get; set; }
        public IEnumerable<request> Request { get; set; }

        public IEnumerable<login> Login { get; set; }
    }
}
