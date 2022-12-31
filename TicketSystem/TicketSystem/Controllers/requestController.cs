using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Controllers
{
    public class requestController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInfo(request d)
        {
            RequestValidator ev = new RequestValidator();
            ValidationResult results = ev.Validate(d);

            if (results.IsValid)
            {
                c.requests.Add(d);
                c.SaveChanges();
                return RedirectToAction("Index", "employeeinfo");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }

        public IActionResult DeleteInfo(int id)
        {
            var dep = c.requests.Find(id);
            c.requests.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index", "administrator");
        }
    }
}
