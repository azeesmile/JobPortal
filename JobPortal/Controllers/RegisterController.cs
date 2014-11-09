using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobPortal.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        [AllowAnonymous]
        public ActionResult Employee()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Recruiter()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult EmployeeAcademic()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult EmployeeProfessional()
        {
            return View();
        }
	}
}