using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PeopleSearch.Models;

/*Default controller for the PeopleSearch application.*/
namespace PeopleSearch.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleSearchDb _db = new PeopleSearchDb();

        //-- GET /
        //-- Returns the home page.
        public ActionResult Index()
        {
            return View();
        }

        //-- GET People/Search?query={}
        //-- Returns the search results in JSON format.
        //-- Supports only Person.FirstName and Person.LastName search.
        public ActionResult Search(String query)
        {
            var model = _db.People.OrderBy(r => r.FirstName)
                .Where(r => query == null || r.FirstName.StartsWith(query) || r.LastName.StartsWith(query))
                .Select(r => new PeopleListViewModel
                {
                    Id = r.Id,
                    Name = r.FirstName + " " + r.LastName,
                    Age = r.Age,
                    Address = r.Address,
                    Image = r.ImageId + "." + r.ImageExtension,
                    Interests = r.Interests
                });
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        //-- GET People/About
        public ActionResult About()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
