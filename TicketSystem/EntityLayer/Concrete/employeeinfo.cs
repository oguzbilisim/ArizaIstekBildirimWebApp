using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class employeeinfo
    {
        public employeeinfo()
        {
            date = DateTime.Now;
        }

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string feedback { get; set; }
        public DateTime? date { get; set; }

        public int StatusID { get; set; }
        public status status { get; set; }

        public int UnitNameID { get; set; }
        public unitname unitname { get; set; }

        public int LevelID { get; set; }
        public level level { get; set; }

        public int titleID { get; set; }
        public title title { get; set; }

    }
}

