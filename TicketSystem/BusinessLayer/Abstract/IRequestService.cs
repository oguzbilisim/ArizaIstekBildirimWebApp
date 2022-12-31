using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRequestService
    {
        void AddEmployeeinfo(request employeeinfo);
        void DeleteEmployeeinfo(request employeeinfo);
        void UpdateEmployeeinfo(request employeeinfo);
        List<request> GetList();
        request GetById(int id);
    }
}
