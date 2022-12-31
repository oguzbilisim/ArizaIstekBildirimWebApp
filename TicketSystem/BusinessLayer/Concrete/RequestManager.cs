using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RequestManager : IRequestService
    {
        IRequestDal _requestDal;

        public RequestManager(IRequestDal requestDal)
        {
            _requestDal = requestDal;
        }

        public void AddEmployeeinfo(request request)
        {
            _requestDal.Insert(request);
        }

        public void DeleteEmployeeinfo(request request)
        {
            _requestDal.Delete(request);
        }

        public request GetById(int id)
        {
            return _requestDal.GetByID(id);
        }

        public List<request> GetList()
        {
            return _requestDal.GetListAll();
        }

        public void UpdateEmployeeinfo(request request)
        {
            _requestDal.Update(request);
        }
    }
}
