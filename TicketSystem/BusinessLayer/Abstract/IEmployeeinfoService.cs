using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEmployeeinfoService
    {
        void AddEmployeeinfo(employeeinfo employeeinfo);
        void DeleteEmployeeinfo(employeeinfo employeeinfo);
        void UpdateEmployeeinfo(employeeinfo employeeinfo);
        List<employeeinfo> GetList();
        employeeinfo GetById(int id);

        List<employeeinfo> GetListWithEmployeeinfo();
    }
}
