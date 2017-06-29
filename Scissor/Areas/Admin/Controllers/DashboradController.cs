using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scissor.Areas.Admin.Controllers
{
    public class DashboradController : Controller
    {
        // GET: Admin/Dashborad
        public ActionResult Index()
        {
            return View();
        }
    }
}