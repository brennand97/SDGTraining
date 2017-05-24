using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopleProTraining.Dal.Models;

namespace PeopleProTraining.Controllers
{
    public class AjaxController : Controller
    {
        private PeopleProTraining.Dal.Infrastructure.PeopleProContext db =
            new Dal.Infrastructure.PeopleProContext();
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List(string table)
        {
            switch(table)
            {
                case "departments":
                    return Json(db.Departments.ToList(), JsonRequestBehavior.AllowGet);
                case "employees":
                    return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
                case "buildings":
                    return Json(db.Buildings.ToList(), JsonRequestBehavior.AllowGet);
                default:
                    return Json(new { success = false, responseText = "The table cannot be found/is not supported." }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult AddDepartment(Department dept)
        {
            var obj = Json(db.Departments.Add(dept), JsonRequestBehavior.AllowGet);
            db.SaveChanges();
            return obj;
        }
    }
}