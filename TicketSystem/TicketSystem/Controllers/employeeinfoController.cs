using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;

namespace TicketSystem.Controllers
{
    public class employeeinfoController : Controller
    {
        Context c = new Context();

        EmployeeinfoManager em = new EmployeeinfoManager(new EfEmployeeinfoRepository());

  
        public IActionResult Index()
        {
            var values = new Multipledata();

            values.Employeeifo = em.GetListWithEmployeeinfo();
            values.Request = c.requests.ToList();

            //  var user = c.logins.Where(u => u.LoginID.Equals(Convert.ToInt32(User.Identity.Name))).FirstOrDefault();

            //var username = user.LoginUserName;
            //var id = user.LoginID;
            //var role = user.LoginRole;


            //ViewBag.name = username;
            //ViewBag.id = id;
            //ViewBag.role = role;

            var name = User.Identity.Name;
            ViewBag.name2 = name;

           // var user = c.Users.Where(x => x.UserName == name).Select(y => y.Id).FirstOrDefault();

            

            return View(values);
        }

        [HttpGet]
        public IActionResult AddInfo()
        {

            List<SelectListItem> statusvalues = (from x in c.statuss.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.StatusName,
                                                     Value = x.StatusID.ToString()
                                                 }).ToList();
            ViewBag.dgr = statusvalues;


            List<SelectListItem> unitvalues = (from x in c.unitnames.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.UnitName,
                                                   Value = x.UnitNameID.ToString()
                                               }).ToList();
            ViewBag.vls2 = unitvalues;


            List<SelectListItem> levelvalues = (from x in c.levels.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.LevelName,
                                                    Value = x.LevelID.ToString()
                                                }).ToList();
            ViewBag.vls3 = levelvalues;


            List<SelectListItem> titlevalues = (from x in c.titles.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.TitleName,
                                                    Value = x.TitleID.ToString()
                                                }).ToList();
            ViewBag.vls4 = titlevalues;

            var values = new Multipledata();

            values.Employeeifo = em.GetListWithEmployeeinfo();
            values.Request = c.requests.ToList();
            //var user = c.logins.Where(u => u.LoginID.Equals(Convert.ToInt32(User.Identity.Name))).FirstOrDefault();

            //var username = user.LoginUserName;
            //var id = user.LoginID;
            //var role = user.LoginRole;


            //ViewBag.name = username;
            //ViewBag.id = id;
            //ViewBag.role = role;


            return View(values);
        }

        [HttpPost]
        public IActionResult AddInfo(employeeinfo d)
        {
            EmployeeinfoValidator ev = new EmployeeinfoValidator();
            ValidationResult results = ev.Validate(d);

            
                var per = c.statuss.Where(x => x.StatusID == d.status.StatusID).FirstOrDefault();
                d.status = per;

                var per2 = c.unitnames.Where(y => y.UnitNameID == d.unitname.UnitNameID).FirstOrDefault();
                d.unitname = per2;

                var per3 = c.levels.Where(y => y.LevelID == d.level.LevelID).FirstOrDefault();
                d.level = per3;

                var per4 = c.titles.Where(y => y.TitleID == d.title.TitleID).FirstOrDefault();
                d.title = per4;

            //var per5 = c.logins.Where(y => y.LoginID == Convert.ToInt32(User.Identity.Name)).FirstOrDefault();
            //d.login = per5;

            //d.name = per5.LoginUserName;

            c.employeeinfos.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

            //if (results.IsValid)
            //{

            //}
            //else
            //{
            //    foreach(var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return View();

        }
    }
}
