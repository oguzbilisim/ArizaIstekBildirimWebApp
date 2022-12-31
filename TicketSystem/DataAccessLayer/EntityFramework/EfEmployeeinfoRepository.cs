using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfEmployeeinfoRepository : GenericRepository<employeeinfo>, IEmployeeinfoDal
    {
        public List<employeeinfo> GetListWithEmployeeinfo()
        {

            using (var c =new Context())
            {
                return c.employeeinfos
                    .Include(x => x.status)
                    .Include(y => y.unitname)
                    .Include(Z => Z.level)
                    .Include(a => a.title).ToList();
            }
        }



    }
}
