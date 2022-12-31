using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeinfoManager : IEmployeeinfoService
    {
        IEmployeeinfoDal _employeeinfoDal;

        public EmployeeinfoManager(IEmployeeinfoDal employeeinfoDal)
        {
            _employeeinfoDal = employeeinfoDal;
        }

        public void AddEmployeeinfo(employeeinfo employeeinfo)
        {
            _employeeinfoDal.Insert(employeeinfo);
        }

        public void DeleteEmployeeinfo(employeeinfo employeeinfo)
        {
            _employeeinfoDal.Delete(employeeinfo);
        }

        public employeeinfo GetById(int id)
        {
            return _employeeinfoDal.GetByID(id);
        }

        public List<employeeinfo> GetList()
        {
            return _employeeinfoDal.GetListAll();
        }

        public List<employeeinfo> GetListWithEmployeeinfo()
        {
            return _employeeinfoDal.GetListWithEmployeeinfo();
        }

        public void UpdateEmployeeinfo(employeeinfo employeeinfo)
        {
            _employeeinfoDal.Update(employeeinfo);
        }
    }
}
