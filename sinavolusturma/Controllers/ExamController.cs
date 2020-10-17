using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sinavolusturma.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            WebRequest istek1 = HttpWebRequest.Create("https://www.wired.com/");
            var cevap1 = istek1.GetResponse();
            CultureInfo tr = new CultureInfo("tr-TR");
            StreamReader donenbilgi1 = new StreamReader(cevap1.GetResponseStream(), Encoding.GetEncoding(tr.TextInfo.ANSICodePage));
            string gelen1 = donenbilgi1.ReadToEnd();

            int titlebaslangic = gelen1.IndexOf("<title>") + 7;

            int titlebitis = gelen1.Substring(titlebaslangic).IndexOf("</title>");<xzxz<xz<

            return View();
        }
    }
}
