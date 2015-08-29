using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AmazingMail.Web.Areas.Gallery.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery/Gallery
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Category(long id)
        {
            await TestGet();
            return View();

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