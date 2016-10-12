using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Braennbollsturnering.Library;
using Braennbollsturnering.Library.Interfaces;
using Braennbollsturnering.Models;

namespace Braennbollsturnering.Controllers
{
    public class HomeController : Controller
    {
        private IDataService _dataService;

        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public ActionResult Index()
        {
            return View();
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

        public ActionResult Teams()
        {
            ViewBag.Message = "Your Teams page.";

            IEnumerable<Team> teams = _dataService.GetTeams();

            return View(teams);
        }

        public ActionResult Rules()
        {
            ViewBag.Message = "Your Rules page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your Gallery page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}