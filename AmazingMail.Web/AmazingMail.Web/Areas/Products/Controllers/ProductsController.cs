using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazingMail.Web.Areas.Products.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostCards()
        {
            return View();
        }
        public ActionResult FoldedCards()
        {
            return View();
        }
        public ActionResult CardsInEnvelopes()
        {
            return View();
        }
        public ActionResult Brochures()
        {
            return View();
        }
        public ActionResult Letters()
        {
            return View();
        }
        public ActionResult Flyers()
        {
            return View();
        }
        public ActionResult BusinessCards()
        {
            return View();
        }
        public ActionResult PopOutAndPerforated()
        {
            return View();
        }
        public ActionResult ScratchOff()
        {
            return View();
        }
        public ActionResult Magnets()
        {
            return View();
        }
    }
}