using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var _login = db.Users.Where(a => a.Username.Equals(user.Username) && a.Password.Equals(user.Password)).FirstOrDefault();
                if (_login != null)
                {

                  return RedirectToAction("UserDashBoard");
                }
            }
        }

        public IActionResult Index()
        {
            ViewBag.users = db.Users.ToList();


            return View();
        }
    }
}
