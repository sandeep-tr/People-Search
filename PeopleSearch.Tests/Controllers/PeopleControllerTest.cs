using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearch;
using PeopleSearch.Controllers;

/*
 Contains test cases to check if PeopleController methods are executing fine.
 */

namespace PeopleSearch.Tests.Controllers
{
    [TestClass]
    public class PeopleControllerTest
    {
        [TestMethod]
        public void Index()
        {
            PeopleController controller = new PeopleController();
            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            PeopleController controller = new PeopleController();
            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
