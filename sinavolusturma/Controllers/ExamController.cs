using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using sinavolusturma.Entities;

namespace sinavolusturma.Controllers
{
    [Route("exam")]
    public class ExamController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View("Add", new question());
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(question question)
        {

            db.questions.Add(question);
            db.SaveChanges();
            return RedirectToAction("");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {

            db.questions.Remove(db.questions.Find(id));
            db.SaveChanges();
            return RedirectToAction("list");
        }

        [Route("")]
        [Route("~/")]
        
        public IActionResult list()
        {
            ViewBag.questions = db.questions.ToList();

            return View();
        }

        private DatabaseContext db;
        private DatabaseContext db2;

        public ExamController(DatabaseContext _db)
        {
            db = _db;
            db2 = _db;
        }





        //public string html;
        //public Uri url;
        //private static string GetContent(string urlAddress)
        //{
        //    Uri url = new Uri(urlAddress);
        //    WebClient client = new WebClient();
        //    client.Encoding = System.Text.Encoding.UTF8;

        //    string html = client.DownloadString(url);
        //    return html;
        //}
        //private static int GetPageCount()
        //{
        //    string url = "http://www.ted.com/translate/languages/tr";

        //    string htmlContent = GetContent(url);

        //    HtmlDocument document = new HtmlDocument();
        //    document.LoadHtml(htmlContent);

        //    var node = document.DocumentNode.SelectSingleNode("/html/body/div/div/div[2]/div/div/div[2]/div[2]/p/span[2]");

        //    int pageCount = Int32.Parse(node.InnerText);

        //    return pageCount;
        //}




    }
}
// GetPageCount();
// VeriAl("https://www.wired.com/story/the-pre-existing-conditions-of-the-coronavirus-pandemic/", "//*[@id='main - content']/article/div[1]/header/div/div[1]/h1");
//*[@id="app-root"]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]/div/ul/li[2]/a[2]/h2

//WebRequest istek1 = HttpWebRequest.Create("https://www.wired.com/");
//var cevap1 = istek1.GetResponse();
//CultureInfo tr = new CultureInfo("tr-TR");
//StreamReader donenbilgi1 = new StreamReader(cevap1.GetResponseStream(), Encoding.GetEncoding(tr.TextInfo.ANSICodePage));
//string gelen1 = donenbilgi1.ReadToEnd();

//int titlebaslangic = gelen1.IndexOf("<title>") + 7;

//int titlebitis = gelen1.Substring(titlebaslangic).IndexOf("</title>");