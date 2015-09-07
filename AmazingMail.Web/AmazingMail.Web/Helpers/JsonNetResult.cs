using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace AmazingMail.Web.Helpers
{
    public class JsonNetResult : JsonResult
    {

        public JsonNetResult(object objectToSerialize)
        {
            Data = objectToSerialize;
        }

        public new object Data { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = "application/json";
            var data = SerializeJson(Data);
            response.Write(data);
            //response.Flush();
            response.End();
        }
        public static string SerializeJson(object obj)
        {
            if (obj == null)
            {
                return "{}";
            }
            var jss = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            string response = JsonConvert.SerializeObject(obj, jss);
            var regex = new Regex(@"(\\/Date\()(\d*?)(-\d*?)(\)\\/)");
            while (regex.IsMatch(response))
            {
                response = regex.Replace(response, "$1$2$4");
            }



            return response;
        }

    }
}
