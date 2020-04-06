using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(User user)
        {
            ViewBag.UserName = user.UserName;
            ViewBag.Email = user.Email;
            ViewBag.PhoneNum = user.PhoneNum;
            ViewBag.PassWord = user.PassWord;
                List<string> add = new List<string>();
            foreach (string genre in user.Genre)
            {
                add.Add(genre);
            }
            ViewBag.Genres = add;
            ViewBag.Pref = user.KeyboardPref;
            ViewBag.Birthday = user.BirthdayMonth;
            return View();
        }

        public IActionResult GeneratedView()
        {
            User person = new User
                {
                UserName = "Test Name",
                PassWord = "Password",
                Email = "Email@Email.com",
                Genre = new List<string> { "FPS","MOBA","JRPG"},
                KeyboardPref = "Mechanical",
                BirthdayMonth = "September",
                PhoneNum = "18002655467"
                }
            ;
            return View(person);
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
