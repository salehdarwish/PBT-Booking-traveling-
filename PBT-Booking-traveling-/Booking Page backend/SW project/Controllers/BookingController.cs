using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SW_project.Models;
using System.Text;

namespace SW_project.Controllers
{
    public class BookingController : Controller
    {
        private BookingViewModel model = new BookingViewModel();

        [HttpGet]
        public ActionResult Index()
        {
               return View(model);
        }

        [HttpPost]
        public ActionResult Index(string CountryFrom, string CityFrom, string CountryTo, string CityTo)
        {
  
               model.CheckCountryFrom(CountryFrom);
               model.CheckCountryTo(CountryTo);
               model.CheckCityFrom(CountryFrom, CityFrom);
               model.CheckCityTo(CountryTo, CityTo);
               model.Isvalid();
               model.script = MvcHtmlString.Create("$('html, body').animate({'scrollTop': 550}, 800);");

               return View(model);
        }

        public ActionResult GetCountry(string term)
          {
               BookingViewModel b = new BookingViewModel();
               return Json(b.GetCountry(term), JsonRequestBehavior.AllowGet);
          }
        public ActionResult GetCity(string term)
          {
               BookingViewModel b = new BookingViewModel();
               return Json(b.GetCity(term), JsonRequestBehavior.AllowGet);
          }

    }
}
