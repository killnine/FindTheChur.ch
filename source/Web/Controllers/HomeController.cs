using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.DataAccess;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private IFindTheChurchRepository _churchRepository;
        public HomeController(IFindTheChurchRepository repository)
        {
            _churchRepository = repository;
        }

        public ActionResult Index()
        {
            var churches = _churchRepository.GetChurches().OrderByDescending(c => c.Name).Take(25).ToList();

            return View(churches);
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