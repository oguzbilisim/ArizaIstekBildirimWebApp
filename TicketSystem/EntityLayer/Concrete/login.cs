using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class login
    {
        [Key]
        public int LoginID { get; set; }

        [StringLength(50)]
        public string LoginUserName { get; set; }

        [StringLength(50)]
        public string LoginPassword { get; set; }

        [StringLength(1)]
        public string LoginRole { get; set; }


    }
}
