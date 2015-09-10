using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazingMail.Web.Areas.About.Controllers
{
    public partial class AboutController : Controller
    {
        // GET: About/About
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}