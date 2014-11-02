using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testapp.Models;

namespace testapp.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            if (form.Username != "ayhan")
            {
                ModelState.AddModelError("Username","Username or password is not valid");
            }
            return Content("Form is Valid");
        }
    }
}