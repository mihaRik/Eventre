using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventre.DAL;
using Eventre.Models;
using Eventre.Models.ViewModels;

namespace Eventre.Controllers
{
    public class HomeController : Controller
    {
        private readonly EventreContext _db;

        public HomeController()
        {
            _db = new EventreContext();
        }

        public ActionResult Index()
        {
            var vm = new HomeIndexViewModel
            {
                Header = _db.Headers.FirstOrDefault(),
                About = _db.About.FirstOrDefault(),
                Speakers=_db.Speakers
            };
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}