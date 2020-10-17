using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sinavolusturma.Entities;

namespace sinavolusturma.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private DatabaseContext db;

        public UserController(DatabaseContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.users = db.Users.ToList();
            var model = new User();
            

            return View();
        }
    }
}
