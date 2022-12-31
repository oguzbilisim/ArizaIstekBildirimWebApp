using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Controllers
{
    public class administratorController : Controller
    {
        Context c = new Context();

        EmployeeinfoManager em = new EmployeeinfoManager(new EfEmployeeinfoRepository());

        public IActionResult Index()
        {
            var values = new Multipledata();

            values.Employeeifo = em.GetListWithEmployeeinfo();
            values.Request = c.requests.ToList();

            //var user = c.logins.Where(u => u.LoginID.Equals(Convert.ToInt32(User.Identity.Name))).FirstOrDefault();
            //var username = user.LoginUserName;
            //ViewBag.name = username;

            return View(values);
        }

        public IActionResult DeleteInfo(int id)
        {
            var dep = c.employeeinfos.Find(id);
            c.employeeinfos.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetInfo(int id, int statusid)
        {
            List<SelectListItem> values = (from x in c.statuss.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.StatusName,
                                               Value = x.StatusID.ToString()
                                           }).ToList();
            ViewBag.dgr = values;


            var perso = c.employeeinfos.Find(id);
            return View("GetInfo", perso);
        }

        public IActionResult UpdateInfo(employeeinfo d)
        {

          var dep = c.employeeinfos.Find(d.id);



            dep.StatusID = d.StatusID;

            dep.feedback = d.feedback;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
