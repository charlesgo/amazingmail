using AmazingMail.Web.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace AmazingMail.Web.Areas.Gallery.Controllers
{
    //[RouteArea("Tempaltes")] dont know y d fuck doesnt work;
    [RoutePrefix("templates")]
    public class GalleryController : Controller
    {

        [Route("business-cards")]
        public virtual ActionResult Index(int? CategoryID)
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/acting-modeling")]
        public virtual ActionResult ActingModeling(int? CategoryID)
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/automotive")]
        public ActionResult Automotive()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/dental")]
        public ActionResult Dental()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/education")]
        public ActionResult Education()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/financial")]
        public ActionResult Financial()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/florist")]
        public ActionResult Florist()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/nonprofit")]
        public ActionResult NonProfit()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/real-estate")]
        public ActionResult RealEstate()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/religious-organizations")]
        public ActionResult ReligiousOrganizations()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/recruiting")]
        public ActionResult Recruiting()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/seminars-events")]
        public ActionResult SeminarEvents()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/veterinary")]
        public ActionResult Veterinary()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }

        [Route("business-cards/birthdays")]
        public ActionResult BirthDays()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/calendars")]
        public ActionResult Calendars()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/cartoons")]
        public ActionResult Cartoons()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/congratulations")]
        public ActionResult Congratulations()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/just-moved")]
        public ActionResult JustMoved()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/thank-you")]
        public ActionResult ThankYou()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/tradeshows-promotions")]
        public ActionResult TradeShowsPromotions()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/photo-cards")]
        public ActionResult PhotoCards()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/traditional-cards")]
        public ActionResult TraditionalCards()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/party-invitations")]
        public ActionResult PartyInvitations()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/christmas")]
        public ActionResult Christmas()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/hanukkah")]
        public ActionResult Hanukkah()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }
        [Route("business-cards/new-years")]
        public ActionResult NewYears()
        {
            return View("~/Areas/Gallery/Views/Gallery/Index.cshtml"); //?? this hsould be automatic if the area is fix
        }



        public virtual ActionResult GreetingCards()
        {
            return View();
        }
        public virtual ActionResult Category()
        {
            return PartialView("_CategoryDisplay");
        }

        //public async Task<ActionResult> Category(long id)
        //{
        //    await TestGet();
        //    return View();

        //}

        [HttpPost]
        public async Task<JsonResult> GetImagesByCategory(string pCategoryName, long? pID = 0)
        {
          //  string json = string.Empty;
          ////https://www.amazingmail.com/services/gallery.php?auth=session&type=public_images&search=&recipe_item=0&page=1&size=100&width=-1&height=-1&gallery=m467
          //  using (var client = new HttpClient())
          //  {
          //      client.BaseAddress = new Uri("http://www.amazingmail.com");
          //      client.DefaultRequestHeaders.Accept.Clear();
          //      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

          //      HttpResponseMessage response = await client.GetAsync("/services/gallery.php?auth=session&type=public_images&search=&recipe_item=0&page=1&size=100&width=-1&height=-1&gallery=m467");
          //      if (response.IsSuccessStatusCode)
          //      {
          //          var categorydesigns = response.Content.ReadAsStringAsync();//response.Content.ReadAsStringAsync();
          //          //var xmlDoc = new XmlDocument();
          //          //xmlDoc.LoadXml(categorydesigns.Result);
          //          //var xxx = XDocument.Parse(categorydesigns.Result);
          //          //CategoryDesigns categoryDesigns = new JavaScriptSerializer().Deserialize<CategoryDesigns>(categorydesigns.Result);
          //          //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
          //          string res=categorydesigns.Result ;
          //          var xmlDoc = new XmlDocument();
          //          xmlDoc.LoadXml(res);
          //          json=Newtonsoft.Json.JsonConvert.SerializeXmlNode(xmlDoc);

             
                    
          //      }

          //  }
          //  var result=new {
          //      json=json
          //  }
            //return new JsonNetResult(result);



            var stringPath = Server.MapPath("~/" + "img/category/" + pCategoryName);
            var filenames = new List<object>();
            var filesstring = Directory.GetFiles(stringPath);
            foreach (var file in filesstring)
            {
                filenames.Add(Path.GetFileName(file));
            }
            var data = new
            {
                filenames = filenames
            };
            return new JsonNetResult(data);

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://www.amazingmail.com");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    HttpResponseMessage response = await client.GetAsync("/services/getcards.php?auth=teSSApnF&format=json&gallerytype=public&category=1627268&page=1&itemsperpage=100");
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var categorydesigns = response.Content.ReadAsStringAsync();
            //        CategoryDesigns categoryDesigns = new JavaScriptSerializer().Deserialize<CategoryDesigns>(categorydesigns.Result);
            //        //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
            //    }

            //}
        }

        public async Task TestGet()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.amazingmail.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("/services/getcards.php?auth=teSSApnF&format=json&gallerytype=public&category=1627268&page=1&itemsperpage=100");
                if (response.IsSuccessStatusCode)
                {
                    var categorydesigns = response.Content.ReadAsStringAsync();
                    CategoryDesigns categoryDesigns = new JavaScriptSerializer().Deserialize<CategoryDesigns>(categorydesigns.Result);
                    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                }

            }
        }

        public class CategoryDesigns
        {
            public List<Design> Designs { get; set; }
            public int TotalDesigns { get; set; }
        }

        public class Design
        {
            public string Name { get; set; }
            public List<Card> Cards { get; set; }
        }

        public class Card
        {
            public List<Thumbnail> Thumbnails { get; set; }
        }

        public class Thumbnail
        {
            public string URI { get; set; }
            public int Height { get; set; }
            public int Width { get; set; }
        }


    }
}