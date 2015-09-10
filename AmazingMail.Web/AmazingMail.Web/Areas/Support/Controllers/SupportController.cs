using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazingMail.Web.Areas.Support.Controllers
{
    public partial class SupportController : Controller
    {
        // GET: Support/Support
        public virtual ActionResult Index()
        {
            return View();
        }
        public virtual ActionResult Support()
        {
            return View();
        }
        public virtual ActionResult Contact()
        {
            return View();
        }
        public virtual ActionResult FAQ()
        {
            return View();
        }
        public virtual ActionResult Samples()
        {
            return View();
        }
        public virtual ActionResult Tips()
        {
            return View();
        }
    }
}