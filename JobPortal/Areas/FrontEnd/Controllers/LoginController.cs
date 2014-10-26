using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobPortal.Areas.FrontEnd.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }
    }
}