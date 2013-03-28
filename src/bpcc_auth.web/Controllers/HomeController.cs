using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bpcc_auth.web.Filters;

namespace bpcc_auth.web.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        
        [Authorize(Roles="ScheduleWriter, Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [Authorize(Roles = "ScheduleWriter")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
