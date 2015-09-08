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
    public class GalleryController : Controller
    {
        // GET: Gallery/Gallery
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GreetingCards()
        {
            return View();
        }

        public async Task<ActionResult> Category(long id)
        {
            await TestGet();
            return View();

        }

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