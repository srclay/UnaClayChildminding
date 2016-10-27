using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnaClayChildminding.Models;
using UnaClayChildminding.models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace UnaClayChildminding.Controllers
{
    public class HomeController : Controller
    {

        private IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Qualifications()
        {
            return View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Testimonials()
        {
            return View();
            //return View(db.Testimonials.ToList());
        }

        public IActionResult Gallery()
        {
            var model = new Gallery()
            {
                Images = Directory.EnumerateFiles(_env.WebRootPath + "/images/uploads")
                          .Select(fn => "/images/uploads/" + Path.GetFileName(fn))
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Admin()
        {
            var a = new Admin() { Availability = "3 Full time places" };
            return View(a);
        }

        [HttpPost]
        public IActionResult Admin(Admin a)
        {
            return View(a);
        }


        public IActionResult Parents()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
