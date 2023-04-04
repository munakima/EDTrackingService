
using EDDTO;
using EDTrackingService.Infrastructure;
using EDTrackingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDTrackingService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var gate = new BLLServiceGateway<IEnumerable<SortingDTO>>();
            var model = new SortingListModel()
            {
                sortings = gate.GetItems("api/Sortings/")
            };

            return View(model);
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